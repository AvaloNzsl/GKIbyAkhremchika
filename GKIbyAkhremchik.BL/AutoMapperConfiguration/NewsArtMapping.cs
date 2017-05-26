using AutoMapper;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.Gallery;
using GKIbyAkhremchik.ViewModel.NewsModels;

namespace GKIbyAkhremchik.BL.AutoMapperConfiguration
{
    public class NewsArtMapping : IAutoConfiguration<NewsArt>
    {
        public void MapConfigDB()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<NewsArt, NewsModel>();
                config.CreateMap<GalleryPhoto, GalleryPhotoModel>();
                config.CreateMap<GalleryVideo, GalleryVideoModel>();
            });
        }
        public void MapConfigModel()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<NewsModel, NewsArt>();
                config.CreateMap<GalleryPhotoModel, GalleryPhoto>();
                config.CreateMap<GalleryVideoModel, GalleryVideo>();
            });
        }
    }
}
