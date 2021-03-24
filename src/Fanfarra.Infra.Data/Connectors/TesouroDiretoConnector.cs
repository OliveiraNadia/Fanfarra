using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Fanfarra.Domain.Connectors;
using Fanfarra.Domain.Models;

namespace Fanfarra.Infra.Data.Connectors
{
    public class TesouroDiretoConnector : ITesouroDiretoConnector
    {
        private HttpClient _client = new HttpClient();

        public async Task<IEnumerable<TesouroDireto>> ObterCustodia()
        {
   
           using(var client = new HttpClient())
            {
                var custodias = default(IEnumerable<TesouroDireto>);
                client.BaseAddress = new Uri("http://localhost:53557/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("http://www.mocky.io/v2/5e3428203000006b00d9632a");
                return custodias;
            }
        }
    }
}
