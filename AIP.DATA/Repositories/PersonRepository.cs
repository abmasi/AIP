using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public IEnumerable<ExitEntryDetails> GetPersonAddmissionDetails(string id)
        {
            return base.GetById(id).AddmissionDetails.ToList();
        }


        public ExitEntryDetails GetLatestAdmissionDetails(string id)
        {
            return base.GetById(id).AddmissionDetails.OrderByDescending(x => x.Date).FirstOrDefault();
        }

        public ExitEntryDetails GetFirstAdmissionDetails(string id)
        {
            return base.GetById(id).AddmissionDetails.OrderBy(x => x.Date).FirstOrDefault();
        }

        public IEnumerable<Address> GetPersonAddress(string id)
        {
            return base.GetById(id).PersonAddress.ToList();
        }

        public Address GetLatestAddress(string id)
        {
            return base.GetById(id).PersonAddress.OrderByDescending(x => x.AddressId).FirstOrDefault();
        }

        public IEnumerable<EmploymentDetails> GetPersonEmploymentDetails(string id)
        {
            return base.GetById(id).Employment.ToList();
        }

        public EmploymentDetails GetLatestEmploymentDetails(string id)
        {
            var obj = base.GetById(id).Employment.Where(x => x.EndDate == null).FirstOrDefault();

            if (obj == null)
            {
                obj = base.GetById(id).Employment.OrderByDescending(x => x.EndDate).FirstOrDefault();
            }

            return obj;
        }

        public IEnumerable<PersonStatus> GetPersonStatus(string id)
        {
            return base.GetById(id).Status.ToList();
        }

        public PersonStatus GetLatestStatus(string id)
        {
            return base.GetById(id).Status.OrderByDescending(x => x.ApprovalDate).FirstOrDefault();
        }

        public bool Exists(Expression<Func<Person, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IDisposable RequestStart()
        {
            throw new NotImplementedException();
        }

        public void RequestDone()
        {
            throw new NotImplementedException();
        }

        public void Delete(string Id)
        {
            base.Delete(this.GetById(Id));
        }
    }
}
