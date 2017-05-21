using System;
using System.Collections.Generic;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.Gallery;
using GKIbyAkhremchik.ViewModel.GalleryViewModel;
using GKIbyAkhremchik.DAL.UnitService;
using System.Web.Mvc;
using GKIbyAkhremchik.ViewModel.NewsModels;
using GKIbyAkhremchik.ViewModel.NewsViewModel;

namespace GKIbyAkhremchik.BL.Gallery
{
    public class GalleryService : IGalleryService
    {
        private UnitOfWork _contextUnit;
        public GalleryService(UnitOfWork contextUnit)
        {
            _contextUnit = contextUnit;
        }

        public IEnumerable<GalleryPhotoModel> GetGalleryPhoto()
        {
            var galleryList = new List<GalleryPhotoModel>();
            var gallery = _contextUnit.PhotoesGallery.GetAllGallery();
            foreach (var n in gallery)
            {
                galleryList.Add(new GalleryPhotoModel
                {
                    GalleryPhotoId = n.GalleryPhotoId,
                    Title = n.Title,
                    Img = n.Img,
                    Date = n.Date,
                    Description = n.Description
                });
            }
            return galleryList;
        }
        public IEnumerable<GalleryVideoModel> GetGalleryVideo()
        {
            var galleryList = new List<GalleryVideoModel>();
            var gallery = _contextUnit.VideoGallery.GetAllGallery();
            foreach (var n in gallery)
            {
                galleryList.Add(new GalleryVideoModel
                {
                    GalleryVideoId = n.GalleryVideoId,
                    Title = n.Title,
                    Img = n.Img,
                    Date = n.Date,
                    Description = n.Description,
                    Url = n.Url
                });
            }
            return galleryList;
        }

        public void AddGallery(GalleryPhotoView insert)
        {
            GalleryPhoto gallery = new GalleryPhoto
            {
                Title = insert.Title,
                Img = insert.Img,
                Date = insert.Date,
                Description = insert.Description

            };
            _contextUnit.PhotoesGallery.AddGallery(gallery);
        }
        public void AddGallery(GalleryVideoView insert)
        {
            GalleryVideo gallery = new GalleryVideo
            {
                Title = insert.Title,
                Img = insert.Img,
                Date = insert.Date,
                Description = insert.Description,
                Url = insert.Url
            };
            _contextUnit.VideoGallery.AddGallery(gallery);
        }


        public GalleryPhoto GetGalleryPhotoById(int id)
        {
            return _contextUnit.PhotoesGallery.GetGalleryById(id);
        }
        public void UpdateGallery(GalleryPhoto update)
        {
            _contextUnit.PhotoesGallery.UpdateGallery(update);
        }
        public GalleryVideo GetGalleryVideoById(int id)
        {
            return _contextUnit.VideoGallery.GetGalleryById(id);
        }
        public void UpdateGallery(GalleryVideo update)
        {
            _contextUnit.VideoGallery.UpdateGallery(update);
        }
        public AlbumPhoto GetAlbumById(int id)
        {
            return _contextUnit.PhotoAlbum.GetGalleryById(id);
        }
        public void UpdateAlbum(AlbumPhoto update)
        {
            _contextUnit.PhotoAlbum.UpdateGallery(update);
        }

        public void DeleteGallery(int id, string nameDepart)
        {
            if (nameDepart == "photo") _contextUnit.PhotoesGallery.DeleteGallery(id);
            if (nameDepart == "video") _contextUnit.VideoGallery.DeleteGallery(id);
            if (nameDepart == "album") _contextUnit.PhotoAlbum.DeleteGallery(id);
        }

        public void Save() { _contextUnit.Save(); }


        public SelectList GetVideosList(NewsModel news)
        {
            SelectList gallery = new SelectList(
                _contextUnit.VideoGallery.GetAllGallery(),
                "GalleryVideoId",
                "Title",
                news.GalleryVideoId);
            return gallery;

        }
        public SelectList GetPhotosList(NewsModel news)
        {
            var photo = _contextUnit.PhotoesGallery.GetAllGallery();
            //var list = new List<GalleryPhoto>();
            //foreach (var item in photo)
            //{
            //    list.Add(new GalleryPhoto
            //    {
            //        GalleryPhotoId = item.GalleryPhotoId,
            //        Title = item.Title
            //    });
            //}
            //list.Add(new GalleryPhoto { GalleryPhotoId = 0, Title = "" });
            SelectList gallery = new SelectList(
                photo,
                "GalleryPhotoId",
                "Title",
                news.GalleryPhotoId);
            return gallery;
        }
    }
}