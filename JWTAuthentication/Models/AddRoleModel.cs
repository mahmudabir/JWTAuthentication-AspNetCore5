using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using JWTAuthentication.Constants;

using Newtonsoft.Json.Converters;

using static JWTAuthentication.Constants.Authorization;

namespace JWTAuthentication.Models
{
    public class AddRoleModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }


        [Required]
        [EnumDataType(typeof(Roles))]
        public string Role { get; set; }
    }
}
