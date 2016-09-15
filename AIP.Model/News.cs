using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Model
{
    public class News
    {
        public string NewsId { get; set; }
        public string Header { get; set; }
        public string ShortDescription { get; set; }
        public string Details { get; set; }
        public string PostedOn { get; set; }

        public News()
        {
            NewsId = new Guid().ToString();
        }
    }
}
