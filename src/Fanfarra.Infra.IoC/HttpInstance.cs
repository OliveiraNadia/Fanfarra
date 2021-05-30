using System.Net.Http;

namespace Fanfarra.Infra.IoC
{
    public class HttpInstance
    {
        private static HttpClient _httpClientInstance;

        private HttpInstance()
        {

        }

        public static HttpClient GetHttpClientInstance()
        {
            if(_httpClientInstance == null)
            {
                _httpClientInstance = new HttpClient();
                _httpClientInstance.DefaultRequestHeaders.ConnectionClose = false;
            }
            return _httpClientInstance;
        }
    }
}
