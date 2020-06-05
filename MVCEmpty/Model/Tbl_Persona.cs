namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Tbl_Persona
    {      
        public Tbl_Persona()
        {
            Tbl_Cuentas = new List<Tbl_Cuentas>();
        }

        [Key]
        public Guid IdPersona { get; set; }

        public Guid IdUsuario { get; set; }

        [Required]
        [StringLength(50)]
        public string PrimerNombre { get; set; }

        [StringLength(50)]
        public string SegundoNombre { get; set; }

        [Required]
        [StringLength(50)]
        public string PrimerApellido { get; set; }

        [StringLength(50)]
        public string SegundoApellido { get; set; }

        public int? PersonaStatus { get; set; }

       public ICollection<Tbl_Cuentas> Tbl_Cuentas { get; set; }

        public virtual Tbl_Usuario Tbl_Usuario { get; set; }

        public List<Tbl_Persona> ListaPersona()
        {
            var Personas = new List<Tbl_Persona>();
            ModelCTA dc = new ModelCTA();
            try
            {
                Personas = (from x in dc.Tbl_Persona.Include("Tbl_Cuentas") select x).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return Personas;
        }
    }
}
