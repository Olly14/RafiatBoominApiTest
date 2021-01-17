using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoominApi.Infrastructure.IApiService;
using BoominApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoominApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WuraController : ControllerBase
    {
        private IApiUserService _apiUserService;
        private IApiLocationService _apiLocationService;

        public WuraController(IApiUserService apiUserService, IApiLocationService apiLocationService)
        {
            _apiUserService = apiUserService;
            _apiLocationService = apiLocationService;
        }


        [HttpGet]
        public async Task<HttpResponseModel> GetLocations()
        {
            return await _apiLocationService.GetAllLocations();
        }

        [HttpPost]
        public async Task<HttpResponseModel> Login(HttpResponseModel user)
        {
            return await _apiUserService.loginUserAsync(user);
        }
    }
}
