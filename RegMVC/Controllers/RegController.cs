using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegMVC.Models;
using RegMVC.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegMVC.Controllers
{
    public class RegController : Controller
    {
        private ILogger<RegController> _logger;
        private IRepo<Registration> _repo;

        public RegController(IRepo<Registration> repo,ILogger<RegController> logger)
        {
            _logger = logger;
            _repo = repo;

        }
        public IActionResult Index()
            
        {
            List<Registration> registrations = _repo.GetAll().ToList();
            return View(registrations);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
       public IActionResult Create(Registration registration)
        {
            _repo.Add(registration);
            return RedirectToAction("Index");
        }
    }
}
