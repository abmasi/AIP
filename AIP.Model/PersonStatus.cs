using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Model
{
    public class PersonStatus
    {
        public long PersonStatusId { get; set; }
        public string VisaStatus { get; set; }
        public DateTime ApprovalDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string AlientNumber { get; set; }
        public string VisaNumber { get; set; }
        // I-94 number
        public string PortingEntryId { get; set; }
    }
}
