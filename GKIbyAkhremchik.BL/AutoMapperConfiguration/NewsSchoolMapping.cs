using System;
using AutoMapper;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.Gallery;
using GKIbyAkhremchik.ViewModel.NewsModels;

namespace GKIbyAkhremchik.BL.AutoMapperConfiguration
{
    public class NewsSchoolMapping : IAutoConfiguration<NewsSchool>
    {
        public void MapConfigDB()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<NewsSchool, NewsModel>();
                config.CreateMap<GalleryPhoto, GalleryPhotoModel>();
                config.CreateMap<GalleryVideo, GalleryVideoModel>();
            });
        }

        public void MapConfigModel()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<NewsModel, NewsSchool>();
                config.CreateMap<GalleryPhotoModel, GalleryPhoto>();
                config.CreateMap<GalleryVideoModel, GalleryVideo>();
            });
        }
    }
}
