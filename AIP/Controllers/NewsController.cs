using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AIP.ViewModel;
using AIP.Service;
using AIP.Model;

namespace AIP.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService newService;

        public NewsController(INewsService newsService)
        {
            this.newService = newsService;
        }

        // GET: News
        public ActionResult Index()
        {
            IEnumerable<NewsViewModel> viewModelNews;
            IEnumerable<News> news = newService.GetLatestNews();

            viewModelNews = AutoMapper.Mapper.Map<IEnumerable<News>, IEnumerable<NewsViewModel>>(news);

            return View(viewModelNews);
        }
    }
}