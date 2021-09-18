using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.Constants
{
    public class Authorization
    {

        

        public const string DEFAULT_USERNAME = "abir";
        public const string DEFAULT_EMAIL = "abir@gmail.com";
        public const string DEFAULT_PASSWORD = "Password@12";
        public const Roles DEFAULT_ROLE = Roles.User;
    }

    public enum Roles
    {
        Administrator,
        Moderator,
        User
    }
}
