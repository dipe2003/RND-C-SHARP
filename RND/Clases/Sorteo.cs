using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RND.Clases {
    abstract class Sorteo {

        protected static Random Aleatorio = new Random();

        public  DateTime Fecha { get; set; }
        public int Inicio { get; set; }
        public int Tope { get; set; }       

        public bool PermitirDuplicados { get; set; }

        public List<int> Resultado { get; set; }

        // constructores
        public Sorteo() { }
        public Sorteo(DateTime Fecha, int Inicio, int Tope) {
            this.Fecha = Fecha;
            this.Inicio = Inicio;
            this.Tope = Tope;
            this.Resultado = new List<int>();
        }

        // metodos
        public abstract void SortearNumeros();

        protected int sortearNumero(int min, int max) {
            return Aleatorio.Next((max - min + 1)) + max;
        }


    }
}
