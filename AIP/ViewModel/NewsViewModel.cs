using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AIP.ViewModel
{
    public class NewsViewModel
    {
        [Key]
        public string NewsId { get; }
      
        [Required]
        [StringLength(maximumLength:100, ErrorMessage ="Length should not exceed 100 characters")]
        public string Header { get; }
        public string ShortDescription { get; }
    }

    public class NewsDetailViewModel
    {
        [Key]
        public string NewsId { get; }
        public string Header { get; }
        public string Details { get; }
    }
}