using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Proyecto_Integrador.Modelos.Facturas;
using System.Globalization;

namespace Proyecto_Integrador.Services;


public static class FacturaPdfGeneradorService
{
    private const string C_PRIMARIO = "#1E3A5F";
    private const string C_SECUNDARIO = "#2E6DA4";
    private const string C_ACENTO = "#F5A623";
    private const string C_FONDO = "#F0F4F8";
    private const string C_GRIS = "#6B7280";

    private const string EMPRESA_NOMBRE = "Geoterra S.A.S.";
    private const string EMPRESA_NIT = "NIT: 123.000.000-1";
    private const string EMPRESA_DIRECCION = "Seccional Aguachica Carrera 40 Vía al mar";
    private const string EMPRESA_TELEFONO = "+57 (601) 123-0000";
    private const string EMPRESA_EMAIL = "geoterra@unicesar.com";


    public static string Generar(
        Factura factura,
        byte[]? imgTerreno = null,
        string? rutaLogo = null)
    {
        var carpeta = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "Facturas");
        Directory.CreateDirectory(carpeta);

        string nombre = $"Factura_{factura.Id.ToString()[..8]}_{factura.FechaEmision:yyyyMMdd}.pdf";
        string ruta = Path.Combine(carpeta, nombre);

        Document.Create(doc => Construir(doc, factura, imgTerreno, rutaLogo))
                .GeneratePdf(ruta);

