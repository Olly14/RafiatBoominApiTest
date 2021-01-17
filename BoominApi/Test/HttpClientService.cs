using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BoominApi.Infrastructure.Helpers.HttpRequestHandlers;
using BoominApi.Infrastructure.IApiService;
using BoominApi.Models;

namespace BoominApi.Test
{
    public class HttpClientService 
    {

        public static HttpClient HttpClient
        {
            get
            {
                return new HttpClient
                {
                    BaseAddress = new Uri("http://localhost:8000/")
                };
            }
        }
    }
}
