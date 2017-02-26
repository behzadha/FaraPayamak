using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace FaraPayamakRestClient
{
    public class HttpClientManager
    {
        private readonly string _baseUrl;
        private readonly HttpClient _httpClient;

        public HttpClientManager(string baseUrl)
        {
            _baseUrl = baseUrl;
            _httpClient =
                new HttpClient(new HttpClientHandler
                {
                    AutomaticDecompression =
                            System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
                })
                { Timeout = TimeSpan.FromSeconds(50) };

        }
        public async Task<TResponse> Get<TResponse>(string method)
        {
            var response = await _httpClient.GetAsync(_baseUrl + method);
            var respObj = await response.Content.ReadAsAsync<TResponse>();
            return respObj;
        }

        public async Task<TResponse> Post<TRequest, TResponse>(string method, TRequest request)
        {
            JsonMediaTypeFormatter jsonFormat = new JsonMediaTypeFormatter
            {
                SerializerSettings =
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore,
                    NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                    PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None
                }
            };
            
            var response = _httpClient.PostAsync(_baseUrl + method, request, jsonFormat).Result;
            var finalResponse = await response.Content.ReadAsAsync<TResponse>();

            return finalResponse;
        }
    }
}
