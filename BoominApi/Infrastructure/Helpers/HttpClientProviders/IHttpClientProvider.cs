using System.Net.Http;


namespace BoominApi.Infrastructure.Helpers.HttpClientProviders
{
    public interface IHttpClientProvider
    {
        HttpClient Client { get; }
    }
}
