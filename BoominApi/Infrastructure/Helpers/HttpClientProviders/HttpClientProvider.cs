using System.Net.Http;


namespace BoominApi.Infrastructure.Helpers.HttpClientProviders
{
    public class HttpClientProvider : IHttpClientProvider
    {

        private readonly IHttpClientFactory _httpClientFactory;
        private HttpClient _HttpClientApi;
        public HttpClientProvider(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _HttpClientApi = _httpClientFactory.CreateClient("TechieDairyClient");

        }


        public HttpClient Client => _HttpClientApi;

    }
}
