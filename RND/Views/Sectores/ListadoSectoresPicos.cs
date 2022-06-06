using PicosSectores.Clases;
using PicosSectores.Controladores;
using RND.Views.Picos;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RND.Views.Sectores {
    public partial class ListadoSectoresPicos : Form, IActualizable {
        ControladorSectores cSectores = new ControladorSectores();
        List<Sector> sectores;
        IActualizable FormularioPadreActualizable;

        public ListadoSectoresPicos(IActualizable formularioPadreActualizable) {
            InitializeComponent();
            ActualizarContenido();
            FormularioPadreActualizable = formularioPadreActualizable;
        }

        private void buttonNuevoSector_Click(object sender, System.EventArgs e) {
            new NuevoSector(this).ShowDialog();
        }

        private void LlenarTabla() {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Sector", typeof(string));
            tabla.Columns.Add("Numero Pico", typeof(int));
            tabla.Columns.Add("Nombre de Pico", typeof(string));

            foreach (Sector sector in sectores) {
                DataRow fila;

                if (sector.Picos.Count == 0) {
                    fila = tabla.NewRow();
                    fila["Id"] = sector.Id;
                    fila["Sector"] = sector.Nombre;
                    tabla.Rows.Add(fila);
                }

                foreach (Pico pico in sector.Picos) {
                    fila = tabla.NewRow();
                    fila["Id"] = sector.Id;
                    fila["Sector"] = sector.Nombre;
                    fila["Numero Pico"] = pico.Id;
                    fila["Nombre de Pico"] = pico.Nombre;
                    tabla.Rows.Add(fila);
                }
            }
            dataGridViewListadoPicosSectores.DataSource = tabla;
            dataGridViewListadoPicosSectores.ReadOnly = true;
            dataGridViewListadoPicosSectores.ShowEditingIcon = false;
            dataGridViewListadoPicosSectores.RowHeadersVisible = false;
        }

        private void buttonNuevoPico_Click(object sender, System.EventArgs e) {
            new NuevoPico(this).ShowDialog();
        }

        private void buttonCerrar_Click(object sender, System.EventArgs e) {
            FormularioPadreActualizable.ActualizarContenido();
            this.Close();
        }

        private void buttonEditarSector_Click(object sender, System.EventArgs e) {
            int id = -1;
            if (dataGridViewListadoPicosSectores.SelectedRows.Count >= 0) {
                int.TryParse(dataGridViewListadoPicosSectores.SelectedCells[0].Value.ToString(), out id);

                if (id >= 0) {
                    Form form = new EditarSector(id, this);
                    form.ShowDialog();
                } else {
                    MessageBox.Show("No hay sector seleccionado.");
                }
            } else {
                MessageBox.Show("No hay sector seleccionado.");
            }
        }

        private void buttonEditarPico_Click(object sender, System.EventArgs e) {
            int id = -1;
            if (dataGridViewListadoPicosSectores.SelectedRows.Count >= 0) {
                int.TryParse(dataGridViewListadoPicosSectores.SelectedCells[2].Value.ToString(), out id);

                if (id >= 0) {
                    Form form = new EditarPico(id, this);
                    form.ShowDialog();
                } else {
                    MessageBox.Show("No hay pico seleccionado.");
                }
            } else {
                MessageBox.Show("No hay pico seleccionado.");
            }
        }

        public void ActualizarContenido() {
            sectores = cSectores.ListarSectores(true);
            LlenarTabla();
            dataGridViewListadoPicosSectores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
