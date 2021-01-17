using System.Threading.Tasks;
using BoominApi.Models;

namespace BoominApi.Infrastructure.IApiService
{
    public interface IApiUserService
    {
        Task<HttpResponseModel> loginUserAsync(HttpResponseModel loginUserModel);
        Task<HttpResponseModel> RegisterUserAsync(HttpResponseModel loginUserModel); 
    }
}
