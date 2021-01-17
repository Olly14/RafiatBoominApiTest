//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;


//namespace BoominApi.Helpers.HttpRequestHandlers
//{
//    public class ApiCient : IApiClient
//    {
//        private HttpClient _httpClient;
//        //private readonly IAuthenticationManager _authenticationManager;
//        //private readonly IHttpContextAccessor _httpContextAccessor;
//        private readonly IHttpClientFactory _httpClientFactory;

//        private string _accessToken;

//        public ApiCient(IHttpClientFactory httpClientFactory)
//        {
//            _httpClientFactory = httpClientFactory;
//            _httpClient = _httpClientFactory.CreateClient("TechieDairyClient");
//            _accessToken = string.Empty;
//        }


//        public Task<bool> DeleteAsync(string uri)
//        {
//            throw new System.NotImplementedException();
//        }

//        public async Task<T> GetAsync<T>(string uri)
//        {
//            var message =
//            new HttpRequestMessage(HttpMethod.Get, $"{ _httpClient.BaseAddress}{uri}");
//            //message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AppUserSettings.AccessToken);



//            var response = await _httpClient.SendAsync(message);

//            if (response != null && response.IsSuccessStatusCode)
//            {
//                var result = await response.Content.ReadAsStringAsync();

//                return JsonConvert.DeserializeObject<T>(result);
//            }

//            //HandleApiError(response);
//            return default;
//        }

//        public async Task<IEnumerable<T>> ListAsync<T>(string uri)
//        {
//            var message =
//                new HttpRequestMessage(HttpMethod.Get, $"{ _httpClient.BaseAddress}{uri}");
//            //message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AppUserSettings.AccessToken);

//            var response = new HttpResponseMessage();

//            try
//            {
//                response = await _httpClient.SendAsync(message);

//                if (response != null && response.IsSuccessStatusCode)
//                {

//                    var jsonString = await response.Content.ReadAsStringAsync();

//                    var listOfJsonT = JsonConvert.DeserializeObject<ICollection<T>>(jsonString);

//                    var jsonRes = JsonConvert.SerializeObject(listOfJsonT, Formatting.None, new JsonSerializerSettings
//                    {
//                        NullValueHandling = NullValueHandling.Ignore
//                    });
//                    listOfJsonT = JsonConvert.DeserializeObject<ICollection<T>>(jsonRes);
//                    return listOfJsonT;
//                }

//            }
//            catch (Exception ex)
//            {

//                var errMsg = ex.Message;
//                HandleApiError(response);

//            }







//            HandleApiError(response);
//            return default;
//        }

//        public Task<IEnumerable<T>> ListAsync<T>()
//        {
//            throw new System.NotImplementedException();
//        }

//        public async Task<T> PostAsync<T>(string uri, T newItem)
//        {
//            var message =
//            new HttpRequestMessage(HttpMethod.Post, $"{ _httpClient.BaseAddress}{uri}")
//            {
//                Content = new StringContent(JsonConvert.SerializeObject(newItem), Encoding.UTF8,
//                    "application/json")
//            };
//            //message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AppUserSettings.AccessToken);


//            try
//            {
//                var responseA = await _httpClient.SendAsync(message);

//                if (responseA != null && responseA.IsSuccessStatusCode)
//                {
//                    var jsonString = await responseA.Content.ReadAsStringAsync();
//                    var result = JsonConvert.DeserializeObject<T>(jsonString);
//                    return result;
//                }
//            }
//            catch (Exception ex)
//            {
//                var errorMsg = ex.Message;
//                throw;
//            }


//            //TODO: Fix the error 
//            //HandleApiError(responseA);
//            return default;
//        }

//        public async Task PutAsync<T>(string uri, T updatedItem)
//        {
//            var message =
//            new HttpRequestMessage(HttpMethod.Put, $"{ _httpClient.BaseAddress}{uri}")
//            {
//                Content = new StringContent(JsonConvert.SerializeObject(updatedItem), Encoding.UTF8,
//                    "application/json")
//            };
//            //message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AppUserSettings.AccessToken);



//            var response = await _httpClient.SendAsync(message);

//            if (response != null && response.IsSuccessStatusCode)
//            {
//                var result = await response.Content.ReadAsStringAsync();
//                //return default;
//            }
//            else
//            {

//                HandleApiError(response);
//                //return default;
//            }

//        }


//        private HttpResponseMessage HandleApiError(HttpResponseMessage response)
//        {
//            var switch_on = response.StatusCode;
//            switch (switch_on)
//            {
//                case HttpStatusCode.Unauthorized:
//                    response.StatusCode = HttpStatusCode.Unauthorized;
//                    break;

//                default:
//                    response.StatusCode = response.StatusCode;
//                    break;
//            }
//            return response;
//        }
//    }
//}
