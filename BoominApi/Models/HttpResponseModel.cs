using System.Net.Http;


namespace BoominApi.Models
{
    public class HttpResponseModel
    {
        public HttpResponseModel()
        {
            User = new UserDto();
        }
        public string AccessToken { get; set; }
        public int StatusCode { get; set; }
        public UserDto User { get; set; }
        public HttpResponseMessage Response { get; set; }
    }
}
