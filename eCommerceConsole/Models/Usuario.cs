using System;
using System.Collections.Generic;

namespace eCommerceConsole.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Sexo { get; set; }

    public string? Rg { get; set; }

    public string Cpf { get; set; } = null!;

    public string? Mae { get; set; }

    public string? SituacaoCadastro { get; set; }

    public DateTimeOffset DataCadastro { get; set; }

    public virtual Contato? Contato { get; set; }

    public virtual ICollection<EnderecoEntrega> EnderecoEntregas { get; set; } = new List<EnderecoEntrega>();

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
}
