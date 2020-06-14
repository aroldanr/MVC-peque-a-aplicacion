using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCEmpty.Controllers
{
    public class UsuarioController : Controller
    {
        Services.UsuarioServices _UsuarioServices = new Services.UsuarioServices(); 
        public ActionResult Login()
        {
           
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
                    FormsAuthentication.SetAuthCookie(User.UserLoging, true);
                    return RedirectToAction("Index", "Home");
                    
                }
                else 
                {
                   
                }
           }
            return View();
        }
        [Authorize]
        public ActionResult LogOut()
        {           
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Usuario");
        }
    }
}