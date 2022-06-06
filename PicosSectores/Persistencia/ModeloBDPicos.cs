using PicosSectores.Clases;
using System.Data.Entity;

namespace PicosSectores.Persistencia {
    public class ModeloBDPicos : DbContext {
        // El contexto se ha configurado para usar una cadena de conexión 'ModeloBDPicos' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'PicosSectores.Persistencia.ModeloBDPicos' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'ModeloBDPicos'  en el archivo de configuración de la aplicación.
        public ModeloBDPicos()
            : base("name=ModeloBDPicos") {
            Database.SetInitializer<ModeloBDPicos>(new CreateDatabaseIfNotExists<ModeloBDPicos>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ModeloBD, Migrations.Configuration>());
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Sector> Sectores { get; set; }
        public virtual DbSet<Pico> Picos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            #region Configuracion de Pico

            // el id del pico no es generado automaticamente

            modelBuilder.Entity<Pico>()
                .HasKey<int>(p => p.Id);

            modelBuilder.Entity<Pico>()
                .Property(p => p.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            modelBuilder.Entity<Pico>()
               .HasRequired(p => p.Sector)
               .WithMany()
               .WillCascadeOnDelete(false);

            #endregion

            #region Configuracion Sector
            // al eliminar el sector se eliminan los picos que contiene
            modelBuilder.Entity<Sector>()
                .HasMany(s => s.Picos)
                .WithRequired(p => p.Sector)
                .WillCascadeOnDelete(true);
            #endregion
        }
    }

}