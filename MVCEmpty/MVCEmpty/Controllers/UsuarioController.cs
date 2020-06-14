using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEmpty.Controllers
{
    public class UsuarioController : Controller
    {
        Services.UsuarioServices _UsuarioServices = new Services.UsuarioServices(); 
        public ActionResult Login(string message="")
        {
            ViewBag.message = message;
            return View();
        }

        [HttpPost]
        public ActionResult Login(string uname, string psw)
        {
            if (!string.IsNullOrEmpty(uname)&& !string.IsNullOrEmpty(psw))
            {     
              var User = _UsuarioServices.ConsultarUsuario(uname, psw);
              if (User != null )
                {
                    return RedirectToAction("Index", "Home");
                    
                }
                else 
                {
                    return Login("No se encontraron los datos");
                }
           }
            return View();
        }
    }
}