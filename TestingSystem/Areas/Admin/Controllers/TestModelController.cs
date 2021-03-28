using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingSystem.Areas.Admin.DataService;
using TestingSystem.Models;
using TestingSystem.Services;

namespace TestingSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TestModelController : Controller
    {
        private readonly MongoDbService _mongoDbService;

        public TestModelController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        // GET: TestModel
        public ActionResult Index()
        {
            var testList = new List<TestModel>();
            var test = _mongoDbService.GetTestModel();
            if (test != null)
                testList.Add(test);

            return View(testList);
        }

        // GET: TestModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestModel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TestModel tm)
        {

            if (ModelState.IsValid)
            {
                DataCreation.CreateAllData(tm);

                _mongoDbService.Create(tm);
                return RedirectToAction(nameof(Index));
            }
            return View(tm);
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: TestModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestModel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //// GET: TestModel/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: TestModel/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
