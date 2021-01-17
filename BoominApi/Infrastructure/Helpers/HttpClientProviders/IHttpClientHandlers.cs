using System.Net.Http;


namespace BoominApi.Infrastructure.Helpers.HttpClientProviders
{
    public interface IHttpClientHandlers
    {
        HttpClientHandler GetInsecureHandler();
    }
}
