using BoominApi.Infrastructure.ApiService;
using BoominApi.Infrastructure.Helpers.HttpRequestHandlers;
using BoominApi.Infrastructure.IApiService;
using BoominApi.Models;
using BoominApi.Test;
using NUnit.Framework;
using System.Net.Http;
using TechTalk.SpecFlow;

namespace TestApi.Steps
{
    [Binding]
    public class LoginUserFeatureSteps
    {
        private IApiUserService _apiUserService;
        private HttpResponseModel _requestDto;
        private HttpResponseModel _response;
        private IApiClient _apiClient;
        private HttpClient _htpClient;
        private int _ExpectedHttpStatusCode;

        public LoginUserFeatureSteps()
        {
            _requestDto = new HttpResponseModel();
            _response = new HttpResponseModel();
            _htpClient = HttpClientService.HttpClient;
            //_apiClient = new ApiClient(httpClientFactory);
            _apiClient = new ApiClient();
            _apiUserService = new ApiUserService(_apiClient);
            _ExpectedHttpStatusCode = 200;
        }


        [Given(@"I input email (.*)")]
        public void GivenIInputEmail(string email)
        {
            _requestDto.User.Email = email;
        }
        
        [Given(@"I input password (.*)")]
        public void GivenIInputPassword(string password)
        {
            _requestDto.User.Email = password;
        }
        
        [When(@"I send (.*)")]
        public async void WhenISend(string p0)
        {
            _response = await _apiUserService.loginUserAsync(_requestDto);
        }
        
        [Then(@"the result should be (.*)")]
        public async void ThenTheResultShouldBe(string p0)
        {
            //_response = await _apiUserService.loginUserAsync(_requestDto);
            Assert.AreEqual(_ExpectedHttpStatusCode, _response.StatusCode);
            Assert.IsNotNull(_response.AccessToken);
        }
    }
}
