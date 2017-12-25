using GKIbyAkhremchik.DAL.Context;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GKIbyAkhremchik.DAL.Repositories
{
    public class NewsSchoolRepository : INewsContext<NewsSchool>
    {
        //access to the data base
        internal GKIDbContext _contextDbNews;
        public NewsSchoolRepository(GKIDbContext contextDbNews)
        {
            _contextDbNews = contextDbNews;
        }

        public IQueryable<NewsSchool> GetSchool()
        {
            return _contextDbNews.SchoolNews;
        }

        //create the news list from the table [NewsSchool]
        public IEnumerable<NewsSchool> GetAllNews()
        {
            return _contextDbNews.SchoolNews;
        }
        //find news by ID
        public NewsSchool GetNewsById(int id)
        {
            return _contextDbNews.SchoolNews.Find(id);
        }
        //upload news
        public void AddNews(NewsSchool insertNews)
        {
            _contextDbNews.SchoolNews.Add(insertNews);
        }
        //update information
        public void UpdateNews(NewsSchool updateNews)
        {
            _contextDbNews.Entry(updateNews).State = EntityState.Modified;
        }
        //find news by ID and delete it
        public void DeleteNews(int id)
        {
            NewsSchool news = _contextDbNews.SchoolNews.Find(id);
            if(news != null) {
                _contextDbNews.SchoolNews.Remove(news);
            }
        }

        //save changes to the database
        public void Save()
        {
            _contextDbNews.SaveChanges();
        }
    }
}
