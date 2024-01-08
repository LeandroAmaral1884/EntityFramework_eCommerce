using eCommerceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eCommerceModels
{

    /*
     * EFcore + Migration
     * Tabela : Usuarios
     * Id - PK
     * Nome - nvarchar -  not null
     * Email - nvarchar - not null
     * Sexo- nvarchar - null
     * vira obrigatório tirando ?  public string Nome { get; set; }
     */
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Sexo { get; set; }
        public string? RG { get; set; }
        public string CPF { get; set; } = null!;
        public string? NomeMae { get; set; }
        public string? NomePai { get; set; }
        public string? SituacaoCadastro { get; set;}
        public DateTimeOffset DataCadastro { get; set;}
        public Contato? Contato { get; set; }
        public ICollection<EnderecoEntrega> ?EnderecoEntregas{ get; set; }
        public ICollection<Departamento> ?Departamento { get;set; }
        /*
         * TODO - Vincular com as classes:
         * - Contato
         * - EnderecoEntrega
         * - Departamento
         */

    }

}
