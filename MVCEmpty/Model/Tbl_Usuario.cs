namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Required]
        [StringLength(20)]
        public string UserLoging { get; set; }

        [Required]
        [StringLength(50)]
        public string Contraseña { get; set; }

        public int? UsuarioStatus { get; set; }

        public virtual Tbl_Persona Tbl_Persona { get; set; }
    }
}
