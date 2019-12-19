using ListagemOportunidades.Models;
using System.Data.Entity.ModelConfiguration;


namespace ListagemOportunidades.Context.Configurations
{
    public class ColaboradorConfig : EntityTypeConfiguration<Colaborador>
    {
        public void Configure()
        {
            ToTable("RETORNA_COLABORADOR");

            HasKey(c => c.NumeroSoftPeopleId);

            Property(c => c.Id)
                .HasColumnName("ID_COLABORADOR")
                .HasColumnType("NUMBER");

            Property(c => c.Sequencial)
                .HasColumnName("SEQ_COLABORADOR")
                .HasColumnType("NUMBER");

            Property(c => c.Nome)
                .HasColumnName("NOME")
                .HasColumnType("VARCHAR2");

            Property(c => c.NumeroSoftPeopleId)
                .HasColumnName("NR_PEOPLESOFT_ID")
                .HasColumnType("NUMBER");

            Property(c => c.OperadorId)
                .HasColumnName("ID_OPERADOR")
                .HasColumnType("NUMBER");

            Property(c => c.Email)
                .HasColumnName("E_MAIL")
                .HasColumnType("VARCHAR2");
        }
    }
}