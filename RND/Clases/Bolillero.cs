using System;
using System.Collections.Generic;

namespace RND.Clases {
    class Bolillero : Sorteo {
        public int Cantidad { get; set; }
        public List<int> ContenidoBolillero { get; set; }
        public bool PermitirDuplicados { get; set; }

        public void AddContenidoBolillero(int elemento) {
            this.ContenidoBolillero.Add(elemento);
        }

        public Bolillero() {
            this.ContenidoBolillero = new List<int>();
        }

        override
            public void SortearNumeros() {
            
            if (Tope < 0 || Tope < Cantidad || Tope < Inicio || Inicio < 0 || Cantidad < 0) {
                throw new ArgumentException("Existen errores en los parametros del sorteo.");
            }
            Tope--;
            if (PermitirDuplicados) {
                for (int i = 0; i < Cantidad; i++) {
                    int numero = sortearNumero(Inicio, Tope);
                    Resultado.Add(ContenidoBolillero[numero]);
                }
            } else {
                for (int i = 0; i < Cantidad; i++) {
                    int numero;
                    do {
                        numero = sortearNumero(Inicio, Tope);
                    } while (Resultado.Contains(ContenidoBolillero[numero]));
                    Resultado.Add(ContenidoBolillero[numero]);
                }
            }

        }
    }
}
