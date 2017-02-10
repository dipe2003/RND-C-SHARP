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
                    if(!duplicado) {
                        for(int i = 0; i < cantidad; i++) {
                            int numero;
                            do {
                                numero = SortearNumero(inicio, tope);
                            } while(sorteo.Contains(numero));
                            sorteo.Add(numero);
                        }
                    } else {
                        sorteo = SortearNumero(inicio, tope, cantidad);
                    }
                } else {
                    if(radioGenerica.Checked) {
                        if(tope / 300 > 1 && (tope / 300 / (int)tope / 300) > 0) {
                            cantidad = (int)tope / 300 + tope % 300;
                        } else {
                            if(tope / 300 < 1) {
                                cantidad = 1;
                            } else {
                                if(tope / 300 >= 1 && tope % 300 == 0) {
                                    cantidad = (int)tope / 300;
                                } else {
                                    cantidad = (int)tope / 300 + 1;
                                }
                            }
                        }
                        this.txtCantidad.Text = cantidad.ToString();
                    }
                    for(int i = 0; i < cantidad; i++) {
                        int numero;
                        do {
                            numero = SortearNumero(inicio, tope);
                        } while(sorteo.Contains(numero));
                        sorteo.Add(numero);
                    }
                }
                MostrarResultado(sorteo);
            }
        }


        private List<int> SortearNumero(int min, int max, int Cantidad) {
            Random aleatorio = new Random();
            List<int> sorteo = new List<int> ();
            for(int i = 0; i < cantidad; i++) {
                int numero = aleatorio.Next((max - min + 1)) + min;
                sorteo.Add(numero);
            }
            return sorteo;
        }

        private int SortearNumero(int min, int max) {
            Random aleatorio = new Random();
            return aleatorio.Next((max - min + 1)) + min;
        }

        private void MostrarResultado(List<int> Resultado) {
            string resultado = "";
            for(int i = 0; i < Resultado.Count; i++) {
                resultado = resultado + Resultado.ElementAt(i).ToString();
                int sig = i + 1;
                if(sig >= Resultado.Count) {
                    resultado = resultado + ".";
                } else {
                    resultado = resultado + ", ";
                }
            }
            this.txtResultado.Text = resultado;
        }

        private void radioCloracion_CheckedChanged(object sender, EventArgs e) {
            this.txtInicio.Text = "0";
            this.txtCantidad.Text = "12";
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
            }else {
                duplicado = true;
            }
        }
    }
    
    }
