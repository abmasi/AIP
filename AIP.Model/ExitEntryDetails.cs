using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Model
{
    public class ExitEntryDetails : IEntity
    {
        public string Id
        {
            get; set;
        }
        public long ExitEntryDetailId { get; set; }
        public DateTime Date { get; set; }
        public PortingType Type { get; set; }
        public string PortOfEntry { get; set; }
        public DateTime ExpiryOn { get; set; }
        public string VisaType { get; set; }
        public string PersonId { get; set; }


    }
}
