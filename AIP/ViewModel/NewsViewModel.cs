using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIP.ViewModel
{
    public class NewsViewModel
    {
        public string NewsId { get; }
        public string Header { get; }
        public string ShortDescription { get; }
    }

    public class NewsDetailViewModel
    {
        public string NewsId { get; }
        public string Header { get; }
        public string Details { get; }
    }
}