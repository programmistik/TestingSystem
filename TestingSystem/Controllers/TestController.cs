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
        private OurTest our_test = new OurTest();

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
                our_test.Test = test;
                var list = new List<QuestionAnswer>();
                foreach (var q in test.Questions)
                {
                    if (q.category == Category.BriefInfo)
                    {
                        var qa = new QuestionAnswer
                        {
                            question = q,
                            answer = new Answer
                            {
                                date = DateTime.Now,
                                id = Guid.NewGuid().ToString(),
                                QuestionId = q.id,
                                UserId = User.Identity.Name,
                                answer = ""
                            }
                        };
                        list.Add(qa);
                    }
                }
                

                return View(list);
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
                var list = new List<QuestionAnswer>();
                foreach (var q in test.Questions)
                {
                    if (q.category != Category.BriefInfo)
                    {
                        var qa = new QuestionAnswer
                        {
                            question = q,
                            answer = new Answer
                            {
                                date = DateTime.Now,
                                id = Guid.NewGuid().ToString(),
                                QuestionId = q.id,
                                UserId = User.Identity.Name,
                                answer = ""
                            }
                        };
                        list.Add(qa);
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
        public IActionResult CreateTest(AnswerListHelper ans)
        {
            our_test.StartDate = DateTime.Now;
            our_test.UserName = User.Identity.Name;
            our_test.Answers = new List<Answer>();
            return RedirectToAction("Index");

        }

    }

}
