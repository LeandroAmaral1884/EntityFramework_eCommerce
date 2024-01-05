﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceModels
{
   public class EnderecoEntrega
    {
        public int Id {get; set; }
        public int UsurioId {get; set; }
        public string? NomeEndereco { get; set;}
        public string? CEP { get; set;}
        public string? Estado { get; set;}
        public string? Cidade { get; set;}
        public string? Bairro { get; set;}
        public string? Numero { get; set;}
        public string? Complemento { get; set;}
        public Usuario? Usuario { get; set;}

    }
}