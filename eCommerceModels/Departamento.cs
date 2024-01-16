using eCommerceModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eCommerceModels
{
   public class Departamentos
    {
         public int Id { get; set; }

        public string Name { get; set; } = null!;

        public ICollection<Usuario>? Usuarios { get; set; }
    }
}
