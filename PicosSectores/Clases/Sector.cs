using System;
using System.Collections.Generic;
using System.Linq;

namespace PicosSectores.Clases {

    public class Sector : IElementoBasico {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual List<Pico> Picos { get; set; }

        public Sector() {
            this.Picos = new List<Pico>();
        }

        public Sector(string nombreSector) {
            this.Nombre = nombreSector;
            this.Picos = new List<Pico>();
        }

        public void AddPico(Pico pico) {
            this.Picos.Add(pico);
        }

        public Pico CrearPico(int id, string nombre) {
            Pico pico = new Pico {
                Id = id,
                Nombre = nombre
            };
            this.Picos.Add(pico);
            return pico;
        }

        public Pico FindPico(int id) {
            return Picos.Find(pico => pico.Id == id);
        }

        public Pico EditarPico(int id, string nombre) {
            Pico pico = FindPico(id);
            pico.Nombre = nombre;
            return pico;
        }

        public bool ExistePico(int id) => Picos.Any(p => p.Id == id);
    }
}