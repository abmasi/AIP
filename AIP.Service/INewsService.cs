﻿using AIP.Model;
using System.Collections.Generic;

namespace AIP.Service
{
    public interface INewsService
    {
        IEnumerable<News> GetAllNews();
        IEnumerable<News> GetLatestNews();

        News GetNews(int id);

        void CreateNews(News news);

        void SaveNews();
    }
}
