using Business.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class ContextApiPires : IdentityDbContext
    {
        public DbSet<Produto> produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<CompraProduto> CompraProdutos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public ContextApiPires(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>().HasOne(f => f.Endereco).WithOne(e => e.Fornecedor).HasForeignKey<Endereco>(e => e.FornecedorId);
            modelBuilder.Entity<Fornecedor>().HasMany(f => f.Produtos).WithOne(p => p.Fornecedor).HasForeignKey(p => p.FornecedorId);
            modelBuilder.Entity<CompraProduto>().HasKey(c => new { c.CompraId, c.ProdutoId });
            modelBuilder.Entity<Cliente>().HasMany(c => c.Compras).WithOne(c => c.Cliente).HasForeignKey(c => c.ClienteId);
           
            base.OnModelCreating(modelBuilder); 
        }
    }
}
