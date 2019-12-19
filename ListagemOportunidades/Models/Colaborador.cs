using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListagemOportunidades.Models
{
    public class Colaborador
    {
        public decimal Id { get; set; }
        public decimal Sequencial { get; set; }
        public string Nome { get; set; }
        public decimal NumeroSoftPeopleId { get; set; }
        public decimal OperadorId { get; set; }
        public string Email { get; set; }
    }
}