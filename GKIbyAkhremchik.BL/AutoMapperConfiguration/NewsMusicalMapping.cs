using AutoMapper;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.Gallery;
using GKIbyAkhremchik.ViewModel.NewsModels;

namespace GKIbyAkhremchik.BL.AutoMapperConfiguration
{
    public class NewsMusicalMapping : IAutoConfiguration<NewsMusical>
    {
        public void MapConfigDB()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<NewsMusical, NewsModel>();
                config.CreateMap<GalleryPhoto, GalleryPhotoModel>();
                config.CreateMap<GalleryVideo, GalleryVideoModel>();
            });
        }
        public void MapConfigModel()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<NewsModel, NewsMusical>();
                config.CreateMap<GalleryPhotoModel, GalleryPhoto>();
                config.CreateMap<GalleryVideoModel, GalleryVideo>();
            });
        }
    }
}
