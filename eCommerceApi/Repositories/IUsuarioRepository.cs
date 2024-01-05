using eCommerceModels;
using System.Security.Cryptography;

namespace eCommerceApi.Repositories
{
    public interface IUsuarioRepository
    {
        /*
         *CRUD - Create,Read/Retrive,Update e Delete
         *Consulta
         */
        List<Usuario> Get();

        Usuario Get(int id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
        
    }
}
