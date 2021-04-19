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
            var test = _mongoDbService.GetTestById(id);
            var list = new List<Result>();

            for (int i = 2; i <= 6; i++)
            {
                int count0 = 0;

                var res = new Result();
                var cat = (Category)i;
                res.category = cat;
                int Val = 0;
                if (i == 2)
                { Val = 6; res.Goal = 70; }
                else if (i == 3)
                { Val = 16; res.Goal = 85; }
                else if (i == 4)
                { Val = 41; res.Goal = 75; }
                else if (i == 5)
                { Val = 30; res.Goal = 95; }
                else if (i == 6)
                { Val = 19; res.Goal = 85; }


                var qs = test.Test.Questions.Where(c => c.category == cat).ToList();
                foreach (var item in qs)
                {
                    var ans = test.Answers.Where(a => a.QuestionId.Equals(item.id)).FirstOrDefault();
                    if (ans != null)
                    {
                        if (ans.TestIndex == 1)
                            res.Level1++;
                        else if (ans.TestIndex == 2)
                            res.Level2++;
                        else if (ans.TestIndex == 3)
                            res.Level3++;
                        else if (ans.TestIndex == 4)
                            res.Level4++;
                        else if (ans.TestIndex == 5)
                            res.Level5++;
                        else if (ans.TestIndex == 0)
                            count0++;
                    }
                }
                var ss = res.Level1 * 0.2 + res.Level2 * 0.4 + res.Level3 * 0.6 + res.Level4 * 0.8 + res.Level5;
                res.Overall = Convert.ToInt32(ss / (Val - count0) * 100);

                list.Add(res);

            }


            return View(list);
        }
        public IActionResult ViewAnswers(string id)
        {
            var test = _mongoDbService.GetTestById(id);
            var QAList = new List<QAModel>();

            var qlist = test.Test.Questions;

            foreach (var item in qlist)
            {
                var ans = test.Answers.Where(a => a.QuestionId.Equals(item.id)).FirstOrDefault();
                if (ans == null)
                {
                    ans = new Answer();
                    ans.AnswerList = new List<string>() { "","","","","","","","","" };
                }
                var qa = new QAModel()
                {
                    Question = item,
                    Answer = ans
                };

                QAList.Add(qa);

            }

            return View(QAList);
        }
    }
}
