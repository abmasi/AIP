using System.Collections.Generic;
using AIP.Model;

namespace AIP.Service
{
    public interface IPersonService
    {
        Person GetPerson(int Personid);

        void CreatePerson(Person person);

        void SavePerson();

        void AddAddress(int Personid, Address address);
        void AddAddmission(int Personid, ExitEntryDetails addmission);
        void AddEducation(int Personid, PersonEducationDetails edutcationlevel);
        void AddStatus(int Personid, PersonStatus status);
        void AddEmployment(int Personid, EmploymentDetails employment);
        

        IEnumerable<Address> GetAllAddress(int Personid);
        Address GetPersonLatestAddress(int Personid);
        Address GetPersonAddress(long id);

        IEnumerable<ExitEntryDetails> GetAllAddmissionDetails(int Personid);
        ExitEntryDetails GetLastestAddmissionDetails(int Personid);
        ExitEntryDetails GetAddmissionDetails(long id);

        IEnumerable<PersonEducationDetails> GetAllEducationDetails(int Personid);
        PersonEducationDetails GetEducationDetails(long id);
        PersonEducationDetails GetHighestEducationDetails(int Personid);

        IEnumerable<PersonStatus> GetPersonAllVisaStatuses(int PersonId);
        PersonStatus GetPersonStatus(long id);
        PersonStatus GetPersonLatestStatus(int PersonId);

        IEnumerable<EmploymentDetails> GetPersonAllEmployments(int PersonId);
        EmploymentDetails GetEmploymentDetails(long id);
        EmploymentDetails GetLatestEmploymentDetails(int PersonId);

    }
}
