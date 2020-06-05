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
            Tbl_Cuentas = new List<Tbl_Cuentas>();
        }

        [Key]
        public Guid IdTipoCuenta { get; set; }

        [StringLength(30)]
        public string NombreCuenta { get; set; }

        public virtual List<Tbl_Cuentas> Tbl_Cuentas { get; set; }

       
        public List<Tbl_Tipo_cuenta> ListadeCuentas()
        {
            var Lista = new List<Tbl_Tipo_cuenta>();
            ModelCTA cn = new ModelCTA();
            try
            {
                Lista = (from x in cn.Tbl_Tipo_cuenta select x).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return Lista;
        }
    }
}
