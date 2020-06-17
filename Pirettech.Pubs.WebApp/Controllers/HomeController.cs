using Pirettech.Pubs.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pirettech.Pubs.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Livro()
        {
            return View();
        }

        public ActionResult Autor()
        {
            return View();
        }

        public ActionResult Editora()
        {
            List<Editora> listaEditora = null;
            try
            {
                listaEditora = BibliotecaDB.EditorasLista();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //Retorna uma lista tipada do tipo Editora, pois a View espera receber um IEnumerable (é uma lista mas não permite alterações)
            return View(listaEditora);
        }
    }
}