using System;
using System.Collections.Generic;
using GKIbyAkhremchik.ViewModel.NewsModels;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using GKIbyAkhremchik.DAL;
using System.Linq;
using GKIbyAkhremchik.ViewModel.Gallery;

namespace GKIbyAkhremchik.BL.News
{
    public class NewsService : INewsService
    {
        private UnitNewsServices _contextUnit;
        public NewsService(UnitNewsServices contextUnit)
        {
            _contextUnit = contextUnit;
        }

        public IQueryable<NewsModel> GetSchool()
        {
            var news = new List<NewsModel>();
            var school = _contextUnit.SchoolNews.GetSchool();
            foreach (var n in school)
            {
                news.Add(new NewsModel
                {
                    NewsId = n.NewsSchoolId,
                    Title = n.Title,
                    Img_Title = n.Img_Title,
                    Date = n.Date,
                    SmallText = n.SmallText,
                    FullText = n.FullText
                });
            }
            return news.AsQueryable()/*.Include(n => n.GalleryVideo).Include(n => n.GalleryPhoto)*/;
        }

        public IEnumerable<NewsModel> GetAll(string nameNews)
        {
            var news = new List<NewsModel>();

            if (nameNews == "school")
            {
                var school = _contextUnit.SchoolNews.GetAllNews();
                foreach (var n in school)
                {
                    //int galleryVideoId = 0;
                    //if (n.GalleryVideoId.HasValue)
                    //    galleryVideoId = n.GalleryVideoId.Value;
                    ////if (_gallery.)
                    var video = _contextUnit.VideoGallery.GetGalleryById(1);
                    var photo = _contextUnit.PhotoesGallery.GetGalleryById(1);
                    //var gallery = _contextUnit.VideoGallery.GetGalleryById();

                    var vi = new GalleryVideoModel { Title = video.Title };
                    var pho = new GalleryPhotoModel { Title = photo.Title };
                    news.Add(new NewsModel
                    {
                        NewsId = n.NewsSchoolId,
                        Title = n.Title,
                        Img_Title = n.Img_Title,
                        Date = n.Date,
                        SmallText = n.SmallText,
                        FullText = n.FullText,
                        GalleryVideoId = n.GalleryVideoId,
                        GalleryPhoto = pho,
                        GalleryVideo = vi
                    });
                }
            }
            if (nameNews == "art")
            {
                var art = _contextUnit.ArtNews.GetAllNews();
                foreach (var n in art)
                {
                    news.Add(new NewsModel
                    {
                        NewsId = n.NewsArtId,
                        Title = n.Title,
                        Img_Title = n.Img_Title,
                        Date = n.Date,
                        SmallText = n.SmallText,
                        FullText = n.FullText,
                        GalleryPhotoId = n.GalleryPhotoId,
                        GalleryVideoId = n.GalleryVideoId
                    });
                }
            }
            if (nameNews == "musical")
            {
                var musical = _contextUnit.MusicNews.GetAllNews();
                foreach (var n in musical)
                {
                    news.Add(new NewsModel
                    {
                        NewsId = n.NewsMusicalId,
                        Title = n.Title,
                        Img_Title = n.Img_Title,
                        Date = n.Date,
                        SmallText = n.SmallText,
                        FullText = n.FullText,
                        GalleryPhotoId = n.GalleryPhotoId,
                        GalleryVideoId = n.GalleryVideoId
                    });
                }
            }

            //else HttpNotFount();
            return news;
        }
        public IEnumerable<NewsEventModel> GetEvent()
        {
            var news = new List<NewsEventModel>();
            var nEvent = _contextUnit.EventNews.GetAllNews();
            foreach (var n in nEvent)
            {
                news.Add(new NewsEventModel
                {
                    NewsEventId = n.NewsEventId,
                    Title = n.Title,
                    Img = n.Img,
                    DateStart = n.DateStart,
                    DateFinish = n.DateFinish,
                    Description = n.Description,
                    FullText = n.FullText,
                    GalleryPhotoId = n.GalleryPhotoId,
                    GalleryVideoId = n.GalleryVideoId
                });
            }
            return news;
        }

        public void AddNews(NewsView insert, string nameDepart)
        {
            GalleryPhoto gp = new GalleryPhoto { Title = insert.Title };
            //var gv = new SelectList(_contextUnit., "GalleryVideoId", "Title", insert.GalleryVideoId);
            if (nameDepart == "school")
            {
                NewsSchool news = new NewsSchool
                {
                    Title = insert.Title,
                    Img_Title = insert.Img_Title,
                    Date = insert.Date,
                    SmallText = insert.SmallText,
                    FullText = insert.FullText
                    //GalleryVideo = gv
                };
                _contextUnit.SchoolNews.AddNews(news);
            }
            if (nameDepart == "art")
            {
                NewsArt news = new NewsArt
                {
                    Title = insert.Title,
                    Img_Title = insert.Img_Title,
                    Date = insert.Date,
                    SmallText = insert.SmallText,
                    FullText = insert.FullText,
                    GalleryPhotoId = insert.GalleryPhotoId,
                    GalleryVideoId = insert.GalleryVideoId
                };
                _contextUnit.ArtNews.AddNews(news);
            }
            if (nameDepart == "musical")
            {
                NewsMusical news = new NewsMusical
                {
                    Title = insert.Title,
                    Img_Title = insert.Img_Title,
                    Date = insert.Date,
                    SmallText = insert.SmallText,
                    FullText = insert.FullText,
                    GalleryPhotoId = insert.GalleryPhotoId,
                    GalleryVideoId = insert.GalleryVideoId
                };
                _contextUnit.MusicNews.AddNews(news);
            }
        }
        public void AddEvent(NewsEventView insert)
        {
            NewsEvent news = new NewsEvent
            {
                Title = insert.Title,
                Img = insert.Img,
                DateStart = insert.DateStart,
                DateFinish = insert.DateFinish,
                Description = insert.Description,
                FullText = insert.FullText,
                GalleryPhotoId = insert.GalleryPhotoId,
                GalleryVideoId = insert.GalleryVideoId
            };
            _contextUnit.EventNews.AddNews(news);
        }

        public NewsSchool GetNewsSchoolById(int id)
        {
            return _contextUnit.SchoolNews.GetNewsById(id);
        }
        public void UpdateNews(NewsSchool update)
        {
            _contextUnit.SchoolNews.UpdateNews(update);
        }

        public NewsArt GetNewsArtById(int id)
        {
            return _contextUnit.ArtNews.GetNewsById(id);
        }
        public void UpdateNews(NewsArt update)
        {
            _contextUnit.ArtNews.UpdateNews(update);
        }

        public NewsMusical GetNewsMusicalById(int id)
        {
            return _contextUnit.MusicNews.GetNewsById(id);
        }
        public void UpdateNews(NewsMusical update)
        {
            _contextUnit.MusicNews.UpdateNews(update);
        }

        public NewsEvent GetNewsEventById(int id)
        {
            return _contextUnit.EventNews.GetNewsById(id);
        }
        public void UpdateNews(NewsEvent update)
        {
            _contextUnit.EventNews.UpdateNews(update);
        }

        public void DeleteNews(int id, string nameDepart)
        {
            if (nameDepart == "school") _contextUnit.SchoolNews.DeleteNews(id);
            if (nameDepart == "art") _contextUnit.ArtNews.DeleteNews(id);
            if (nameDepart == "musical") _contextUnit.MusicNews.DeleteNews(id);
            if (nameDepart == "event") _contextUnit.EventNews.DeleteNews(id);
        }

        public void Save() { _contextUnit.Save(); }
    }
}
