using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.Gallery;
using GKIbyAkhremchik.ViewModel.GalleryViewModel;
using GKIbyAkhremchik.ViewModel.NewsModels;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GKIbyAkhremchik.BL.Gallery
{
    public interface IGalleryService
    {
        IEnumerable<GalleryPhotoModel> GetGalleryPhoto();
        IEnumerable<GalleryVideoModel> GetGalleryVideo();

        void AddGallery(GalleryPhotoView insert);
        void AddGallery(GalleryVideoView insert);
        //void AddGallery(GalleryPhotoView insert, string nameDepart);

        GalleryPhoto GetGalleryPhotoById(int id);
        void UpdateGallery(GalleryPhoto update);
        GalleryVideo GetGalleryVideoById(int id);
        void UpdateGallery(GalleryVideo update);
        AlbumPhoto GetAlbumById(int id);
        void UpdateAlbum(AlbumPhoto update);

        void DeleteGallery(int id, string nameDepart);

        void Save();

        SelectList GetPhotosList(NewsModel news);
        SelectList GetPhotosList();
        SelectList GetVideosList(NewsModel news);
        SelectList GetVideosList();
    }
}
