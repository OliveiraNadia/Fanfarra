using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Fanfarra.Domain.Connectors;
using Fanfarra.Domain.Models;
using Newtonsoft.Json;

namespace Fanfarra.Infra.Data.Connectors
{
    public class FundosConnector : IFundosConnector
    {
        public async Task<IEnumerable<Fundos>> ObterCustodia()
        {
            var fundos = new List<Fundos>();
            using(var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://www.mocky.io/v2/5e342ab33000008c00d96342"))
                {
                    return fundos = JsonConvert.DeserializeObject<List<Fundos>>(await response.Content.ReadAsStringAsync());
                }
            }
        }
    }
}
