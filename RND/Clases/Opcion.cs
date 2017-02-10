using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RND.Clases {
    class Opcion {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // constructores
        public Opcion() { }
        public Opcion(string Nombre, string Descripcion) {
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
        }

        override
        public string ToString() {
            return this.Descripcion;
        }
    }
}
