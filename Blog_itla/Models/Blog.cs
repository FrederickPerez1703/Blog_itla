using System;
using System.Collections.Generic;

namespace Blog_itla.Models
{
    public partial class Blog
    {
        public int IdBlog { get; set; }
        public int UsuarioBlog { get; set; }
        public string Titulo { get; set; }
        public string Mesajes { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual BlogUsuario UsuarioBlogNavigation { get; set; }
    }
}
