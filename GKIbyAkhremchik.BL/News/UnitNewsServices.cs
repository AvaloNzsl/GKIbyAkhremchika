using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.DAL.Repositories;
using System;

namespace GKIbyAkhremchik.BL.News
{
    public class UnitNewsServices : IDisposable //pattern unit of work
    {
        private GKIDbContext _contextDbNews = new GKIDbContext();
        // --->>><<<---
        private NewsSchoolRepository schoolNewsRepository;
        public NewsSchoolRepository SchoolNews
        {
            get { if (schoolNewsRepository == null)
                { schoolNewsRepository = new NewsSchoolRepository(_contextDbNews); }
                return schoolNewsRepository;
            }
        }
        private NewsArtRepository artNewsRepository;
        public NewsArtRepository ArtNews
        {
            get
            {
                if (artNewsRepository == null)
                { artNewsRepository = new NewsArtRepository(_contextDbNews); }
                return artNewsRepository;
            }
        }
        public NewsMusicalRepository musicNewsRepository;
        public NewsMusicalRepository MusicNews
        {
            get
            {
                if (musicNewsRepository == null)
                { musicNewsRepository = new NewsMusicalRepository(_contextDbNews); }
                return musicNewsRepository;
            }
        }
        public NewsEventRepository eventNewsRepository;
        public NewsEventRepository EventNews
        {
            get
            {
                if (eventNewsRepository == null)
                { eventNewsRepository = new NewsEventRepository(_contextDbNews); }
                return eventNewsRepository;
            }
        }
        // --->>><<<---
        private GalleryPhotoRepository galleryPhotoRepository;
        public GalleryPhotoRepository PhotoesGallery
        {
            get
            {
                if (galleryPhotoRepository == null)
                { galleryPhotoRepository = new GalleryPhotoRepository(_contextDbNews); }
                return galleryPhotoRepository;
            }
        }
        private GalleryVideoRepository galleryVideoRepository;
        public GalleryVideoRepository VideoGallery
        {
            get
            {
                if (galleryVideoRepository == null)
                { galleryVideoRepository = new GalleryVideoRepository(_contextDbNews); }
                return galleryVideoRepository;
            }
        }
        private AlbumPhotoRepository albumPhotoRepository;
        public AlbumPhotoRepository PhotoAlbum
        {
            get
            {
                if (albumPhotoRepository == null)
                { albumPhotoRepository = new AlbumPhotoRepository(_contextDbNews); }
                return albumPhotoRepository;
            }
        }
        // --->>><<<---


        public void Save() { _contextDbNews.SaveChanges(); }
        private bool disposed = false;
        public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed){
                if (disposing){
                    _contextDbNews.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}
