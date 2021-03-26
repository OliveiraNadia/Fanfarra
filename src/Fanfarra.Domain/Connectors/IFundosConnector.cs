using System.Collections.Generic;
using System.Threading.Tasks;
using Fanfarra.Domain.Models;

namespace Fanfarra.Domain.Connectors
{
    public interface IFundosConnector
    {
        Task<IEnumerable<Fundos>> ObterCustodia();
    }
}
