using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Model
{
    public class EmploymentDetails : IEntity
    {
        public string Id { get; set; }
        public long EmploymentDetailId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EmployerName { get; set; }
        public string EmployerDetails { get; set;}
        public string PersonId { get; set; }
    }
}
