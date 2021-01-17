using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BoominApi.Infrastructure.Helpers.HttpRequestHandlers;
using BoominApi.Infrastructure.IApiService;
using BoominApi.Models;

namespace BoominApi.Infrastructure.ApiService
{
    public class ApiLocationService : IApiLocationService
    {

        private const string LOCATIONS_URL = "Locations";
        private readonly IApiClient _apiClient;
        public ApiLocationService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<HttpResponseModel> AddLocation(HttpResponseModel locationDto)
        {
            return await _apiClient.PostAsync<HttpResponseModel>(LOCATIONS_URL, locationDto);
        }

        public async Task<HttpResponseModel> GetAllLocations()
        {
           return await _apiClient.ListAsync<HttpResponseModel>(LOCATIONS_URL);
        }

        public async Task<HttpResponseModel> GetLocation(int id)
        {
            return await _apiClient.GetAsync<HttpResponseModel>(LOCATIONS_URL);
        }

        public async Task<bool> RemoveLocation(int id)
        {
            return await _apiClient.DeleteAsync(LOCATIONS_URL + "/" + id);
        }

        public async Task UpdateLocation(LocationDto locationDto)
        {
             await _apiClient.PutAsync(LOCATIONS_URL, locationDto);
        }
    }
}
