namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Tbl_Cuentas
    {
        [Key]
        public Guid IdCuenta { get; set; }

        public Guid? TipodeCuenta { get; set; }

        public Guid? IdPersona { get; set; }
        public int NumerodeCuenta { get; set; }

        public virtual Tbl_Persona Tbl_Persona { get; set; }

        public virtual Tbl_Tipo_cuenta Tbl_Tipo_cuenta { get; set; }

        public List<Tbl_Cuentas> ListarCuentas()
        {
            var Cuentas = new List<Tbl_Cuentas>();
            ModelCTA dc = new ModelCTA();
            try
            {
                Cuentas = (from x in dc.Tbl_Cuentas select x).ToList(); 
            }
            catch (Exception)
            {

                throw;
            }
            return Cuentas;
        }
    }
}
