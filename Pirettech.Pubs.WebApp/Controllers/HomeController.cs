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


        /// <summary>
        /// Devolve uma lista de editoras
        /// </summary>
        /// <returns>List of Editora</returns>
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


        //Este método retorna os livros relacionados com o ID da Editora enviada pela Página HTML
        public ActionResult LivrosPorEditora(int id)
        {
            List<Livro> listaDeLivros = null;
            try
            {
                if (id <= 0)
                {
                    throw new Exception("A consulta solicitada é inválida.");
                }

                listaDeLivros = BibliotecaDB.LivrosPorEditora(id.ToString());

                if (listaDeLivros == null)
                {
                    throw new Exception("A Editora consultada é inválida.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //Retorna uma lista tipada do tipo Editora, pois a View espera receber um IEnumerable (é uma lista mas não permite alterações)
            return View(listaDeLivros);
        }


        public ActionResult Autor()
        {
            List<Autor> listaAutor = null;

            try
            {
                listaAutor = BibliotecaDB.AutoresLista();
            }
            catch (Exception ex)
            {

                throw;
            }
            return View(listaAutor);
        }

        public ActionResult DetalhesAutor(string id)
        {
            Autor autor = null;

            try
            {
                autor = BibliotecaDB.AutorPorId(id);
            }
            catch (Exception ex)
            {

                throw;
            }

            return View(autor);
        }
    }
}