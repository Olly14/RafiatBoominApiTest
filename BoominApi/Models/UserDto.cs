using System;
using System.Collections.Generic;
using System.Text;

namespace BoominApi.Models
{
    public class UserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; } 
    }
}
