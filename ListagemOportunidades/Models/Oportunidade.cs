using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListagemOportunidades.Models
{
    public class Oportunidade
    {
        public decimal SolucaoEfunnelAllId { get; set; }
        public decimal SequenciaEfunnelAll { get; set; }
        public decimal SolucaoEffunelId { get; set; }
        public string CodigoMforce { get; set; }
        public string NomeOportunidade { get; set; }
        public decimal DescricaoSolucaoEfunnelId { get; set; }
        public string DescricaoSolucao { get; set; }
        public string StatusSolucaoEfunnel { get; set; }
        public decimal ValorSolucaoEfunnel { get; set; }
        public string CnpjCpf { get; set; }
        public string NomeEmpresaEfunnel { get; set; }
        public decimal OportunidadeEfunnelId { get; set; }
        public string PosicaoEfunnel { get; set; }
        public decimal ValorEntradaEstimadaEfunnel { get; set; }
        public string MoedaOportunidadeEfunnel { get; set; }
        public string MoedaSolucaoEfunnel { get; set; }
        public decimal UsuarioEffunelId { get; set; }
        public string NomeUsuarioEfunnel { get; set; }
        public decimal RespostaOportunidade { get; set; }
        public decimal HbbId { get; set; }
    }
}