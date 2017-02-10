using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RND.Clases {
    class Sorteo {
        public DateTime Fecha { get; set; }
        public int Inicio { get; set; }
        public int Tope { get; set; }
        public int Cantidad { get; set; }
        public HashSet<int> Resultado { get; set; }
        public HashSet<string> Opciones { get; set; }

        // constructores
        public Sorteo() { }
        public Sorteo(DateTime Fecha, int Inicio, int Tope, int Cantidad) {
            this.Fecha = Fecha;
            this.Inicio = Inicio;
            this.Tope = Tope;
            this.Cantidad = Cantidad;
            this.Resultado = new HashSet<int>();
            this.Opciones = new HashSet<string>();
        }
        

    }
}
