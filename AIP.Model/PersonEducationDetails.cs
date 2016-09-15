using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Model
{
    public class PersonEducationDetails
    {
        public long PersonEducationDetailID { get; set; }
        public EducationLevel Level { get; set; }
        public string MajorField { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public double ScorePercentage { get; set; }

        public PersonEducationDetails()
        {
            PersonEducationDetailID = new long();
        }

    }
}
