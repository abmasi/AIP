using System.Collections.Generic;
using AIP.Model;

namespace AIP.Service
{
    public interface IPersonService
    {
        Person GetPerson(string Personid);

        void CreatePerson(Person person);

        void SavePerson();

        void AddAddress(string Personid, Address address);
        void AddAddmission(string Personid, ExitEntryDetails addmission);
        void AddEducation(string Personid, PersonEducationDetails edutcationlevel);
        void AddStatus(string Personid, PersonStatus status);
        void AddEmployment(string Personid, EmploymentDetails employment);
        

        IEnumerable<Address> GetAllAddress(string Personid);
        Address GetPersonLatestAddress(string Personid);
        Address GetPersonAddress(long id);

        IEnumerable<ExitEntryDetails> GetAllAddmissionDetails(string Personid);
        ExitEntryDetails GetLastestAddmissionDetails(string Personid);
        ExitEntryDetails GetAddmissionDetails(long id);

        IEnumerable<PersonEducationDetails> GetAllEducationDetails(string Personid);
        PersonEducationDetails GetEducationDetails(long id);
        PersonEducationDetails GetHighestEducationDetails(string Personid);

        IEnumerable<PersonStatus> GetPersonAllVisaStatuses(string PersonId);
        PersonStatus GetPersonStatus(long id);
        PersonStatus GetPersonLatestStatus(string PersonId);

        IEnumerable<EmploymentDetails> GetPersonAllEmployments(string PersonId);
        EmploymentDetails GetEmploymentDetails(long id);
        EmploymentDetails GetLatestEmploymentDetails(string PersonId);

    }
}
