﻿using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.DAL.Repositories;
using System;

namespace GKIbyAkhremchik.BL.News
{
    public class UnitNewsServices : IDisposable //pattern unit of work
    {
        private GKIDbContext _contextDbNews = new GKIDbContext();
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
        //private NewsGenericRepository<NewsMusical> musicNewsRepository;
        //private NewsGenericRepository<NewsMusical> MusicNewsRepository
        //{
        //    get
        //    {
        //        if (musicNewsRepository == null)
        //        { musicNewsRepository = new NewsGenericRepository<NewsMusical>(_contextDbNews); }
        //        return musicNewsRepository;
        //    }
        //}


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