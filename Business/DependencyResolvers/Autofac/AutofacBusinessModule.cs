using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        // module oluşturulma sebebi şu interface'nin karşılığı budur vs demek için. Daha önce Startupda belirttiğimiz şeyleri burada belirtiyoruz.
        protected override void Load(ContainerBuilder builder)
        {
            //eğer birisi constructor'da IProductService şeklinde bir şey isterse ona ProductManager veriyoruz.
            builder.RegisterType<ProductManager>().As<IProductService>();
            //eğer birisi constructor'da IProductDal şeklinde bir şey isterse ona EfProductDal veriyoruz.
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
        }
    }
}
