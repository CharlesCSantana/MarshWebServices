using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using ListagemModeloNegocio.Models;

namespace ListagemModeloNegocio.Context.Configurations
{
    public class ModeloNegocioConfig : EntityTypeConfiguration<ModeloNegocio>
    {
        public void Configure()
        {
            ToTable("pkg_modelo_negocio.listar_c1");

            Property(c => c.Id)
                .HasColumnName("ID_TAB_MODELO_NEGOCIO")
                .HasColumnType("NUMBER");

            Property(c => c.Sequencia)
                .HasColumnName("SEQ_TAB_MODELO_NEGOCIO")
                .HasColumnType("NUMBER");

            Property(c => c.Descricao)
                .HasColumnName("DESCRICAO")
                .HasColumnType("VARCHAR2");

           Property(c => c.DescricaoDetalhada)
                .HasColumnName("DESCRICAO_DETALHADA")
                .HasColumnType("VARCHAR2");
        }
    }
}