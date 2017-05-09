using GKIbyAkhremchik.BL.News;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.DAL.Context;
using GKIbyAkhremchik.DAL.Repositories;
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
            kernel.Bind<INewsContext<NewsSchool>>().To<NewsSchoolRepository>();
            kernel.Bind<INewsContext<NewsArt>>().To<NewsArtRepository>();
            kernel.Bind<INewsService>().To<NewsService>();
        }
    }
}
