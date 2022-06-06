using PicosSectores.Clases;
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
            foreach(string item in itemsSorteados) {
                DataRow fila = tabla.NewRow();
                fila[nombrePrimerColumna] = itemsSorteados.IndexOf(item) + 1;
                fila[nombreSegundaColumna] = item;
                tabla.Rows.Add(fila);
            }
            dataGridView.DataSource = tabla;
            dataGridView.ReadOnly = true;
            dataGridView.ShowEditingIcon = false;
            dataGridView.RowHeadersVisible = false;
        }

        /// <summary>
        /// Genera una string de los numeros indicados y los muestra en al cuadro de texto.
        /// </summary>
        /// <param name="Resultado"></param>
        /// <param name="ordenados"></param>
        /// <param name="contenedor"></param>
        public static void MostrarResultado(List<int> Resultado, bool ordenados, DataGridView tabla) {
            if(ordenados) {
                Resultado.Sort();
            }
            List<string> lista = new List<string>();
            foreach(int numero in Resultado) {
                lista.Add(numero.ToString());
            }
            VistaTabla.LlenarTabla(lista, "#", "Numero", tabla);
        }

        /// <summary>
        /// Metodo de extension de List<int>() para comprobar lista vacia.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool IsEmpty(this List<int> lista) {
            if(lista.Count == 0) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Llena el datagridview con los IElementosBasicos
        /// </summary>
        /// <param name="elementosBasicos"></param>
        /// <param name="nombrePrimerColumna"></param>
        /// <param name="nombreSegundaColumna"></param>
        /// <param name="dataGridView"></param>
        public static void LlenarTabla(List<IElementoBasico> elementosBasicos, string nombrePrimerColumna,
                                        string nombreSegundaColumna, DataGridView dataGridView, bool primerColumnaVisible = false) {
            DataTable tabla = new DataTable();
            tabla.Columns.Add(nombrePrimerColumna, typeof(int));            
            tabla.Columns.Add(nombreSegundaColumna, typeof(string));
            foreach (IElementoBasico item in elementosBasicos) {
                DataRow fila = tabla.NewRow();
                fila[nombrePrimerColumna] = item.Id;
                fila[nombreSegundaColumna] = item.Nombre;
                tabla.Rows.Add(fila);
            }
            
            dataGridView.DataSource = tabla;
            dataGridView.ReadOnly = true;
            dataGridView.ShowEditingIcon = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Columns[0].Visible = primerColumnaVisible;
        }
    }
}
