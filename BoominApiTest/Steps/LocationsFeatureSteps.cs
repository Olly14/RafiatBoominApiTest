using BoominApi.Infrastructure.ApiService;
using BoominApi.Infrastructure.Helpers.HttpRequestHandlers;
using BoominApi.Infrastructure.IApiService;
using BoominApi.Models;
using BoominApi.Test;
using NUnit.Framework;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;

namespace BoominApiTest.Steps
{
    [Binding]
    public class LocationsFeatureSteps
    {
        private IApiLocationService _apiLocationService;
        private HttpResponseModel _requestDto;
        private HttpResponseModel _response;
        private IApiClient _apiClient;
        private HttpClient _htpClient;
        private int _httpStatusCode;


        public LocationsFeatureSteps()
        {
            _requestDto = new HttpResponseModel();
            _response = new HttpResponseModel();
            _htpClient = HttpClientService.HttpClient;
            //_apiClient = new ApiClient(httpClientFactory);
            _apiClient = new ApiClient();
            _apiLocationService = new ApiLocationService(_apiClient);
            _httpStatusCode = 200;
        }
        [Given(@"I input route id is (.*)")]
        public void GivenIInputRouteIdIs(string p0)
        {
        }
        
        [Given(@"I input second second parameter is (.*)")]
        public void GivenIInputSecondSecondParameterIs(string p0)
        {
          
        }
        
        [When(@"I send(.*)")]
        public async void WhenISend(string p0)
        {
            _response = await _apiLocationService.GetAllLocations();
        }
        
        [Then(@"the result should be (.*)")]
        public async void ThenTheResultShouldBe(string p0)
        {
            _response = await _apiLocationService.GetAllLocations();
            Assert.AreEqual(_httpStatusCode, _response.StatusCode);
        }
    }
}
