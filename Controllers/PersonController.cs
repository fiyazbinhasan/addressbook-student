using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBookMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddressBookMVC.Controllers
{
    public class PersonController : Controller
    {
        private static List<PersonViewModel> _people;
        public PersonController()
        {
            _people = new List<PersonViewModel>();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(_people);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("FirstName,LastName,Address")] PersonViewModel person)
        {
            _people.Add(person);
            
            return View("List", _people);
        }
    }
}