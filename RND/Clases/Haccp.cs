using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RND.Clases {
    class Haccp:Sorteo {
        public double Rango { get; internal set; }
        public int CantidadVerificacion { get; set; }
        public int Cantidad { get; set; }
        public List<int> ResultadoVerificacion { get; }

        private double restoRango;

        // constructores
        public Haccp() {
            this.ResultadoVerificacion = new List<int>();
        }

        // metodos
        private int CalcularFrecuencia() {
            double tmpRango = Tope / (double)Cantidad;
            restoRango = tmpRango - (int)tmpRango;
            return (int) tmpRango;
        }

        override
            public void SortearNumeros() {
            if(Tope < 0 || Tope < Cantidad || Tope < Inicio || Inicio < 0 || Cantidad < 0 || Cantidad > Tope) {
                throw new ArgumentException("Existen errores en los parametros del sorteo.");
            }
            Rango = CalcularFrecuencia();
            int inicio;
            int rangoAnterior = 0;
            // el restoRango (la parte decimal del calculo de la frecuencia) se multiplica por Cantidad para calcular cuantos numeros de menos quedan para cubrir el tope.
            int sumaRango = (int) (restoRango * Cantidad);
            for(int i = 1; i <= Cantidad; i++) {
                //inicio = (i - 1) * (int)Rango + 1;
                inicio = rangoAnterior+1;
                
                //int topeRango = i * (int)Rango;
                int topeRango = i == 2 ? rangoAnterior + (int)Rango + 1 : rangoAnterior + (int)Rango;

                // mientras la iteracion sea menor que sumaRango se suma 1 al tope de rango                
                if (i <= sumaRango) {
                    topeRango++;
                }

                if (Tope > topeRango) {
                    Resultado.Add(sortearNumero(inicio, topeRango));
                } else {
                    Resultado.Add(sortearNumero(inicio, Tope));
                }
                rangoAnterior = topeRango;
            }
        }

        /// <summary>
        /// Genera numeros aleatorios desde una lista de enteros.
        /// </summary>
        public void SortearNumerosVerificacion() {
            if(CantidadVerificacion > Cantidad || CantidadVerificacion > Tope) {
                throw new ArgumentException("Existen errores en los parametros del sorteo.");
            }
            int numeroSorteo;
            int numeroVerif;
            for(int i = 0; i < CantidadVerificacion; i++) {
                do {
                    numeroVerif = sortearNumero(0, Resultado.Count-1);
                    numeroSorteo = Resultado.ElementAt(numeroVerif);
                } while(ResultadoVerificacion.Contains(numeroSorteo));
                ResultadoVerificacion.Add(numeroSorteo);
            }
        }
    }
}
