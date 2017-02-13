using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RND.Clases {
    class Haccp : Sorteo {
        public double Rango { get; internal set; }
        public int CantidadVerificacion { get; set; }
        public int Cantidad { get; set; }
        public List<int> ResultadoVerificacion { get; }

        // constructores
        public Haccp() {
            this.ResultadoVerificacion = new List<int>();
        }

        // metodos
        private int CalcularFrecuencia() {
            return (int)(Math.Round(Tope / (double)Cantidad, 0, MidpointRounding.AwayFromZero));
        }

        override
            public void SortearNumeros() {
            Rango = CalcularFrecuencia();
            int inicio;
            for(int i = 1; i <= Cantidad; i++) {
                inicio = (i - 1) * (int)Rango + 1;
                if(Tope < i * (int)Rango) {
                    Resultado.Add(sortearNumero(inicio, Tope));
                } else {
                    Resultado.Add(sortearNumero(inicio, (i * (int)Rango)));
                }
            }
        }

        /// <summary>
        /// Genera numeros aleatorios desde una lista de enteros.
        /// </summary>
        public void SortearNumerosVerificacion() {
            int numeroSorteo;
            int numeroVerif;
            for(int i = 0; i < Resultado.Count; i++) {
                do {
                    numeroVerif = sortearNumero(0, Resultado.Count);
                    numeroSorteo = Resultado.ElementAt(numeroVerif);
                } while(ResultadoVerificacion.Contains(numeroSorteo));
            }
        }
    }
}
