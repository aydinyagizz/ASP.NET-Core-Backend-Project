using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);

        //başarılı mı başarısız mı oldu diye IResult diyoruz.
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
