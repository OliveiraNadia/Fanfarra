using Fanfarra.Domain.Connectors;
using Fanfarra.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Fanfarra.Infra.Data.Connectors
{
    public class RendaFixaConnector : IRendaFixaConnector
    {
        public string BaseUri
        {
            get
            {
                return "http://www.mocky.io/v2";
            }
        }

        public Task<IEnumerable<RendaFixa>> ObterCustodia()
        {
            string action = string.Format("/5e3429a33000008c00d96336");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, BaseUri + action);
            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;

            var fixedIncome = new List<RendaFixa>();

            return response = JsonContent.DeserializeObject<List<TesouroDireto>>(await response.Content.ReadAsStringAsync());
         
        }
    }
}
