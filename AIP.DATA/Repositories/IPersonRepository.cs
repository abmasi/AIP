using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.DATA.Infrastructure;
using AIP.Model;

namespace AIP.DATA.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        IEnumerable<Address> GetPersonAddress(string id);
        IEnumerable<PersonStatus> GetPersonStatus(string id);
        IEnumerable<EmploymentDetails> GetPersonEmploymentDetails(string id);
        IEnumerable<ExitEntryDetails> GetPersonAddmissionDetails(string id);

        ExitEntryDetails GetLatestAdmissionDetails(string id);
        ExitEntryDetails GetFirstAdmissionDetails(string id);
        Address GetLatestAddress(string id);
        EmploymentDetails GetLatestEmploymentDetails(string id);
        PersonStatus GetLatestStatus(string id);
    }
}
