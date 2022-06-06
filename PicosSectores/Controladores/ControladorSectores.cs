using PicosSectores.Clases;
using PicosSectores.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PicosSectores.Controladores {
    public class ControladorSectores {

        public Sector CrearSector(string nombre) {
            Sector sector = new Sector {
                Nombre = nombre
            };
            try {
                using (var db = new ModeloBDPicos()) {
                    sector = db.Sectores.Add(sector);
                    db.SaveChanges();
                }
            } catch (Exception ex)  { }
            return sector;
        }

        public int EditarSector(int id, string nuevoNombre) {
            try {
                using (var db = new ModeloBDPicos()) {
                    Sector sector = db.Sectores.Find(id);
                    sector.Nombre = nuevoNombre;
                    return db.SaveChanges();
                }
            } catch (Exception) { }
            return 0;
        }

        public int EliminarSector(int id) {
            try {
                using (var db = new ModeloBDPicos()) {
                    db.Sectores.Remove(db.Sectores.Find(id));
                    return db.SaveChanges();
                }
            } catch (Exception) { }
            return 0;
        }

        public Sector ObtenerSector(int id) {
            try {
                using(var db = new ModeloBDPicos()) {
                    Sector sector = db.Sectores
                        .Include("Picos")
                        .Where((Sector s) => s.Id == id)
                        .FirstOrDefault(null);
                }
            } catch (Exception) { }
            return null;
        }

        public List<Sector> ListarSectores(bool incluirPicos = false) {
            try {
                using(var db = new ModeloBDPicos()) {
                    if (incluirPicos) {
                        return db.Sectores
                            .Include("Picos")
                            .ToList();
                    }
                    return db.Sectores.ToList();
                }
            } catch (Exception) { }
            return new List<Sector>();
        }


    }
}
