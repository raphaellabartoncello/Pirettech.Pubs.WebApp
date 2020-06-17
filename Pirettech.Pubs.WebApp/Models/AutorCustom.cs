using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pirettech.Pubs.WebApp.Models
{
    public partial class Autor
    {

        /// <summary>
        /// Propriedade READONLY - Retorna nome completo do autor
        /// </summary>
        public string NomeCompleto
        {
            get { return Nome + " " + Sobrenome; }
        }
    }
}