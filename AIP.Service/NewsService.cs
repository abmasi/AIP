using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.Model;
using AIP.DATA.Infrastructure;
using AIP.DATA.Repositories;
using AIP.Service;

namespace AIP.Service
{
    public class NewsService : INewsService
    {
        private readonly RepositoryBase<News> _newsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public NewsService(IDbFactory dbFactory)
        {
            _newsRepository = new NewsRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }

        public void CreateNews(News news)
        {
            _newsRepository.Add(news);
            _unitOfWork.Commit();
        }

        public IEnumerable<News> GetAllNews()
        {
            return _newsRepository.GetAll();
        }

        public IEnumerable<News> GetLatestNews()
        {
            return _newsRepository.GetAll().OrderByDescending(x => x.PostedOn).Take(5);
        }

        public News GetNews(int id)
        {
            return _newsRepository.GetById(id);
        }

        public void SaveNews()
        {
            _unitOfWork.Commit();
        }
    }
}
