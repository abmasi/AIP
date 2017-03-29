using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Model
{
    public class Activity
    {
        [Key]
        public string ActivityId { get; set; }
        public string ActivityDetails { get; set; }
    }
}
