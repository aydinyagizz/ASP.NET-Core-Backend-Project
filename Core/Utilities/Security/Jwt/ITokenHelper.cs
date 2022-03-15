using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.Jwt
{
    //token üretimi gerçekleştirecek helper
    public interface ITokenHelper
    {
        //kullanıcı bilgisini ve rolünü veriyoruz.
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
