using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;

namespace MVCEmpty.Controllers
{
    
    public class HomeController : Controller
    {
        private Tbl_Persona_Cuentas Persona = new Tbl_Persona_Cuentas();
        private Tbl_Persona Pers = new Tbl_Persona();
        private Tbl_Tipo_cuenta TCuenta = new Tbl_Tipo_cuenta();


        public ActionResult Index()
        {
            // return View(Persona.ListarCuentas());
            return View();
        }

        public ActionResult RegistrodeCuentas()
        {
            //var lst = TCuenta.ListadeCuentas();
            
           // ViewBag.listado = lst.ToList();
            return View();
        }

      }
}