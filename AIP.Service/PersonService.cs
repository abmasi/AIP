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

        public void AddAddmission(int Personid, ExitEntryDetails addmission)
        {
            GetPerson(Personid).AddmissionDetails.Add(addmission);
        }

        public void AddAddress(int Personid, Address address)
        {
            GetPerson(Personid).PersonAddress.Add(address); ;
        }

        public void AddEducation(int Personid, PersonEducationDetails edutcationlevel)
        {
            GetPerson(Personid).EducationDetails.Add(edutcationlevel);
        }

        public void AddEmployment(int Personid, EmploymentDetails employment)
        {
            GetPerson(Personid).Employment.Add(employment);
        }

        public void AddStatus(int Personid, PersonStatus status)
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

        public IEnumerable<ExitEntryDetails> GetAllAddmissionDetails(int Personid)
        {
            return GetPerson(Personid).AddmissionDetails; 
        }

        public IEnumerable<Address> GetAllAddress(int Personid)
        {
            return GetPerson(Personid).PersonAddress;
        }

        public IEnumerable<PersonEducationDetails> GetAllEducationDetails(int Personid)
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

        public PersonEducationDetails GetHighestEducationDetails(int Personid)
        {
            return GetPerson(Personid).EducationDetails.LastOrDefault();
        }

        public ExitEntryDetails GetLastestAddmissionDetails(int Personid)
        {
            return GetPerson(Personid).AddmissionDetails.LastOrDefault();
        }

        public EmploymentDetails GetLatestEmploymentDetails(int PersonId)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int Personid)
        {
            return _personRepository.GetById(Personid);
        }

        public Address GetPersonAddress(long id)
        {
            return null; // _personRepository.GetById(id).PersonAddress.Where(p => p.AddressId == id).FirstOrDefault();
        }

        public IEnumerable<EmploymentDetails> GetPersonAllEmployments(int PersonId)
        {
            return GetPerson(PersonId).Employment;
        }

        public IEnumerable<PersonStatus> GetPersonAllVisaStatuses(int PersonId)
        {
            return GetPerson(PersonId).Status;
        }

        public Address GetPersonLatestAddress(int Personid)
        {
            return GetPerson(Personid).PersonAddress.LastOrDefault();
        }

        public PersonStatus GetPersonLatestStatus(int PersonId)
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
