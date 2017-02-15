using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RND.Clases {
    class Generica : Sorteo {
        private int cantidad;
        public int Cantidad {
            get;
        }
        private double rango;
        public double Rango {
            get { return rango; }
            set {
                rango = value;
                cantidad = CalcularCantidad();
            }
        }

        // constructores
        public Generica() { }
        public Generica(double rango) {
            this.Rango = rango;
        }

        /// <summary>
        /// Calcula la cantidad de numeros a generar.
        /// cociente = tope / rango
        /// la parte entera del cociente es el primer numero de la cantidad
        /// la parte decimal si > 0 se suma a cantida
        /// </summary>
        /// <returns></returns>
        private int CalcularCantidad() {
            // cociente = tope / rango
            // la parte entera del cociente es el primer numero de la cantidad
            // la parte decimal si > 0 se suma a cantida
            int cantidad;
            double cociente;
            cociente = Tope / Rango;
            cantidad = (int)cociente;
            double resto = (cociente - (int)cociente);
            if(resto > 0) cantidad++;
            return cantidad;
        }

        override
            public void SortearNumeros() {
            if(Tope < 0 || Tope < cantidad || Tope < Inicio || Inicio < 0 || cantidad < 0 || cantidad > Tope || Rango <0 ) {
                throw new ArgumentException("Existen errores en los parametros del sorteo.");
            }
            int inicio;
            for(int i = 1; i <= cantidad; i++) {
                inicio = (i - 1) * (int)Rango + 1;
                int topeRango = i * (int)Rango;
                if(Tope > topeRango) {
                    Resultado.Add(sortearNumero(inicio, topeRango));
                } else {
                    Resultado.Add(sortearNumero(inicio, Tope));
                }
            }
        }
    }

}
