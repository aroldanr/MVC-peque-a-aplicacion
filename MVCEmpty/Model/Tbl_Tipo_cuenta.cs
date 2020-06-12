namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Tbl_Tipo_cuenta
    {
        public Tbl_Tipo_cuenta()
        {
            Tbl_Cuentas = new List<Tbl_Persona_Cuentas>();
        }

        [Key]
        public Guid IdTipoCuenta { get; set; }

        [StringLength(30)]
        public string NombreCuenta { get; set; }

        public List<Tbl_Persona_Cuentas> Tbl_Cuentas { get; set; }               
      
    }
}
