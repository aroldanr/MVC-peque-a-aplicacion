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

        [Key]
        public Guid IdPersona { get; set; }     

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

       public List<Tbl_Persona_Cuentas> Tbl_Cuentas { get; set; }

        public Tbl_Usuario Tbl_Usuario { get; set; }
      
    }
}
