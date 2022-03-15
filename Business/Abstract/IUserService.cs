using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        // kullanıcı yetkilerinin getirilmesi
        List<OperationClaim> GetClaims(User user);

        //kullanıcı ekleme
        void Add(User user);

        //kullanıcıyı maili vasutasıyla bulmak 
        User GetByMail(string email);
    }
}
