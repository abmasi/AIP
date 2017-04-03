using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.Model;
using AIP.DATA.Infrastructure;

namespace AIP.DATA.Repositories
{
    public class PersonMongoRepository : MongoRepositoryBase<Person>, IPersonMongoRepository
    {

        public PersonMongoRepository() : base("person")
        {

        }

        public ExitEntryDetails GetFirstAdmissionDetails(string id)
        {
            return GetPersonAddmissionDetails(id).OrderBy(p => p.Date).FirstOrDefault();
        }

        public Address GetLatestAddress(string id)
        {
            return GetPersonAddress(id).OrderByDescending(p => p.Id).FirstOrDefault();
        }

        public ExitEntryDetails GetLatestAdmissionDetails(string id)
        {
            return GetPersonAddmissionDetails(id).OrderBy(p => p.Date).LastOrDefault();
        }

        public EmploymentDetails GetLatestEmploymentDetails(string id)
        {
            return GetPersonEmploymentDetails(id).OrderByDescending(p => p.StartDate).FirstOrDefault();
        }

        public PersonStatus GetLatestStatus(string id)
        {
            return GetPersonStatus(id).OrderByDescending(p => p.ApprovalDate).FirstOrDefault();
        }

        public IEnumerable<ExitEntryDetails> GetPersonAddmissionDetails(string id)
        {
            return GetPerson(id).AddmissionDetails;
        }

        public IEnumerable<Address> GetPersonAddress(string id)
        {
            return GetPerson(id).PersonAddress;
        }

        public IEnumerable<EmploymentDetails> GetPersonEmploymentDetails(string id)
        {
            return GetPerson(id).Employment;
        }

        public IEnumerable<PersonStatus> GetPersonStatus(string id)
        {
            return GetPerson(id).Status;
        }

        private Person GetPerson(string Id)
        {
            return base.GetById(Id);
        }

       
    }
}
