using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnixGeradorDeProvas.Dominio;

namespace UnixsGeradorDeProvas.Repositorio
{
    public class ContextoDeDados : DbContext
    {

        public ContextoDeDados() : base("Unixs")
        {

        }
        public DbSet<StatusQuestao> StatusQuestao { get; set; }
        public DbSet<TipoQuestao> TipoQuestao { get; set; }
        public DbSet<Questao> Questao { get; set; }
        public DbSet<Profissional> Profissional { get; set; }
        public DbSet<Dificuldade> Dificuldade { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Funcoes> Funcoes { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Aula> Aula { get; set; }
        public DbSet<Polo> Polo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
