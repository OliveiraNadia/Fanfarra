using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fanfarra.Domain.Models;

namespace Fanfarra.Domain.Connectors
{
    public interface ITesouroDiretoConnector
    {
        Task<IEnumerable<TesouroDireto>> ObterCustodia();
    }
}
