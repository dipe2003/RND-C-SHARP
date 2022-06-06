namespace PicosSectores.Clases {
    public class Pico {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual Sector Sector { get; set; }

        public Pico() {

        }

        public Pico(int idPico, string nombrePico, Sector sectorPico) {
            this.Id = idPico;
            this.Nombre = nombrePico;
            this.Sector = sectorPico;
        }
    }
}
