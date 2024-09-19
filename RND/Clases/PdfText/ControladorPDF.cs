/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 23/08/2018
 * Hora: 08:08 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PicosSectores.Clases;
using RND.Properties;

namespace RND.Clases.PdfText {
    /// <summary>
    /// Description of ControladorPDF.
    /// </summary>
    public class ControladorPDF {
        private readonly Document documento;

        public ControladorPDF() {
            documento = new Document();
            documento.SetPageSize(PageSize.A4);
            // 1 pulgada = 72
            documento.SetMargins(72, 36, 36, 36);
        }

        public void GuardarSorteoNumeros(string nombreArchivo, string tituloSorteo, string fechaSorteo,
                                     string inicio, string tope, string rango, List<int> sorteoGenerado,
                                     List<int> sorteoVerificacion, bool verificacionSeparada) {

            try {
                PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(nombreArchivo, FileMode.Create));
                // si no se usa phrase o paragraph se debe setear el espaciado vertical (espaciado entre lineas):
                writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_6);

                documento.Open();
                documento.Add(CrearEncabezado(tituloSorteo));

                // tabla informacion
                PdfPTable tabla = CrearTablaInformacion();

                // FILA 1				
                tabla.AddCell(CrearCeldaTitulo("Fecha de Sorteo", 1));
                tabla.AddCell(CrearCeldaContenido(fechaSorteo));
                tabla.CompleteRow();
                tabla.SpacingAfter = 10;

                // FILA 2
                tabla.AddCell(CrearCeldaTitulo("Inicio"));
                tabla.AddCell(CrearCeldaContenido(inicio));

                tabla.AddCell(CrearCeldaVacia(0));

                tabla.AddCell(CrearCeldaTitulo("Tope"));
                tabla.AddCell(CrearCeldaContenido(tope));
                tabla.CompleteRow();
                tabla.SpacingAfter = 10;

                // FILA 3
                tabla.AddCell(CrearCeldaTitulo("Cantidad"));
                tabla.AddCell(CrearCeldaContenido(sorteoGenerado.Count.ToString()));
                tabla.AddCell(CrearCeldaVacia(0));

                tabla.AddCell(CrearCeldaTitulo("Rango"));
                string rangoContenido = string.IsNullOrEmpty(rango) || rango == "0" ? rangoContenido = "N/A" : rango;
                tabla.AddCell(CrearCeldaContenido(rangoContenido));
                tabla.CompleteRow();
                tabla.SpacingAfter = 10;

                documento.Add(tabla);

                // tabla sorteo
                int elementos = sorteoGenerado.Count;
                int columnas = elementos <= 3 ? columnas = elementos : (int)(elementos / 3);
                columnas = columnas >= 15 ? columnas = 15 : columnas;
                tabla = CrearTablaResultado(columnas);

                // FILA 1 - Titulo
                tabla.AddCell(CrearCeldaTitulo("Numeros Sorteados", columnas));

                // FILAS -1 (restantes)
                foreach (int numero in sorteoGenerado) {
                    tabla.AddCell(CrearCeldaContenidoTabla(numero.ToString()));
                }
                tabla.CompleteRow();
                documento.Add(tabla);

