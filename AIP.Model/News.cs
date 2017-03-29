using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Model
{
    public class News
    {
        [Key]
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
