namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelCTA : DbContext
    {
        public ModelCTA()
            : base("name=ModelCTA")
        {
         }

        public DbSet<Tbl_Persona_Cuentas> Tbl_Cuentas { get; set; }
        public DbSet<Tbl_Persona> Tbl_Persona { get; set; }
        public DbSet<Tbl_Tipo_cuenta> Tbl_Tipo_cuenta { get; set; }
        public DbSet<Tbl_Usuario> Tbl_Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbl_Persona>().HasOptional(e => e.Tbl_Usuario).WithRequired(e => e.Tbl_Persona);
            modelBuilder.Entity<Tbl_Persona_Cuentas>().HasKey(x => new { x.IdPersona, x.IdCuenta });
        }
    }
}
