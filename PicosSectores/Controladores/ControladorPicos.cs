using PicosSectores.Clases;
using PicosSectores.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PicosSectores.Controladores {
    public class ControladorPicos {

        public Pico CrearPico(int id, string nombre, int idSector) {
            try {
                using (var db = new ModeloBDPicos()) {
                    Sector sector = db.Sectores
                        .Include("Picos")
                        .SingleOrDefault(s => s.Id == idSector);
                    if (sector != null) {
                        Pico pico = sector.CrearPico(id, nombre);
                        db.SaveChanges();
                        return pico;
                    }
                }
            } catch (Exception ex) { }
            return null;
        }

        public int EditarPico(int id, string nuevoNombre) {
            try {
                using (var db = new ModeloBDPicos()) {
                    Pico pico = db.Picos.Find(id);
                    pico.Nombre = nuevoNombre;
                    return db.SaveChanges();
                }
            } catch (Exception) { }
            return 0;
        }

        public int EditarPico(int id, int nuevoId, string nuevoNombre, int idSector, int idSectorNuevo) {
            try {
                if (id != nuevoId) {
                    if (idSector != idSectorNuevo) {
                        Pico pico = CrearPico(nuevoId, nuevoNombre, idSectorNuevo);
                        EliminarPico(id);
                        if (pico != null)
                            return 1;
                    }
                    using (var db = new ModeloBDPicos()) {
                        Sector sector = db.Sectores
                            .Include("Picos")
                            .SingleOrDefault(s => s.Id == idSector);
                        Pico pico = sector.FindPico(id);
                        pico.Id = nuevoId;
                        pico.Nombre = nuevoNombre;
                        return db.SaveChanges();
                    }
                }
                if (idSector != idSectorNuevo) {
                    EliminarPico(id);
                    Pico pico = CrearPico(nuevoId, nuevoNombre, idSectorNuevo);
                    if (pico != null)
                        return 1;
                }
                using (var db = new ModeloBDPicos()) {
                    Sector sector = db.Sectores
                        .Include("Picos")
                        .SingleOrDefault(s => s.Id == idSector);
                    sector.FindPico(id).Nombre = nuevoNombre;
                    return db.SaveChanges();
                }

            } catch (Exception) { }
            return 0;
        }

        public int EliminarPico(int id) {
            try {
                using (var db = new ModeloBDPicos()) {
                    db.Picos.Remove(db.Picos.Find(id));
                    return db.SaveChanges();
                }
            } catch (Exception) { }
            return 0;
        }

        public Pico ObtenerPico(int id) {
            try {
                using (var db = new ModeloBDPicos()) {
                    return db.Picos.Find(id);
                }
            } catch (Exception) { }
            return null;
        }

        public List<Pico> ListarPicos(bool incluirSectores = false) {
            try {
                using (var db = new ModeloBDPicos()) {
                    if (!incluirSectores) {
                        return db.Picos.ToList();
                    } else {
                        return db.Picos
                            .Include("Sector")
                            .ToList<Pico>();
                    }
                }
            } catch (Exception) { }
            return new List<Pico>();
        }

    }
}