        return ruta;
    }

    private static void Construir(
        IDocumentContainer doc,
        Factura factura,
        byte[]? imgTerreno,
        string? rutaLogo)
    {
        doc.Page(page =>
        {
            page.Size(PageSizes.A4);
            page.Margin(40);
            page.DefaultTextStyle(t => t.FontFamily("Arial").FontSize(9));

            page.Header().Element(c => Header(c, factura, rutaLogo));
            page.Content().Element(c => Contenido(c, factura, imgTerreno));
        });
    }

    private static void Header(IContainer cnt, Factura factura, string? rutaLogo)
    {
        cnt
            .BorderBottom(2).BorderColor(C_ACENTO)
            .PaddingBottom(12)
            .Row(row =>
            {
                // ── Logo + datos empresa ──────────────────────────────────
                row.RelativeItem(3).Row(lr =>
                {
                    // Logo
                    lr.ConstantItem(72).Height(72).Element(logo =>
                    {
                        bool hayLogo = !string.IsNullOrEmpty(rutaLogo)
                                       && File.Exists(rutaLogo);
                        if (hayLogo)
                            logo.Image(rutaLogo!).FitArea();
                        else
                            logo.Background(C_SECUNDARIO)
                                .AlignCenter().AlignMiddle()
                                .Text("LOGO")
                                .FontColor(Colors.White).FontSize(11).Bold();
                    });

                    lr.ConstantItem(12);

                    lr.RelativeItem().Column(col =>
                    {
                        col.Item().Text(EMPRESA_NOMBRE)
                           .FontSize(14).Bold().FontColor(C_PRIMARIO);
                        col.Item().Text(EMPRESA_NIT)
                           .FontSize(8).FontColor(C_GRIS);
                        col.Item().Text(EMPRESA_DIRECCION)
                           .FontSize(8).FontColor(C_GRIS);
                        col.Item().Text(EMPRESA_TELEFONO)
                           .FontSize(8).FontColor(C_GRIS);
                        col.Item().Text(EMPRESA_EMAIL)
                           .FontSize(8).FontColor(C_GRIS);
                    });
                });

                row.ConstantItem(20);
                
                row.RelativeItem(2)
                   .Background(C_PRIMARIO)
                   .Padding(14)
                   .Column(col =>
                   {
                       col.Item().AlignCenter()
                          .Text("FACTURA")
                          .FontSize(16).Bold().FontColor(Colors.White);

                       col.Item().Height(8);

                       FilaInfoFactura(col, "N°:",
                           factura.Id.ToString()[..8].ToUpper());
                       FilaInfoFactura(col, "Fecha:",
                           factura.FechaEmision.ToString("dd/MM/yyyy HH:mm"));
                       FilaInfoFactura(col, "Estado:",
                           factura.Estado);
                   });
            });
    }

    private static void FilaInfoFactura(ColumnDescriptor col, string etiqueta, string valor)
    {
        col.Item().Row(r =>
        {
            r.RelativeItem().Text(etiqueta)
             .FontSize(8).FontColor(Colors.Grey.Lighten3);
            r.RelativeItem().AlignRight().Text(valor)
             .FontSize(9).Bold().FontColor(C_ACENTO);
        });
    }

    private static void Contenido(
        IContainer cnt,
        Factura factura,
        byte[]? imgTerreno)
    {
        cnt.Column(col =>
        {
            col.Spacing(16);
            col.Item().Element(c => SeccionCliente(c, factura));
            col.Item().Element(c => SeccionDetalle(c, factura));
            col.Item().Element(c => SeccionTotal(c, factura));
            col.Item().Element(c => SeccionGraficas(c, imgTerreno));
            col.Item().Height(8);
            col.Item().Element(c => SeccionPie(c, factura));
        });
    }

    // ── Sección Cliente ───────────────────────────────────────────────────────
    private static void SeccionCliente(IContainer cnt, Factura factura)
    {
        var c = factura.Cliente;

        cnt.Column(col =>
        {
            col.Item().Element(c2 => TituloSeccion(c2, "DATOS DEL CLIENTE"));
            col.Item().Height(6);

            col.Item()
               .Border(1).BorderColor(Colors.Grey.Lighten2)
               .Background(C_FONDO)
               .Padding(10)
               .Row(row =>
               {
                   row.RelativeItem().Column(datos =>
                   {
                       Dato(datos, "Nombre", c?.NombreCompleto ?? "—");
                       Dato(datos, "Documento", c?.Documento ?? "—");
                   });
                   row.RelativeItem().Column(datos =>
                   {
                       Dato(datos, "Teléfono", c?.Telefono ?? "—");
                       Dato(datos, "Dirección", c?.Direccion ?? "—");
                   });
               });
        });
    }

    // ── Sección Detalle ───────────────────────────────────────────────────────
    private static void SeccionDetalle(IContainer cnt, Factura factura)
    {
        var cot = factura.Cotizacion;
        var cultura = new CultureInfo("es-CO");

        cnt.Column(col =>
        {
            col.Item().Element(c => TituloSeccion(c, "DETALLE DE COTIZACIÓN"));
            col.Item().Height(6);

            // Encabezado tabla
            col.Item()
               .Background(C_PRIMARIO).Padding(8)
               .Row(row =>
               {
                   Th(row, "Material / Descripción", 4);
                   ThC(row, "Volumen (m³)", 2);
                   ThC(row, "Precio / m³", 2);
                   ThR(row, "Subtotal", 2);
               });

            // Fila de datos
            col.Item()
               .Border(1).BorderColor(Colors.Grey.Lighten2)
               .Padding(8)
               .Row(row =>
               {
                   row.RelativeItem(4)
                      .Text(cot?.Material?.Nombre ?? "—").FontSize(9);

                   row.RelativeItem(2).AlignCenter()
                      .Text($"{cot?.VolumenCalculado:F4} m³").FontSize(9);

                   row.RelativeItem(2).AlignCenter()
                      .Text(cot?.Material?.ValorMetroCubico
                                .ToString("C0", cultura) ?? "$0").FontSize(9);

                   row.RelativeItem(2).AlignRight()
                      .Text(factura.Total.ToString("C0", cultura))
                      .Bold().FontColor(C_PRIMARIO).FontSize(9);
               });

            // Fila decorativa vacía
            col.Item()
               .Border(1).BorderColor(Colors.Grey.Lighten2)
               .BorderTop(0).Height(18);
        });
    }

    // ── Sección Total ─────────────────────────────────────────────────────────
    private static void SeccionTotal(IContainer cnt, Factura factura)
    {
        var cultura = new CultureInfo("es-CO");

        cnt.AlignRight().Width(260).Column(col =>
        {
            // Subtotal
            col.Item()
               .Background(C_FONDO)
               .Border(1).BorderColor(Colors.Grey.Lighten2)
               .Padding(8)
               .Row(r =>
               {
                   r.RelativeItem().Text("Subtotal:").Bold().FontSize(9);
                   r.ConstantItem(110).AlignRight()
                    .Text(factura.Total.ToString("C0", cultura)).FontSize(9);
               });

            // IVA
            col.Item()
               .Background(C_FONDO)
               .Border(1).BorderColor(Colors.Grey.Lighten2)
               .BorderTop(0).Padding(8)
               .Row(r =>
               {
                   r.RelativeItem()
                    .Text("IVA (0%):").FontColor(C_GRIS).FontSize(9);
                   r.ConstantItem(110).AlignRight()
                    .Text("$0").FontColor(C_GRIS).FontSize(9);
               });

            // Total destacado
            col.Item()
               .Background(C_PRIMARIO).Padding(10)
               .Row(r =>
               {
                   r.RelativeItem()
                    .Text("TOTAL:")
                    .FontColor(Colors.White).Bold().FontSize(11);
                   r.ConstantItem(130).AlignRight()
                    .Text(factura.Total.ToString("C0", cultura))
                    .FontColor(C_ACENTO).Bold().FontSize(13);
               });
        });
    }

    // ── Sección Gráfica 3D ─────────────────────────────────────────────────────
    private const float AnchoGraficaPdf = 255f;
    private const float AltoGraficaPdf = 168f;

    private static void SeccionGraficas(
        IContainer cnt,
        byte[]? imgTerreno)
    {
        cnt.Column(col =>
        {
            col.Item().Element(c => TituloSeccion(c, "VISUALIZACIÓN DEL TERRENO"));
            col.Item().Height(8);

            col.Item().AlignCenter().Width(AnchoGraficaPdf).Column(c =>
            {
                c.Item().Background(C_PRIMARIO).Padding(6)
                 .AlignCenter()
                 .Text("Terreno")
                 .FontColor(Colors.White).Bold().FontSize(8);

                c.Item()
                 .Border(1).BorderColor(Colors.Grey.Lighten2)
                 .Height(AltoGraficaPdf)
                 .AlignCenter()
                 .AlignMiddle()
                 .Element(img =>
                 {
                     if (imgTerreno != null)
                         img.Image(imgTerreno).FitArea();
                     else
                         img.Background(C_FONDO).AlignCenter().AlignMiddle()
                            .Text("Sin imagen").FontColor(C_GRIS);
                 });
            });

            col.Item().Height(6);
            col.Item()
               .Background(C_FONDO).Padding(6)
               .Text("La gráfica representa la visualización 3D del terreno. " +
                     "El volumen fue calculado mediante integración numérica " +
                     "(Regla del Trapecio 2D) sobre la grilla de puntos ingresados.")
               .FontSize(7.5f).FontColor(C_GRIS).Italic();
        });
    }

    // ─────────────────────────────────────────────────────────────────────────
    // PIE (fluye después de la gráfica, sin espacio vacío al final de página)
    // ─────────────────────────────────────────────────────────────────────────
    private static void SeccionPie(IContainer cnt, Factura factura)
    {
        cnt
            .BorderTop(1).BorderColor(Colors.Grey.Lighten2)
            .PaddingTop(10)
            .Column(col =>
            {
                col.Item()
                   .Text("Esta factura tiene vigencia de 30 días a partir de la fecha de emisión. " +
                         "Precios sujetos a cambio sin previo aviso.")
                   .FontSize(7.5f).FontColor(C_GRIS).Italic();

                col.Item().Height(6);

                col.Item().Row(row =>
                {
                    // Firma
                    row.RelativeItem().Column(c =>
                    {
                        c.Item().Height(28);
                        c.Item()
                         .BorderTop(1).BorderColor(C_PRIMARIO)
                         .PaddingTop(4)
                         .Text("Firma autorizada")
                         .FontSize(7.5f).FontColor(C_GRIS);
                        c.Item().Text(EMPRESA_NOMBRE)
                         .FontSize(7.5f).Bold().FontColor(C_PRIMARIO);
                    });

                    // Número de página
                    row.RelativeItem().AlignRight().AlignBottom().Text(t =>
                    {
                        t.Span("Página ").FontSize(7.5f).FontColor(C_GRIS);
                        t.CurrentPageNumber().FontSize(7.5f).FontColor(C_GRIS);
                        t.Span(" de ").FontSize(7.5f).FontColor(C_GRIS);
                        t.TotalPages().FontSize(7.5f).FontColor(C_GRIS);
                    });
                });
            });
    }

    // ─────────────────────────────────────────────────────────────────────────
    // HELPERS de layout
    // ─────────────────────────────────────────────────────────────────────────
    private static void TituloSeccion(IContainer c, string texto) =>
        c.BorderBottom(2).BorderColor(C_ACENTO).PaddingBottom(4)
         .Text(texto).FontSize(10).Bold().FontColor(C_PRIMARIO);

    private static void Dato(ColumnDescriptor col, string label, string valor)
    {
        col.Item().PaddingBottom(3).Text(t =>
        {
            t.Span($"{label}:  ").Bold().FontColor(C_PRIMARIO).FontSize(8.5f);
            t.Span(valor).FontSize(8.5f);
        });
    }

    // Helpers para encabezados de tabla
    private static void Th(RowDescriptor row, string txt, int rel) =>
        row.RelativeItem(rel).Text(txt)
           .FontColor(Colors.White).Bold().FontSize(8.5f);

    private static void ThC(RowDescriptor row, string txt, int rel) =>
        row.RelativeItem(rel).AlignCenter().Text(txt)
           .FontColor(Colors.White).Bold().FontSize(8.5f);

    private static void ThR(RowDescriptor row, string txt, int rel) =>
        row.RelativeItem(rel).AlignRight().Text(txt)
           .FontColor(Colors.White).Bold().FontSize(8.5f);
}
