using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BoominApi.Models;

namespace BoominApi.Infrastructure.IApiService
{
    public interface IApiLocationService
    {
        Task<HttpResponseModel> GetAllLocations();
        Task<HttpResponseModel> GetLocation(int id);
        Task<HttpResponseModel> AddLocation(HttpResponseModel httpResponseModel);
        Task UpdateLocation(LocationDto locationDto);
        Task<bool> RemoveLocation(int id);
    }
}
