using System;

namespace Fanfarra.Domain.Models
{
    public class RendaFixa
    {
        public int CapitalInvestido { get; set; }
        public decimal CapitalAtual { get; set; }
        public int Quantidade { get; set; }
        public DateTime Vencimento { get; set; }
        public int IOF { get; set; }
        public int OutrasTaxas { get; set; }
        public int Taxas { get; set; }
        public string Indice { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public bool GuarantidoFGC { get; set; }
        public DateTime DataOperacao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public bool Primario { get; set; }
    }
}
