using PicosSectores.Clases;
using PicosSectores.Controladores;
using RND.Clases;
using RND.Clases.PdfText;
using RND.Views.Sectores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RND.Views.Sorteos {
    public partial class SorteoPicos : Form, IActualizable {
        /*
         * Propiedades / Variables
         */
        private bool PermitirDuplicados = false;
        private bool OrdenarResultado = false;
        private bool AnularSeleccion = false;

        private int Inicio;
        private int Tope;
        private int Cantidad;
        private List<int> IdSectoresSeleccionados;

        private Bolillero SorteoGenerico;

        private DateTime FechaSorteo = new DateTime();

        ControladorSectores cSectores = new ControladorSectores();
        ControladorPicos cPicos = new ControladorPicos();
        List<Sector> sectores;
        List<Pico> picos;

        public SorteoPicos() {
            InitializeComponent();
            ActualizarContenido();
        }

        
        /*
         * Botones
         */
        private void BtnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Genera el sorteo con los parametros seleccionados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerar_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            // obtener los parametros numericos y continuar si son correctos.
            FechaSorteo = dateTimePickerFechaSorteo.Value;
            if (ObtenerParametrosNumericos()) {
                // vaciar los cuadros de resultados
                if (!ComprobarLimiteSorteo(Cantidad, Inicio, Tope)) {
                    MessageBox.Show("No se pueden sortear " + Cantidad.ToString() + " numeros en el rango seleccionado.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    try {
                        ObtenerParametrosDeSectores();
                        SorteoGenerico = new Bolillero() {
                            PermitirDuplicados = PermitirDuplicados
                        };

                        if (IdSectoresSeleccionados.Count > 0) {
                            SorteoGenerico.Cantidad = IdSectoresSeleccionados.Count;
                           
                            picos.Where(p => IdSectoresSeleccionados.Contains(p.Sector.Id))
                                 .ToList<Pico>().ForEach(p => {
                                     SorteoGenerico.ContenidoBolillero.Add(p.Id);
                                 });
                            SorteoGenerico.Tope = SorteoGenerico.ContenidoBolillero.Count;
                            SorteoGenerico.SortearNumeros();
                            // quitar la cantidad de numero ya sorteados de la cantidad total seleccionada
                            Cantidad -= IdSectoresSeleccionados.Count;
                        }
                        if (Cantidad >SorteoGenerico.Resultado.Count) {
                            SorteoGenerico.ContenidoBolillero.Clear();
                            SorteoGenerico.Cantidad = Cantidad;
                            picos.ForEach(p => {
                                SorteoGenerico.ContenidoBolillero.Add(p.Id);
                            });
                            SorteoGenerico.Tope = SorteoGenerico.ContenidoBolillero.Count;
                            SorteoGenerico.SortearNumeros();
                        }
                        if (OrdenarResultado)
                            SorteoGenerico.Resultado.Sort();
                        LlenarTabla(ExtraerPicosSorteados(SorteoGenerico.Resultado));
                    } catch (Exception ex) {
                        MostrarMensajeError(ex);
                    } finally {
                        this.Cursor = Cursors.Default;
                    }
                }
            }
            this.Cursor = Cursors.Default;
        }

        #region Opciones de Sorteo
        // habilita opciones adicionales para los sorteos


        private void ChkDuplicados_CheckedChanged(object sender, EventArgs e) {
            PermitirDuplicados = (sender as CheckBox).Checked;
        }

        private void ChkOrdenados_CheckedChanged(object sender, EventArgs e) {
            OrdenarResultado = (sender as CheckBox).Checked;
        }

        private void checkBoxAnularSeleccion_CheckedChanged(object sender, EventArgs e) {
            AnularSeleccion = (sender as CheckBox).Checked;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Comprueba que el rango de fecha sea suficiente para el total a sortear.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaTope"></param>
        /// <returns></returns>
        private bool ComprobarLimiteSorteo(int cantidad, int numeroInicio, int numeroTope) {
            int diferencia = numeroTope - numeroInicio;
            if (cantidad > diferencia) {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Parsea los valores string ingresados al valor numerico correspondiente.
        /// Muestra cuadro de mensaje ante error.
        /// <return>True: si los valores son correctos, False de lo contrario.</return>
        /// </summary>
        private bool ObtenerParametrosNumericos() {
            try {
                Inicio = 0;
                Tope = picos.Count;
                Cantidad = int.Parse(this.txtCantidad.Text);
            } catch (FormatException ex) {
                MostrarMensajeError(ex);
                return false;
            } catch (NullReferenceException ex) {
                MostrarMensajeError(ex);
                return false;
            } catch (Exception ex) {
                MostrarMensajeError(ex);
                return false;
            }
            return true;
        }

        private void ObtenerParametrosDeSectores() {
            // vaciar lista para segundo sorteo sin cerrar menu
            IdSectoresSeleccionados.Clear();
            if (AnularSeleccion == false && dataGridSectores.SelectedRows.Count > 0) {
                foreach (DataGridViewRow item in dataGridSectores.SelectedRows) {
                    IdSectoresSeleccionados.Add(int.Parse(item.Cells[0].Value.ToString()));
                }                
            }
        }

        /// <summary>
        /// Muestra un mesaje de error por valores no correctos.
        /// </summary>
        /// <param name="ex"></param>
        private void MostrarMensajeError(Exception ex) {
            MessageBox.Show("Faltan datos o los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Console.WriteLine("Error: " + ex.Message);
        }

        private List<Pico> ExtraerPicosSorteados(List<int> listadoIds) {
            List<Pico> lista = new List<Pico>();
            foreach (int id in listadoIds) {
                lista.Add(picos.Find(p => p.Id == id));
            }
            return lista;
        }

        private void LlenarTabla(List<Pico> picos) {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Sector", typeof(string));
            tabla.Columns.Add("Numero Pico", typeof(int));
            tabla.Columns.Add("Nombre de Pico", typeof(string));

            DataRow fila;
            foreach (Pico pico in picos) {
                fila = tabla.NewRow();
                fila["Sector"] = pico.Sector.Nombre;
                fila["Numero Pico"] = pico.Id;
                fila["Nombre de Pico"] = pico.Nombre;
                tabla.Rows.Add(fila);
            }

            dataGridPicosSorteados.DataSource = tabla;
            dataGridPicosSorteados.ReadOnly = true;
            dataGridPicosSorteados.ShowEditingIcon = false;
            dataGridPicosSorteados.RowHeadersVisible = false;
        }

        #endregion

        private void ButtonGuardarPDF_Click(object sender, EventArgs e) {
            if (SorteoGenerico != null && SorteoGenerico.Resultado.Any()) {
                SaveFileDialog dialogoDestino = new SaveFileDialog();
                dialogoDestino.Filter = "Archivo PDF (Portable Document Format)|*.pdf";
                StringBuilder strNombre = new StringBuilder();
                strNombre.Append("Sorteo Picos de Agua")
                .Append(" ")
                .Append(FechaSorteo.ToShortDateString().Replace('/', '.'));
                dialogoDestino.FileName = strNombre.ToString();
                DialogResult resultado = dialogoDestino.ShowDialog();

                if (resultado == DialogResult.OK) {
                    this.Cursor = Cursors.WaitCursor;
                    string destino = dialogoDestino.FileName;
                    
                    ControladorPDF pdf = new ControladorPDF();
                    pdf.GuardarSorteoPicos(destino, "Sorteo Picos de Agua", FechaSorteo.ToShortDateString(),
                        SorteoGenerico.Inicio.ToString(), SorteoGenerico.Tope.ToString(), ExtraerPicosSorteados(SorteoGenerico.Resultado));
                }
            } else {
                System.Windows.Forms.MessageBox.Show("No se ha realizado ningún sorteo.", "?", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
            this.Cursor = Cursors.Default;
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e) {
            Form nuevo = new ListadoSectoresPicos(this);
            nuevo.ShowDialog();
        }

        public void ActualizarContenido() {
            FechaSorteo = DateTime.Today;
            IdSectoresSeleccionados = new List<int>();
            sectores = cSectores.ListarSectores();
            picos = cPicos.ListarPicos(true);
            VistaTabla.LlenarTabla(sectores.ToList<IElementoBasico>(), "Id", "Nombre", dataGridSectores);
        }
    }
}
