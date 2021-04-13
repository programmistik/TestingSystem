using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingSystem.Models;
using TestingSystem.Services;

namespace TestingSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ResultsController : Controller
    {
        private readonly MongoDbService _mongoDbService;

        public ResultsController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }
        public IActionResult Index()
        {
            var testList = _mongoDbService.GetAllTests();
            if (testList == null)
                testList = new List<OurTest>();

            return View(testList);
        }

        public IActionResult Results(string id)
        {
            

            return View();
        }
    }
}
