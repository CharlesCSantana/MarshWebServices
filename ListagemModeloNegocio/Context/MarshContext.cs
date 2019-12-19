using ListagemModeloNegocio.Context.Configurations;
using ListagemModeloNegocio.Models;

using System.Data.Entity;


namespace ListagemModeloNegocio.Context
{
    public class MarshContext : DbContext
    {
        public MarshContext() : base()
        {

        }

        public DbSet<ModeloNegocio> ModeloNegocios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ModeloNegocioConfig());
        }
    }
}