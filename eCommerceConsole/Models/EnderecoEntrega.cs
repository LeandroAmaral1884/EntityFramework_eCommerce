using System;
using System.Collections.Generic;

namespace eCommerceConsole.Models;

public partial class EnderecoEntrega
{
    public int Id { get; set; }

    public int UsurioId { get; set; }

    public string NomeEndereco { get; set; } = null!;

    public string Cep { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Bairro { get; set; } = null!;

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public int? UsuarioId { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
