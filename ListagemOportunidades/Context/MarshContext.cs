using ListagemOportunidades.Context.Configurations;
using ListagemOportunidades.Models;
using System.Data.Entity;


namespace ListagemOportunidades.Context
{
    public class MarshContext : DbContext
    { 

        public MarshContext() : base()
        {

        }

        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Oportunidade> Oportunidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ColaboradorConfig());
            modelBuilder.Configurations.Add(new OportunidadeConfig());
        }
    }
}