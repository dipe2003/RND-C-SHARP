﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RND.Clases {
    class Personalizado : Sorteo {
        public double Rango { get; set; }
        public int Cantidad { get; set; }
        public int CantidadVerificacion { get; set; }
        public List<int> ResultadoVerificacion { get; }

        public bool UsarRango { get; set; }

        // constructores
        public Personalizado() {
            this.ResultadoVerificacion = new List<int>();
        }

        // metodos
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

        private int CalcularFrecuencia() {
            return (int)(Math.Round(Tope / (double)Cantidad, 0, MidpointRounding.AwayFromZero));
        }
        override
            public void SortearNumeros() {
            if(UsarRango) {
                if(Rango != 0) {
                    if(Cantidad == 0) {
                        Cantidad = CalcularCantidad();
                    }
                }else {
                    Rango = CalcularFrecuencia();
                }                
                int inicio;
                for(int i = 1; i <= Cantidad; i++) {
                    inicio = (i - 1) * (int)Rango + 1;
                    if(Tope < i * (int)Rango) {
                        Resultado.Add(sortearNumero(inicio, Tope));
                    } else {
                        Resultado.Add(sortearNumero(inicio, (i * (int)Rango)));
                    }
                }
            } else {
                if(PermitirDuplicados) {
                    for(int i = 0; i < Cantidad; i++) {
                        int numero = sortearNumero(Inicio, Tope);
                        Resultado.Add(numero);
                    }
                } else {
                    for(int i = 0; i < Cantidad; i++) {
                        int numero;
                        do {
                            numero = sortearNumero(Inicio, Tope);
                        } while(Resultado.Contains(numero));
                        Resultado.Add(numero);
                    }
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