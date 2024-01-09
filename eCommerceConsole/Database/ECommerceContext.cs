using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using eCommerceConsole.Models;

namespace eCommerceConsole.Database;

public partial class ECommerceContext : DbContext
{
    public ECommerceContext()
    {
    }

    public ECommerceContext(DbContextOptions<ECommerceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contato> Contatos { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<EnderecoEntrega> EnderecoEntregas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contato>(entity =>
        {
            entity.HasIndex(e => e.UsuarioId, "IX_Contatos_UsuarioId").IsUnique();

            entity.HasOne(d => d.Usuario).WithOne(p => p.Contato).HasForeignKey<Contato>(d => d.UsuarioId);
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasMany(d => d.Usuarios).WithMany(p => p.Departamentos)
                .UsingEntity<Dictionary<string, object>>(
                    "DepartamentoUsuario",
                    r => r.HasOne<Usuario>().WithMany().HasForeignKey("UsuariosId"),
                    l => l.HasOne<Departamento>().WithMany().HasForeignKey("DepartamentoId"),
                    j =>
                    {
                        j.HasKey("DepartamentoId", "UsuariosId");
                        j.ToTable("DepartamentoUsuario");
                        j.HasIndex(new[] { "UsuariosId" }, "IX_DepartamentoUsuario_UsuariosId");
                    });
        });

        modelBuilder.Entity<EnderecoEntrega>(entity =>
        {
            entity.ToTable("EnderecoEntrega");

            entity.HasIndex(e => e.UsuarioId, "IX_EnderecoEntrega_UsuarioId");

            entity.Property(e => e.Cep).HasColumnName("CEP");

            entity.HasOne(d => d.Usuario).WithMany(p => p.EnderecoEntregas).HasForeignKey(d => d.UsuarioId);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.Property(e => e.Cpf).HasColumnName("CPF");
            entity.Property(e => e.Rg).HasColumnName("RG");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
