using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListagemModeloNegocio.Models
{
    public class ModeloNegocio
    {
        public decimal Id { get; set; }
        public decimal Sequencia { get; set; }
        public string Descricao { get; set; }
        public string DescricaoDetalhada { get; set; }
    }
}