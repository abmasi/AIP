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
        private readonly RepositoryBase<Person> _personRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PersonService(IDbFactory DbFactory)
        {
            _personRepository = new PersonRepository(DbFactory);
            _unitOfWork = new UnitOfWork(DbFactory);
        }

        public void AddAddmission(string Personid, ExitEntryDetails addmission)
        {
            GetPerson(Personid).AddmissionDetails.Add(addmission);
        }

        public void AddAddress(string Personid, Address address)
        {
            GetPerson(Personid).PersonAddress.Add(address); ;
        }

        public void AddEducation(string Personid, PersonEducationDetails edutcationlevel)
        {
            GetPerson(Personid).EducationDetails.Add(edutcationlevel);
        }

        public void AddEmployment(string Personid, EmploymentDetails employment)
        {
            GetPerson(Personid).Employment.Add(employment);
        }

        public void AddStatus(string Personid, PersonStatus status)
        {
            GetPerson(Personid).Status.Add(status);
        }

        public void CreatePerson(Person person)
        {
            _personRepository.Add(person);
        }

        public ExitEntryDetails GetAddmissionDetails(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExitEntryDetails> GetAllAddmissionDetails(string Personid)
        {
            return GetPerson(Personid).AddmissionDetails; 
        }

        public IEnumerable<Address> GetAllAddress(string Personid)
        {
            return GetPerson(Personid).PersonAddress;
        }

        public IEnumerable<PersonEducationDetails> GetAllEducationDetails(string Personid)
        {
            return GetPerson(Personid).EducationDetails;
        }

        public PersonEducationDetails GetEducationDetails(long id)
        {
            throw new NotImplementedException();
        }

        public EmploymentDetails GetEmploymentDetails(long id)
        {
            throw new NotImplementedException();
        }

        public PersonEducationDetails GetHighestEducationDetails(string Personid)
        {
            return GetPerson(Personid).EducationDetails.LastOrDefault();
        }

        public ExitEntryDetails GetLastestAddmissionDetails(string Personid)
        {
            return GetPerson(Personid).AddmissionDetails.LastOrDefault();
        }

        public EmploymentDetails GetLatestEmploymentDetails(string PersonId)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(string Personid)
        {
            return _personRepository.GetById(Personid);
        }

        public Address GetPersonAddress(long id)
        {
            return null; // _personRepository.GetById(id).PersonAddress.Where(p => p.AddressId == id).FirstOrDefault();
        }

        public IEnumerable<EmploymentDetails> GetPersonAllEmployments(string PersonId)
        {
            return GetPerson(PersonId).Employment;
        }

        public IEnumerable<PersonStatus> GetPersonAllVisaStatuses(string PersonId)
        {
            return GetPerson(PersonId).Status;
        }

        public Address GetPersonLatestAddress(string Personid)
        {
            return GetPerson(Personid).PersonAddress.LastOrDefault();
        }

        public PersonStatus GetPersonLatestStatus(string PersonId)
        {
            return GetPerson(PersonId).Status.LastOrDefault();
        }

        public PersonStatus GetPersonStatus(long id)
        {
            throw new NotImplementedException();
        }

        public void SavePerson()
        {
            _unitOfWork.Commit();
        }
    }
}
