using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fanfarra.Domain.Models
{
    public class TesouroDireto
    {
        public int ValorInvestido { get; set; }
        public int ValorTotal { get; set; }
        public int Vencimento { get; set; }
        public int DataDeCompra { get; set; }
        public int IOF { get; set; }
        public int Indice{ get; set; }
        public int Tipo { get; set; }
        public int Nome { get; set; }
    }
}
