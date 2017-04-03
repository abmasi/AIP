using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Model
{
    public class PersonEducationDetails : IEntity
    {

        public long PersonEducationDetailID { get; set; }
        public EducationLevel Level { get; set; }
        public string MajorField { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public double ScorePercentage { get; set; }
        public string PersonId { get; set; }

        public string Id
        {
            get; set;
        }

        public PersonEducationDetails()
        {
            PersonEducationDetailID = new long();
        }

    }
}
