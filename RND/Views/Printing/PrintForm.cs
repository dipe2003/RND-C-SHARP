using RND.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RND.Printing {
    public partial class PrintForm :Form {
        public PrintForm() {
            InitializeComponent();
        }

        public Sorteo SorteoAImprimir { get; set; }
        public EnumSorteo TipoSorteo { get; set; }
        public bool ResultadoOrdenado { get; set; }

        private void CargarDatosSorteo() {
            // llenar campos de texto
            this.txtFecha.Text = SorteoAImprimir.Fecha.ToShortDateString();
            this.txtInicio.Text = SorteoAImprimir.Inicio.ToString();
            this.txtTope.Text = SorteoAImprimir.Tope.ToString();
            this.txtRango.Visible = false;
            this.chkOrdenados.Checked = ResultadoOrdenado;
            switch(TipoSorteo) {
                case EnumSorteo.HACCP:
                    this.txtTipoSorteo.Text = EnumSorteo.HACCP.ToString();
                    this.txtRango.Text = (SorteoAImprimir as Haccp).Rango.ToString();
                    this.txtTotalSorteo.Text = (SorteoAImprimir as Haccp).Cantidad.ToString();
                    this.chkRango.Checked = true;
                    this.chkDuplicados.Checked = true;
                    VistaTabla.MostrarResultado((SorteoAImprimir as Haccp).Resultado, ResultadoOrdenado, this.dataGridNumeros);
                    break;
                case EnumSorteo.GENERICA:
                    this.txtTipoSorteo.Text = EnumSorteo.GENERICA.ToString();
                    this.txtRango.Text = (SorteoAImprimir as Generica).Rango.ToString();
                    this.txtRango.Visible = true;
                    this.txtTotalSorteo.Visible = false;
                    this.lblTotalASortear.Visible = false;
                    this.chkRango.Checked = true;
                    this.chkDuplicados.Checked = false;
                    VistaTabla.MostrarResultado((SorteoAImprimir as Generica).Resultado, ResultadoOrdenado, this.dataGridNumeros);
                    break;
                case EnumSorteo.CLORACION:
                    this.txtTipoSorteo.Text = EnumSorteo.CLORACION.ToString();

                    break;
                case EnumSorteo.UE:
                    this.txtTipoSorteo.Text = EnumSorteo.UE.ToString();

                    break;
                case EnumSorteo.LADO:
                    this.txtTipoSorteo.Text = EnumSorteo.LADO.ToString();

                    break;
                case EnumSorteo.PERSONALIZADO:
                    this.txtTipoSorteo.Text = EnumSorteo.PERSONALIZADO.ToString();
                    this.txtTotalSorteo.Text = (SorteoAImprimir as Personalizado).Cantidad.ToString();
                    if((SorteoAImprimir as Personalizado).Rango != 0) {
                        this.chkRango.Checked = true;
                        this.txtRango.Visible = true;
                        this.txtRango.Text = (SorteoAImprimir as Personalizado).Rango.ToString();                        
                    }
                    if(!(SorteoAImprimir as Personalizado).ResultadoVerificacion.IsEmpty()) {
                        VistaTabla.MostrarResultado((SorteoAImprimir as Personalizado).ResultadoVerificacion, ResultadoOrdenado, this.dataGridVerificacion);
                    }
                    this.chkDuplicados.Checked = (SorteoAImprimir as Personalizado).PermitirDuplicados;
                    VistaTabla.MostrarResultado((SorteoAImprimir as Personalizado).Resultado, ResultadoOrdenado, this.dataGridNumeros);
                    break;
                default:
                    break;
            }
        }

        private void PrintForm_Shown(object sender, EventArgs e) {
            CargarDatosSorteo();
        }
    }
}
