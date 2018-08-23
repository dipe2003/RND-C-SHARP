/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 23/08/2018
 * Hora: 08:07 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using iTextSharp.text;

namespace RND.Clases.PdfText
{
	/// <summary>
	/// Description of Fuentes.
	/// </summary>
	public static class Fuentes{
		
		public static Font NORMAL = new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.BLACK);
		public static Font BOLD = new Font(Font.FontFamily.HELVETICA, 10, Font.BOLD, BaseColor.BLACK);
		public static Font ITALIC = new Font(Font.FontFamily.HELVETICA, 10, Font.ITALIC, BaseColor.BLACK);

		public static Font NORMAL_TITULO = new Font(Font.FontFamily.HELVETICA, 11, Font.NORMAL, BaseColor.BLACK);
		public static Font BOLD_TITULO = new Font(Font.FontFamily.HELVETICA, 11, Font.BOLD, BaseColor.BLACK);
		public static Font ITALIC_TITULO = new Font(Font.FontFamily.HELVETICA, 11, Font.ITALIC, BaseColor.BLACK);
		
		public static Font ENCABEZADO_RESALTADO = new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD, BaseColor.BLACK);
		public static Font ENCABEZADO_TEXTO_NORMAL = new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);
		public static Font ENCABEZADO_TEXTO_PEQUENIO = new Font(Font.FontFamily.HELVETICA, 6, Font.NORMAL, BaseColor.BLACK);
		public static Font ENCABEZADO_TITULO = new Font(Font.FontFamily.HELVETICA, 11, Font.BOLD, BaseColor.WHITE);
		
		public static BaseColor AZUL_INSTITUCIONAL = new BaseColor(44,86,151);
		public static Font CELDA_TITULO = new Font(Font.FontFamily.HELVETICA, 10, Font.BOLD, BaseColor.WHITE);
		public static Font CELDA_CONTENIDO = new Font(Font.FontFamily.HELVETICA, 9, Font.NORMAL, BaseColor.BLACK);
	}
}
