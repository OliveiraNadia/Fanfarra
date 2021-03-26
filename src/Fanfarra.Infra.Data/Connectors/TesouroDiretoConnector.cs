using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Fanfarra.Domain.Connectors;
using Fanfarra.Domain.Models;
using Newtonsoft.Json;

namespace Fanfarra.Infra.Data.Connectors
{
    public class TesouroDiretoConnector : ITesouroDiretoConnector
    {
        public async Task<IEnumerable<TesouroDireto>> ObterCustodia()
        {
           var tesouroDireto = new List<TesouroDireto>();
           using(var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://www.mocky.io/v2/5e3428203000006b00d9632a"))
                {
                     return tesouroDireto = JsonConvert.DeserializeObject<List<TesouroDireto>>(await response.Content.ReadAsStringAsync());
                }
            }
        }
    }
}
