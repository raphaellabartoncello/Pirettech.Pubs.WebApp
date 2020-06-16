using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pirettech.Pubs.WebApp.Models
{
    public static class BibliotecaDB
    {
        // EditorasLista
        // Retorna a lista de todas as editoras
        //
        public static List<Editora> EditorasLista()
        {
            using (var db = new pubsEntities())
            {
                return db.Editoras.ToList();
            }
        }
    }
}