                // tabla verificación                
                if (sorteoVerificacion != null) {
                    if (verificacionSeparada) {
                        documento.NewPage();
                        documento.Add(CrearEncabezado(tituloSorteo));
                    }
                    elementos = sorteoVerificacion.Count;
                    if (elementos > 0) {
                        columnas = elementos <= 3 ? columnas = elementos : (int)(elementos / 3);
                        columnas = columnas >= 15 ? columnas = 15 : columnas;
                        tabla = CrearTablaResultado(columnas);

                        // FILA 1 - Titulo
                        tabla.AddCell(CrearCeldaTitulo("Numeros Sorteados para Verificación", columnas));

                        // FILAS -1 (restantes)
                        foreach (int numero in sorteoVerificacion) {
                            tabla.AddCell(CrearCeldaContenidoTabla(numero.ToString()));
                        }
                        tabla.CompleteRow();
                        documento.Add(tabla);
                    }
                }
                documento.Close();

            } catch (IOException ex) {
                System.Console.Out.WriteLine("IO Error: " + ex.Message);
                System.Windows.Forms.MessageBox.Show("No se pudo guardar el sorteo.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            } catch (DocumentException) {
                System.Windows.Forms.MessageBox.Show("No se pudo guardar el sorteo.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            System.Windows.Forms.MessageBox.Show("El sorteo se guardo", "Correcto", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

        }

        public void GuardarSorteoFechas(string nombreArchivo, string tituloSorteo, string fechaSorteo,
                                     string inicio, string tope, bool incluyeDomingos, List<string> sorteoGenerado) {

            try {
                PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(nombreArchivo, FileMode.Create));
                // si no se usa phrase o paragraph se debe setear el espaciado vertical (espaciado entre lineas):
                writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_6);

                documento.Open();
                documento.Add(CrearEncabezado(tituloSorteo));

                // tabla informacion
                PdfPTable tabla = CrearTablaInformacion();

                // FILA 1				
                tabla.AddCell(CrearCeldaTitulo("Fecha de Sorteo", 1));
                tabla.AddCell(CrearCeldaContenido(fechaSorteo));
                tabla.CompleteRow();
                tabla.SpacingAfter = 10;

                // FILA 2
                tabla.AddCell(CrearCeldaTitulo("Inicio"));
                tabla.AddCell(CrearCeldaContenido(inicio));

                tabla.AddCell(CrearCeldaVacia(0));

                tabla.AddCell(CrearCeldaTitulo("Tope"));
                tabla.AddCell(CrearCeldaContenido(tope));
                tabla.CompleteRow();
                tabla.SpacingAfter = 10;

                // FILA 3
                tabla.AddCell(CrearCeldaTitulo("Cantidad"));
                tabla.AddCell(CrearCeldaContenido(sorteoGenerado.Count.ToString()));
                tabla.AddCell(CrearCeldaVacia(0));

                tabla.AddCell(CrearCeldaTitulo("Incluye Domingos?"));
                string rangoContenido = incluyeDomingos ? "Si" : "No";
                tabla.AddCell(CrearCeldaContenido(rangoContenido));
                tabla.CompleteRow();
                tabla.SpacingAfter = 10;

                documento.Add(tabla);

                // tabla sorteo
                int elementos = sorteoGenerado.Count;
                int columnas = elementos <= 3 ? columnas = elementos : (int)(elementos / 3);
                columnas = columnas >= 15 ? columnas = 15 : columnas;
                tabla = CrearTablaResultado(columnas);

                // FILA 1 - Titulo
                tabla.AddCell(CrearCeldaTitulo("Fechas Sorteadas", columnas));

                // FILAS -1 (restantes)
                foreach (string sorteado in sorteoGenerado) {
                    tabla.AddCell(CrearCeldaContenidoTabla(sorteado));
                }
                tabla.CompleteRow();
                documento.Add(tabla);
                documento.Close();

            } catch (IOException ex) {
                System.Console.Out.WriteLine("IO Error: " + ex.Message);
                System.Windows.Forms.MessageBox.Show("No se pudo guardar el sorteo.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            } catch (DocumentException) {
                System.Windows.Forms.MessageBox.Show("No se pudo guardar el sorteo.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            System.Windows.Forms.MessageBox.Show("El sorteo se guardo", "Correcto", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

        }

        public void GuardarSorteoPicos(string nombreArchivo, string tituloSorteo, string fechaSorteo,
                                     string inicio, string tope, List<Pico> sorteoGenerado) {

            try {
                PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(nombreArchivo, FileMode.Create));
                // si no se usa phrase o paragraph se debe setear el espaciado vertical (espaciado entre lineas):
                writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_6);

                documento.Open();
                documento.Add(CrearEncabezado(tituloSorteo));

                // tabla informacion
                PdfPTable tabla = CrearTablaInformacion();

                // FILA 1				
                tabla.AddCell(CrearCeldaTitulo("Fecha de Sorteo", 1));
                tabla.AddCell(CrearCeldaContenido(fechaSorteo));
                tabla.CompleteRow();
                tabla.SpacingAfter = 10;

                // FILA 2
                tabla.AddCell(CrearCeldaTitulo("Inicio"));
                tabla.AddCell(CrearCeldaContenido(inicio));

                tabla.AddCell(CrearCeldaVacia(0));

                tabla.AddCell(CrearCeldaTitulo("Tope"));
                tabla.AddCell(CrearCeldaContenido(tope));
                tabla.CompleteRow();
                tabla.SpacingAfter = 10;

                // FILA 3
                tabla.AddCell(CrearCeldaTitulo("Cantidad"));
                tabla.AddCell(CrearCeldaContenido(sorteoGenerado.Count.ToString()));
                tabla.AddCell(CrearCeldaVacia(0));

                documento.Add(tabla);

                // tabla sorteo
                int elementos = sorteoGenerado.Count;
                int columnas = elementos <= 3 ? columnas = elementos : (int)(elementos / 3);
                columnas = columnas >= 15 ? columnas = 15 : columnas;
                tabla = CrearTablaResultado(columnas);

                // FILA 1 - Titulo
                tabla.AddCell(CrearCeldaTitulo("Numeros Sorteados", columnas));

                // FILAS -1 (restantes)
                foreach (Pico pico in sorteoGenerado) {
                    tabla.AddCell(CrearCeldaContenidoTabla($"{pico.Id.ToString()}: {pico.Nombre} - {pico.Sector.Nombre} "));
                }
                tabla.CompleteRow();
                documento.Add(tabla);

                documento.Close();

            } catch (IOException ex) {
                System.Console.Out.WriteLine("IO Error: " + ex.Message);
                System.Windows.Forms.MessageBox.Show("No se pudo guardar el sorteo.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            } catch (DocumentException) {
                System.Windows.Forms.MessageBox.Show("No se pudo guardar el sorteo.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            System.Windows.Forms.MessageBox.Show("El sorteo se guardo", "Correcto", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

        }

        private PdfPCell CrearCeldaTitulo(string textoTitulo, int colspan = 0) =>
               new PdfPCell {
                   Colspan = colspan,
                   PaddingBottom = 5,
                   VerticalAlignment = Element.ALIGN_MIDDLE,
                   BackgroundColor = BaseColor.GRAY,
                   Phrase = new Phrase(textoTitulo, Fuentes.CELDA_TITULO)
               };


        private PdfPCell CrearCeldaContenido(string textoContenido, int colspan = 0) =>
                new PdfPCell {
                    Colspan = colspan,
                    PaddingBottom = 5,
                    BorderWidthTop = 0,
                    BorderWidthRight = 0,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    Phrase = new Phrase(textoContenido, Fuentes.CELDA_CONTENIDO)
                };


        private PdfPCell CrearCeldaContenidoTabla(string textoContenido) =>
          new PdfPCell {
              PaddingBottom = 5,
              HorizontalAlignment = Element.ALIGN_CENTER,
              Phrase = new Phrase(textoContenido, Fuentes.CELDA_CONTENIDO)
          };

        private PdfPCell CrearCeldaVacia(int colspan) =>
            new PdfPCell {
                Colspan = colspan,
                BorderWidthTop = 0,
                BorderWidthRight = 0,
                BorderWidthBottom = 0,
                BorderWidthLeft = 0,
                HorizontalAlignment = Element.ALIGN_CENTER,
                Phrase = new Phrase("  ", Fuentes.CELDA_CONTENIDO)
            };


        /// <summary>
        /// Crea la tabla que aloja el encabezado y la completa con los datos.
        /// </summary>
        /// <param name="tituloImpresion"></param>
        /// <returns></returns>
        private PdfPTable CrearEncabezado(string tituloImpresion) {
            PdfPTable tablaEncabezado = new PdfPTable(2) {
                WidthPercentage = 100f
            };
           
            tablaEncabezado.SetWidths(new int[] { 30, 70 });
            tablaEncabezado.AddCell(CrearLogo());
            tablaEncabezado.AddCell(CrearDatosEmpresa());
            tablaEncabezado.AddCell(CrearTituloImpresion(tituloImpresion));
            tablaEncabezado.SpacingAfter = 5;

            return tablaEncabezado;
        }

        /// <summary>
        /// Crea la tabla presentar la informacion basica del sorteo.
        /// </summary>
        /// <returns></returns>
        private PdfPTable CrearTablaInformacion() {
            PdfPTable tabla = new PdfPTable(5) {
                WidthPercentage = 100
            };
            tabla.DefaultCell.BorderWidthBottom = 0;
            tabla.DefaultCell.BorderWidthTop = 0;
            tabla.DefaultCell.BorderWidthRight = 0;
            tabla.DefaultCell.BorderWidthLeft = 0;           
            tabla.SetWidths(new int[] { 25, 15, 15, 25, 15 });
            return tabla;
        }

        /// <summary>
        /// Crea la tabla para presentar el resultado del sorteo.
        /// La primer fila corresponde al encabezado.
        /// </summary>
        /// <returns></returns>
        private PdfPTable CrearTablaResultado(int totalColumnas) {
            PdfPTable tabla = new PdfPTable(totalColumnas) {
                WidthPercentage = 100,
                HeaderRows = 1
            };
            tabla.DefaultCell.BorderWidthBottom = 1;
            tabla.DefaultCell.BorderWidthTop = 1;
            tabla.DefaultCell.BorderWidthRight = 1;
            tabla.DefaultCell.BorderWidthLeft = 1;
            return tabla;
        }


        /// <summary>
        /// Genera la celda e inserta el logo de la empresa.
        /// El logo se escala automaticamente para un alto de media pulgada (1/2 in = 36).
        /// </summary>
        /// <returns></returns>
        private PdfPCell CrearLogo() {
            Phrase frase = new Phrase();
            Image logo = Image.GetInstance(Resources.MarfrigLogo, System.Drawing.Imaging.ImageFormat.Png);
            logo.ScaleToFit(1000, 36);
            logo.Alignment = Element.ALIGN_LEFT;
            Chunk chLogo = new Chunk(logo, 0, 0, true);
            frase.Add(chLogo);

            return new PdfPCell(frase) {
                BorderWidth = 0
            };
        }

        /// <summary>
        /// Genera la celda con los datos de la empresa
        /// </summary>
        /// <returns></returns>
        private PdfPCell CrearDatosEmpresa() {
            Phrase frase = new Phrase(new Chunk("Unidad Productiva San José", Fuentes.ENCABEZADO_TEXTO_NORMAL));
            frase.Add(Chunk.NEWLINE);
            frase.Add(new Chunk("INALER S.A. - EST. 55", Fuentes.ENCABEZADO_RESALTADO));
            frase.Add(Chunk.NEWLINE);
            frase.Add(new Chunk("Paraje Bañado, San José, Uruguay", Fuentes.ENCABEZADO_TEXTO_NORMAL));
            frase.Add(Chunk.NEWLINE);
            frase.Add(new Chunk("Tel: (+598) 4342 2525 | (+598) 4342 2420", Fuentes.ENCABEZADO_TEXTO_NORMAL));

            return new PdfPCell(frase) {
                HorizontalAlignment = Element.ALIGN_LEFT,
                BorderWidth = 0
            };
        }

        /// <summary>
        /// Genera celda con la barra de tiulo
        /// </summary>
        /// <param name="titulo"></param>
        /// <returns></returns>
        private PdfPCell CrearTituloImpresion(string titulo) =>
            new PdfPCell() {
                Colspan = 2,
                BackgroundColor = Fuentes.AZUL_INSTITUCIONAL_2021,
                BorderWidth = 0,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                PaddingBottom = 5,
                Phrase = new Phrase(titulo.ToUpper(), Fuentes.ENCABEZADO_TITULO)
            };

    }
}
