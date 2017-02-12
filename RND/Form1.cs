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

        private static double rangoGenerica = 300;

        private int inicio;
        private int tope;
        private int cantidad;

        private bool ordenado = false;
        private bool duplicado = false;

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void radioGenerica_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "1";
            this.txtCantidad.Text = "1";

            this.txtInicio.Enabled = false;
            this.txtCantidad.Enabled = false;

            this.txtTope.Enabled = true;
            this.txtResultado.Text = "";

            this.chkDuplicados.Enabled = false;
            this.chkOrdenados.Enabled = false;
            this.chkOrdenados.Checked = true;
        }

        private void radioPersonalizado_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "";
            this.txtCantidad.Text = "";
            this.txtTope.Text = "";
            this.txtResultado.Text = "";
            this.txtInicio.Enabled = true;
            this.txtInicio.Enabled = true;
            this.txtCantidad.Enabled = true;
            this.txtTope.Enabled = true;
            this.chkDuplicados.Enabled = true;
            this.chkOrdenados.Enabled = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e) {
            if(!ComprobarDatosIngresados()) {
                MessageBox.Show("Error: Faltan datos o no son correctos.");
            } else {
                List<int> sorteo = new List<int>();
                // si no se selecciono sorteo de generica
                if(!radioGenerica.Checked) {
                    sorteo = SortearNumero(inicio, tope, cantidad, duplicado);
                } else {
                    if(radioGenerica.Checked) {
                        /*
                         * cociente = tope / rango
                         * la parte entera del cociente es el primer numero de la cantidad
                         * la parte decimal si > 0 se suma a cantidad
                         */
                        double cociente;
                        cociente = tope / rangoGenerica;
                        cantidad = (int)cociente;
                        double resto = (cociente - (int)cociente);
                        if(resto > 0) cantidad++;
                        this.txtCantidad.Text = cantidad.ToString();
                    }
                    // sortear por intervalo 1-300 / 301 - 600 / 601 - xxx
                    for(int i = 1; i <= cantidad; i++) {
                        inicio = (i - 1) * (int)rangoGenerica + 1;
                        if(tope < i * (int)rangoGenerica) {
                            sorteo.AddRange(SortearNumero(inicio, tope, 1, false));
                        } else {
                            sorteo.AddRange(SortearNumero(inicio, (i * (int)rangoGenerica), 1, false));
                        }
                    }
                }
                MostrarResultado(sorteo, ordenado);
            }
        }


        private List<int> SortearNumero(int min, int max, int Cantidad, bool duplicado) {
            Random aleatorio = new Random();
            List<int> sorteo = new List<int>();
            if(!duplicado) {
                for(int i = 0; i < Cantidad; i++) {
                    int numero;
                    do {
                        numero = aleatorio.Next((max - min + 1)) + min;
                    } while(sorteo.Contains(numero));
                    sorteo.Add(numero);
                }
            } else {
                for(int i = 0; i < Cantidad; i++) {
                    int numero = aleatorio.Next((max - min + 1)) + min;
                    sorteo.Add(numero);
                }
            }
            return sorteo;
        }

        private void MostrarResultado(List<int> Resultado, bool ordenados) {
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

            this.txtResultado.Text = resultado;
        }

        private void radioCloracion_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "0";
            this.txtCantidad.Text = "6";
            this.txtCantidad.Enabled = true;
            this.txtResultado.Text = "";
            this.txtInicio.Enabled = false;
        }

        private void radioUE_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "1";
            this.txtCantidad.Text = "";
            this.txtTope.Text = "";
            this.txtResultado.Text = "";
            this.txtInicio.Enabled = false;
            this.txtCantidad.Enabled = true;
            this.txtTope.Enabled = true;
            this.chkDuplicados.Enabled = false;
            this.duplicado = false;
        }

        private void radioLado_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "1";
            this.txtCantidad.Text = "1";
            this.txtTope.Text = "2";
            this.txtResultado.Text = "";
            this.duplicado = false;
            this.ordenado = false;

            this.txtCantidad.Enabled = false;
            this.txtInicio.Enabled = false;
            this.txtTope.Enabled = false;
            this.chkDuplicados.Enabled = false;
            this.chkOrdenados.Enabled = false;
        }

        private void radioMes_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "1";
            this.txtTope.Text = "12";
            this.txtResultado.Text = "";

            this.txtInicio.Enabled = false;
            this.txtCantidad.Enabled = true;
            this.txtTope.Enabled = false;
            this.chkDuplicados.Enabled = true;
            this.chkOrdenados.Enabled = true;
        }

        private void radioDiaSemana_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "1";
            this.txtTope.Text = "7";
            this.txtResultado.Text = "";

            this.txtInicio.Enabled = false;
            this.txtCantidad.Enabled = true;
            this.txtTope.Enabled = false;
            this.chkDuplicados.Enabled = true;
            this.chkOrdenados.Enabled = true;
        }

        private bool ComprobarDatosIngresados() {
            if(this.txtCantidad.Text.Length == 0 || this.txtInicio.Text.Length == 0 ||
                    this.txtTope.Text.Length == 0) {
                return false;
            } else {
                try {
                    inicio = int.Parse(this.txtInicio.Text);
                    tope = int.Parse(this.txtTope.Text);
                    cantidad = int.Parse(this.txtCantidad.Text);
                    if(inicio < 0 || tope < 0 || tope < inicio || cantidad < 0 || inicio == tope) {
                        return false;
                    }
                } catch(FormatException ex) {
                    System.Console.WriteLine("Error: " + ex.Message);
                    return false;
                } catch(NullReferenceException ex) {
                    System.Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
                return true;
            }
        }

        private void chkDuplicados_CheckedChanged(object sender, EventArgs e) {
            if(duplicado) {
                duplicado = false;
            } else {
                duplicado = true;
            }
        }

        private void chkOrdenados_CheckedChanged(object sender, EventArgs e) {
            if(ordenado) {
                ordenado = false;
            } else {
                ordenado = true;
            }
        }
    }

}
