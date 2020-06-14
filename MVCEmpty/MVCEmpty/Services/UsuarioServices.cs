using System;
using System.Collections.Generic;
using Model;
using System.Linq;
using System.Web;

namespace MVCEmpty.Services
{
    public class UsuarioServices
    {
        public Tbl_Usuario ConsultarUsuario(string LoginName, string Password)
        {
            var Usuario = new Tbl_Usuario();
            try
            {
                ModelCTA cn = new ModelCTA();
                Usuario = (from x in cn.Tbl_Usuario where x.UserLoging == LoginName && x.Contraseña == Password select x).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            return Usuario;
        }

    }
}