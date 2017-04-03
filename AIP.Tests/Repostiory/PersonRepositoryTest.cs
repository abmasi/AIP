using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.DATA.Repositories;
using AIP.DATA.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AIP.Tests.Repostiory
{
    public class PersonRepositoryTest
    {
        [TestMethod]
        public void CreatePerson()
        {
            IPersonMongoRepository repository = new PersonMongoRepository();

            repository.Add(new Model.Person
            {
                FirstName = "sanjeev",
                LastName = "ranjan",
                DOB = new DateTime(1978, 3, 1),
                EmailID = "sranjan@gmail.com",
                Gender = "Male",
                MaritalStatus = "Married",
                MiddleName = "",
                OtherName = "",
                Nationality = "India",
                PassportIssueCountry = "India",
                PassportNumber = "J1237281",
                PersonId = "1",
                PlaceOfBirth = "India",
                SSN = "201-546-0397"

            });
        }
    }
}
