using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BoominApi.Infrastructure.Helpers.HttpRequestHandlers;
using BoominApi.Infrastructure.IApiService;
using BoominApi.Models;

namespace BoominApi.Infrastructure.ApiService
{
    public class ApiUserService : IApiUserService
    {
        private const string USER_LOGIN_URL = "Auth/Login";
        private const string USER_REGISTRATION_URL = "Auth/Register";
        private readonly IApiClient _apiClient;

        public ApiUserService(IApiClient apiClient)
        {
            _apiClient = apiClient;
            
        }
        public async Task<HttpResponseModel> loginUserAsync(HttpResponseModel loginUserModel)
        {
            return await _apiClient.PostAsync(USER_LOGIN_URL, loginUserModel);
        }
        public async Task<HttpResponseModel> RegisterUserAsync(HttpResponseModel loginUserModel)
        {
            return await _apiClient.PostAsync(USER_REGISTRATION_URL, loginUserModel);
        }
    }
}
