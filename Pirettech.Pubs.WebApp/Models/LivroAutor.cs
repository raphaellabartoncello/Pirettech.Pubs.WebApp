//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pirettech.Pubs.WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LivroAutor
    {
        public string AutorId { get; set; }
        public string LivroId { get; set; }
        public Nullable<byte> AutorOrdem { get; set; }
        public Nullable<int> TipoRoyalty { get; set; }
    
        public virtual Autor Autor { get; set; }
        public virtual Livro Livro { get; set; }
    }
}
