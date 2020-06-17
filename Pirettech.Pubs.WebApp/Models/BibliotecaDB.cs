using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pirettech.Pubs.WebApp.Models
{
    public static class BibliotecaDB
    {
        #region EDITORA - MÉTODOS

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

        public static List<Livro> LivrosLista()
        {
            using (var db = new pubsEntities())
            {
                return db.Livros.ToList();
            }
        }

        public static List<Livro> LivrosPorEditora(string editoraId)
        {
            using (var db = new pubsEntities())
            {
                return (from l in db.Livros
                        where l.EditoraId == editoraId
                        select l).ToList();
            }
        }

        public static Editora EditoraPorId(string editoraId)
        {
            using (var db = new pubsEntities())
            {
                var editora = (from c in db.Editoras
                        where c.EditoraId == editoraId
                        select c).FirstOrDefault();

                return editora;
            }
        }

        #endregion

        public static List<Autor> AutoresLista()
        {
            using (var db = new pubsEntities())
            {
                return db.Autor.ToList();
            }
        }

        public static Autor AutorPorId(string autorId)
        {
            using (var db = new pubsEntities())
            {
                var autor = (from a in db.Autor
                             where a.AutorId == autorId
                             select a).FirstOrDefault();

                return autor;
            }
        }

        public static List<Livro> LivrosPorAutor(string autorId)
        {
            using (var db = new pubsEntities())
            {
                var livrosAutor = (from a in db.LivrosAutores
                                   where a.AutorId.Equals(autorId)
                                   select a.LivroId).ToArray();
                var livros = from l in db.Livros
                             where livrosAutor
                             .Contains(l.LivroId)
                             select l;

                return livros.ToList();
            }
        }
    }
}