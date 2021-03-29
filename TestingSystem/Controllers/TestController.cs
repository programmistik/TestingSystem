using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingSystem.Models;
using TestingSystem.Services;
using TestingSystem.ViewModel;

namespace TestingSystem.Controllers
{
    public class TestController : Controller
    {
        private readonly MongoDbService _mongoDbService;

        public TestController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        public IActionResult Index()
        {
            var test = _mongoDbService.GetTestModel();
            if (test == null)
                return View();
            else
            {
               
                var list = new List<Question>();
                foreach (var q in test.Questions)
                {
                    if (q.category == Category.BriefInfo)
                    {
                        list.Add(q);
                    }
                }

                var mod = new QuestionAnswer(list);                

                return View(mod);
            }
               
        }

        public IActionResult Test(int spage = 1)
        {
            var page = spage;
            int pageSize = 1;   // количество элементов на странице

            var test = _mongoDbService.GetTestModel();
            if (test == null)
                return View();
            else
            {
                var list = new List<Question>();
                foreach (var q in test.Questions)
                {
                    if (q.category != Category.BriefInfo)
                    {
                        
                        list.Add(q);
                    }
                }
                var count = list.Count();
                var items = list.Skip((page - 1) * pageSize).Take(pageSize).ToList();

                PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);

                IndexViewModel viewModel = new IndexViewModel
                {
                    PageViewModel = pageViewModel,
                    questions = items
                };
                return View(viewModel);
            }
        }


        [HttpPost]
        public IActionResult CreateTest(QuestionAnswer ans)
        {                

            if (ModelState.IsValid)
            {
                var test = new OurTest();
                test.id = Guid.NewGuid().ToString();
                test.StartDate = DateTime.Now;
                test.UserName = User.Identity.Name;
                test.Test = _mongoDbService.GetTestModel();

                test.Answers = new List<Answer>();
                var tm = test.Test.Questions.Where(c => c.category == Category.BriefInfo).ToList();

                foreach (var item in tm)
                {
                    var a = ans.GetType().GetProperty("answer" + tm.IndexOf(item)).GetGetMethod().Invoke(ans, null).ToString();

                    if (!string.IsNullOrWhiteSpace(a))
                    {
                        var answer = new Answer()
                        {
                            date = DateTime.Now,
                            id = Guid.NewGuid().ToString(),
                            QuestionId = item.id,
                            UserId = User.Identity.Name,
                            answer = a
                        };

                        test.Answers.Add(answer);
                    }
                }

                _mongoDbService.CreateTest(test);

                return RedirectToAction("Test");
            }

            var tt = _mongoDbService.GetTestModel().Questions.Where(q => q.category == Category.BriefInfo).ToList();

            ans.Questions = tt;

            return View("Index", ans);
        }

    }

}
