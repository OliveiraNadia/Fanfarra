using System.Collections.Generic;
using System.Threading.Tasks;
using Fanfarra.Domain.Models;

namespace Fanfarra.Domain.Connectors
{
    public interface IRendaFixaConnector
    {
        Task<IEnumerable<RendaFixa>> ObterCustodia();
    }
}
