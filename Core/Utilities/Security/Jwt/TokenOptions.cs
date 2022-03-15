using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class TokenOptions
    {
        //token'nin kullanıcı kitlesi
        public string Audience { get; set; }

        //imzalayan
        public string Issuer { get; set; }

        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
