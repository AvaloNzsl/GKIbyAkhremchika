using GKIbyAkhremchik.BL.News;
using GKIbyAkhremchik.DAL.Context;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GKIbyAkhremchik.DependencyNinject.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }


        private void AddBindings()
        {
            kernel.Bind<INewsContext>().To<NewsContext>();
            kernel.Bind<INewsService>().To<NewsService>();
            /*Мы создали цепочку зависимостей. Контроллер Home зависит от интерфейса IValueCalculator,
             *  который библиотека Ninject должна распознавать с использованием класса LinqValueCalculator. 
             *  Класс LinqValueCalculator зависит от интерфейса IDiscountHelper,
             *  который библиотека Ninject должна распознавать с применением класса DefaultDiscountHelper.*/
            //kernel.Bind<IDiscountHelper>().
            //    To<DefaultDiscountHelper>().WithConstructorArgument("discountParam", 50m);
        }
    }
}
