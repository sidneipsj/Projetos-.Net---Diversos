using ParmezaniUniversidade.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ParmezaniUniversidade.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Contexto"){}
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}