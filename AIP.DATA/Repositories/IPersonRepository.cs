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
        IEnumerable<Address> GetPersonAddress(int id);
        IEnumerable<PersonStatus> GetPersonStatus(int id);
        IEnumerable<EmploymentDetails> GetPersonEmploymentDetails(int id);
        IEnumerable<ExitEntryDetails> GetPersonAddmissionDetails(int id);

        ExitEntryDetails GetLatestAdmissionDetails(int id);
        ExitEntryDetails GetFirstAdmissionDetails(int id);
        Address GetLatestAddress(int id);
        EmploymentDetails GetLatestEmploymentDetails(int id);
        PersonStatus GetLatestStatus(int id);
    }
}
