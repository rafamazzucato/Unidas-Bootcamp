using SitePessoal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitePessoal.Controllers
{
    public class ContatoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Concluido = false;

            return View();
        }

        [HttpPost]
        public ActionResult Salvar(Contato contato)
        {
            try
            {
                if(string.IsNullOrEmpty(contato.Mail)
                       || string.IsNullOrEmpty(contato.Name)
                       || string.IsNullOrEmpty(contato.Message))
                {
                    throw new ArgumentException("Favor preencher todo formulário");
                }

                ViewBag.Concluido = true;
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                ViewBag.Concluido = false;
            }
            
            return View("Index");
        }
    }
}