using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.Model;
using AIP.DATA.Infrastructure;
using AIP.DATA.Repositories;

namespace AIP.Service
{
    public class PersonService : IPersonService
    {
        public void AddAddmission(int Personid, ExitEntryDetails addmission)
        {
            throw new NotImplementedException();
        }

        public void AddAddress(int Personid, Address address)
        {
            throw new NotImplementedException();
        }

        public void AddEducation(int Personid, PersonEducationDetails edutcationlevel)
        {
            throw new NotImplementedException();
        }

        public void AddEmployment(int Personid, EmploymentDetails employment)
        {
            throw new NotImplementedException();
        }

        public void AddStatus(int Personid, PersonStatus status)
        {
            throw new NotImplementedException();
        }

        public void CreatePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public ExitEntryDetails GetAddmissionDetails(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExitEntryDetails> GetAllAddmissionDetails(int Personid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAllAddress(int Personid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonEducationDetails> GetAllEducationDetails(int Personid)
        {
            throw new NotImplementedException();
        }

        public PersonEducationDetails GetEducationDetails(long id)
        {
            throw new NotImplementedException();
        }

        public EmploymentDetails GetEmploymentDetails(long id)
        {
            throw new NotImplementedException();
        }

        public PersonEducationDetails GetHighestEducationDetails(int Personid)
        {
            throw new NotImplementedException();
        }

        public ExitEntryDetails GetLastestAddmissionDetails(int Personid)
        {
            throw new NotImplementedException();
        }

        public EmploymentDetails GetLatestEmploymentDetails(int PersonId)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int Personid)
        {
            throw new NotImplementedException();
        }

        public Address GetPersonAddress(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmploymentDetails> GetPersonAllEmployments(int PersonId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonStatus> GetPersonAllVisaStatuses(int PersonId)
        {
            throw new NotImplementedException();
        }

        public Address GetPersonLatestAddress(int Personid)
        {
            throw new NotImplementedException();
        }

        public PersonStatus GetPersonLatestStatus(int PersonId)
        {
            throw new NotImplementedException();
        }

        public PersonStatus GetPersonStatus(long id)
        {
            throw new NotImplementedException();
        }

        public void SavePerson()
        {
            throw new NotImplementedException();
        }
    }
}
