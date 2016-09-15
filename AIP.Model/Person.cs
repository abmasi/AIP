using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Model
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime DOB { get; set; }
        public string PlaceOfBirth { get; set; }
        public string SSN { get; set; }
        public string EmailID { get; set; }
        public string Nationality { get; set; }
        public string PassportNumber { get; set; }
        public string PassportIssueCountry { get; set; }
        public virtual List<Address> PersonAddress { get; set; }
        public virtual List<PersonStatus> Status { get; set; }
        public virtual List<EmploymentDetails> Employment { get; set; }
        public virtual List<ExitEntryDetails> AddmissionDetails { get; set; }

        public override string ToString()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }
    }
}
