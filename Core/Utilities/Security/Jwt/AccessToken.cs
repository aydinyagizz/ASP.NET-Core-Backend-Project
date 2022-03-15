using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    // erişim anahtarı
    public class AccessToken
    {
        public string Token { get; set; }

        //token'nin ne kadar geçerli olduğu.
        public DateTime Expiration { get; set; }
    }
}
