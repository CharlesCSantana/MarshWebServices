using System.Data.Entity.ModelConfiguration;
using ListagemOportunidades.Models;

namespace ListagemOportunidades.Context.Configurations
{
    public class OportunidadeConfig : EntityTypeConfiguration<Oportunidade>
    {
        public void Configure()
        {
            ToTable("RETORNA_OPORTUNIDADE");

            HasKey(c => c.OportunidadeEfunnelId);

            Property(c => c.OportunidadeEfunnelId)
                .HasColumnName("ID_OPORTUNIDADE_EFUNNEL")
                .HasColumnType("NUMBER");

            Property(c => c.SolucaoEfunnelAllId)
                .HasColumnName("ID_SOLUCAO_EFFUNEL_ALL")
                .HasColumnType("NUMBER");

            Property(c => c.SequenciaEfunnelAll)
                .HasColumnName("SEQ_SOLUCAO_EFFUNEL_ALL")
                .HasColumnType("NUMBER");

            Property(c => c.SolucaoEffunelId)
                .HasColumnName("ID_SOLUCAO_EFFUNEL")
                .HasColumnType("NUMBER");

            Property(c => c.CodigoMforce)
                .HasColumnName("CODIGO_MFORCE")
                .HasColumnType("VARCHAR2(25)");

            Property(c => c.NomeOportunidade)
                .HasColumnName("NOME_OPORTUNIDADE")
                .HasColumnType("VARCHAR2(50)");

            Property(c => c.DescricaoSolucaoEfunnelId)
                .HasColumnName("ID_DESCR_SOLUCAO_EFUNNEL")
                .HasColumnType("NUMBER");

            Property(c => c.DescricaoSolucao)
                .HasColumnName("DESCRICAO_SOLUCAO")
                .HasColumnType("VARCHAR2(80)");

            Property(c => c.StatusSolucaoEfunnel)
                .HasColumnName("STATUS_SOLUCAO_EFUNNEL")
                .HasColumnType("VARCHAR2(80)");

            Property(c => c.ValorSolucaoEfunnel)
                .HasColumnName("VALOR_SOLUCAO_EFUNNEL")
                .HasColumnType("NUMBER");

            Property(c => c.CnpjCpf)
                .HasColumnName("CNPJ_CPF")
                .HasColumnType("VARCHAR2(20)");

            Property(c => c.NomeEmpresaEfunnel)
                .HasColumnName("NOME_EMPRESA_EFUNNEL")
                .HasColumnType("VARCHAR2(255)"); ;

            Property(c => c.PosicaoEfunnel)
                .HasColumnName("POSICAO_EFUNNEL")
                .HasColumnType("VARCHAR2(25)");

            Property(c => c.ValorEntradaEstimadaEfunnel)
                .HasColumnName("VL_ENTRADA_ESTIMADA_EFUNNEL")
                .HasColumnType("NUMBER");

            Property(c => c.MoedaOportunidadeEfunnel)
                .HasColumnName("MOEDA_OPORTUNIDADE_EFUNNEL")
                .HasColumnType("VARCHAR2(25)");

            Property(c => c.MoedaSolucaoEfunnel)
                .HasColumnName("MOEDA_SOLUCAO_EFUNNEL")
                .HasColumnType("VARCHAR2(25)");

            Property(c => c.UsuarioEffunelId)
                .HasColumnName("ID_USUARIO_EFUNNEL")
                .HasColumnType("NUMBER");

            Property(c => c.NomeUsuarioEfunnel)
                .HasColumnName("NOME_USUARIO_EFUNNEL")
                .HasColumnType("VARCHAR2(255)");

            Property(c => c.RespostaOportunidade)
                .HasColumnName("RESP_OPORTUNIDADE")
                .HasColumnType("NUMBER");

            Property(c => c.HbbId)
                .HasColumnName("ID_HBB")
                .HasColumnType("NUMBER");
        }
    }
}