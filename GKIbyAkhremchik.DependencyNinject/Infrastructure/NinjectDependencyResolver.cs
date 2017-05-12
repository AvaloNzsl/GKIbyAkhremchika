using GKIbyAkhremchik.BL.Gallery;
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
            kernel.Bind<INewsService>().To<NewsService>();
            kernel.Bind<INewsContext<NewsSchool>>().To<NewsSchoolRepository>();
            kernel.Bind<INewsContext<NewsArt>>().To<NewsArtRepository>();
            kernel.Bind<INewsContext<NewsMusical>>().To<NewsMusicalRepository>();
            kernel.Bind<INewsContext<NewsEvent>>().To<NewsEventRepository>();
            // --->>><<<---
            kernel.Bind<IGalleryService>().To<GalleryService>();
            kernel.Bind<IGalleryContext<GalleryPhoto>>().To<GalleryPhotoRepository>();
            kernel.Bind<IGalleryContext<GalleryVideo>>().To<GalleryVideoRepository>();
            kernel.Bind<IGalleryContext<AlbumPhoto>>().To<AlbumPhotoRepository>();
        }
    }
}
