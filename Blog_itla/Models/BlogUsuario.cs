using System;
using System.Collections.Generic;

namespace Blog_itla.Models
{
    public partial class BlogUsuario
    {
        public BlogUsuario()
        {
            Blog = new HashSet<Blog>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int Edad { get; set; }
        public string Dirrecion { get; set; }

        public virtual ICollection<Blog> Blog { get; set; }
    }
}
