using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LojaWebEF
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var usuarioBuilder = modelBuilder.Entity<Usuario>();
            usuarioBuilder.Property(usuario => usuario.Nome).HasColumnName("col_Nome");
            usuarioBuilder.ToTable("tbl_Usuarios");
        }
    }
}