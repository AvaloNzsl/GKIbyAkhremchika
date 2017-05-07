using System.Collections.Generic;
using System.Linq;

namespace GKIbyAkhremchik.DAL.Context
{
    public class NewsContext : INewsContext
    {
        private GKIDbContext _contextDbNews;
        public NewsContext()
        {
            _contextDbNews = new GKIDbContext();
        }
        public NewsContext(GKIDbContext contextDbNews)
        {
            _contextDbNews = contextDbNews;
        }

        public void AddNews(NewsSchool news)
        {
            _contextDbNews.SchoolNews.Add(news);
            _contextDbNews.SaveChanges();
        }

        public void DeleteNews(int id)
        {
            NewsSchool news = _contextDbNews.SchoolNews.Find(id);//first method   
            //second method
            //var news = (from n in _contextDbNews.NewsSchool
            //            where n.NewsSchoolId == id
            //            select n).First();

            if (news != null)
            {
                _contextDbNews.SchoolNews.Remove(news);
                _contextDbNews.SaveChanges();
            }
        }

        public IEnumerable<NewsSchool> GetAllNewsSchool()
        {
            return _contextDbNews.SchoolNews.ToList();
        }
    }
}
