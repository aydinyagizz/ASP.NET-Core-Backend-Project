using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        //yapılan işlem başarılı mı
        bool Success { get; }

        //yapılan işlemin mesajı
        string Message { get; }
    }
}
