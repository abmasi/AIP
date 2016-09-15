using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.DATA.Infrastructure;
using AIP.Model;

namespace AIP.DATA.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ExitEntryDetails> GetPersonAddmissionDetails(int id)
        {
            return base.GetById(id).AddmissionDetails.ToList();
        }


        public ExitEntryDetails GetLatestAdmissionDetails(int id)
        {
            return base.GetById(id).AddmissionDetails.OrderByDescending(x => x.Date).FirstOrDefault();
        }

        public ExitEntryDetails GetFirstAdmissionDetails(int id)
        {
            return base.GetById(id).AddmissionDetails.OrderBy(x => x.Date).FirstOrDefault();
        }

        public IEnumerable<Address> GetPersonAddress(int id)
        {
            return base.GetById(id).PersonAddress.ToList();
        }

        public Address GetLatestAddress(int id)
        {
            return base.GetById(id).PersonAddress.OrderByDescending(x => x.AddressId).FirstOrDefault();
        }

        public IEnumerable<EmploymentDetails> GetPersonEmploymentDetails(int id)
        {
            return base.GetById(id).Employment.ToList();
        }

        public EmploymentDetails GetLatestEmploymentDetails(int id)
        {
            var obj = base.GetById(id).Employment.Where(x => x.EndDate == null).FirstOrDefault();

            if (obj == null)
            {
                obj = base.GetById(id).Employment.OrderByDescending(x => x.EndDate).FirstOrDefault();
            }

            return obj;
        }

        public IEnumerable<PersonStatus> GetPersonStatus(int id)
        {
            return base.GetById(id).Status.ToList();
        }

        public PersonStatus GetLatestStatus(int id)
        {
            return base.GetById(id).Status.OrderByDescending(x => x.ApprovalDate).FirstOrDefault();
        }
    }
}
