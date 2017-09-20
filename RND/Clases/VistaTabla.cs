using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RND.Clases {
    static class VistaTabla {
        /// <summary>
        /// Llena el datagridview con los strings del sorteo.
        /// </summary>
        /// <param name="itemsSorteados"></param>
        /// <param name="nombrePrimerColumna"></param>
        /// <param name="nombreSegundaColumna"></param>
        /// <param name="dataGridView"></param>
        public static void LlenarTabla(List<string> itemsSorteados, string nombrePrimerColumna, 
                                        string nombreSegundaColumna, DataGridView dataGridView) {
            DataTable tabla = new DataTable();
            tabla.Columns.Add(nombrePrimerColumna, typeof(int));
            tabla.Columns.Add(nombreSegundaColumna, typeof(string));
            foreach(string fecha in itemsSorteados) {
                DataRow fila = tabla.NewRow();
                fila[nombrePrimerColumna] = itemsSorteados.IndexOf(fecha) + 1;
                fila[nombreSegundaColumna] = fecha;
                tabla.Rows.Add(fila);
            }
            dataGridView.DataSource = tabla;
            dataGridView.ReadOnly = true;
            dataGridView.ShowEditingIcon = false;
            dataGridView.RowHeadersVisible = false;
        }
    }
}
