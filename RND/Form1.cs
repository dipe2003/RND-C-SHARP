using RND.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RND {
    public partial class Inicio : Form {
        public Inicio() {
            InitializeComponent();
        }

        /*
         * Propiedades / Variables
         */


        /*
         * Botones
         */
        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e) {

        }


        /// <summary>
        /// Genera una string de los numeros indicados y los muestra en al cuadro de texto.
        /// </summary>
        /// <param name="Resultado"></param>
        /// <param name="ordenados"></param>
        /// <param name="contenedor"></param>
        private void MostrarResultado(List<int> Resultado, bool ordenados, TextBox contenedor) {
            string resultado = "";
            int[] arr = new int[Resultado.Count];
            arr = Resultado.ToArray();
            if(ordenados) {
                int pos;
                int num;
                for(int i = 0; i < arr.Length; i++) {
                    num = arr[i];
                    pos = i;

                    while(pos > 0 && arr[pos - 1] > num) {
                        arr[pos] = arr[pos - 1];
                        pos = pos - 1;
                    }
                    arr[pos] = num;
                }
            }
            for(int i = 0; i < arr.Length; i++) {
                resultado = resultado + arr[i].ToString();
                int sig = i + 1;
                if(sig >= arr.Length) {
                    resultado = resultado + ".";
                } else {
                    resultado = resultado + ", ";
                }
            }

            contenedor.Text = resultado;
        }
    }
}
