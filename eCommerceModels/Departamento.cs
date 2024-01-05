using eCommerceModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eCommerceModels
{
   public class Departamento
    {
         public int Id { get; set; }

        public string? Name { get; set; }

        public ICollection<Usuario>? Usuarios { get; set; }
    }
}
