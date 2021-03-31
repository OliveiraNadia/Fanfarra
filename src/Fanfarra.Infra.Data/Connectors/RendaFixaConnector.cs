using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Fanfarra.Domain.Connectors;
using Fanfarra.Domain.Models;
using Newtonsoft.Json;

namespace Fanfarra.Infra.Data.Connectors
{
    public class RendaFixaConnector : IRendaFixaConnector
    {
        public async Task<IEnumerable<RendaFixa>> ObterCustodia()
        {
            try
            {
                var rendaFixa = new List<RendaFixa>();
                using (var client = new HttpClient())
                {
                        using (var response =  client.GetAsync("http://www.mocky.io/v2/5e3429a33000008c00d96336").Result)
                        {
                            var retorno = JsonConvert.DeserializeObject<RendaFixa>(await response.Content.ReadAsStringAsync());

                            rendaFixa.Add(retorno);
                       
                            return rendaFixa;
                        }

                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }
    }
}
