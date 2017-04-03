using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AIP.DATA.Infrastructure;
using AIP.DATA.Repositories;
using AIP.ViewModel;
using MongoDB.Bson;

namespace AIP.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonMongoRepository _personRepository;

        public PersonController(IPersonMongoRepository repository)
        {
            _personRepository = repository;
            CreatePerson();
        }

        // GET: Person
        public ActionResult Index()
        {
            IEnumerable<Model.Person> persons = _personRepository.GetAll();
            return View();
        }

        public void CreatePerson()
        {
            _personRepository.Add(new Model.Person {
                Id = new ObjectId().ToString(),
                FirstName = "Sanjeev" , 
                LastName = "Ranjan", 
                Nationality = "India"
            });
        }



        public ActionResult Create()
        {
            PersonViewModel model = new PersonViewModel();
            return View(model);
        }
    }
}