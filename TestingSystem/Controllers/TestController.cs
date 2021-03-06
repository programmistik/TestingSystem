using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            var testlist = _mongoDbService.GetActualTest(User.Identity.Name);
            if (testlist.Count == 0)
                return View("ErrorPage");
            else
            {
                var test = testlist.OrderByDescending(t => t.StartDate).First();
                var page = spage;
                int pageSize = 1;   // количество элементов на странице

               
                var list = new List<QAModel>();
                foreach (var q in test.Test.Questions)
                {
                    if (q.category != Category.BriefInfo)
                    {
                        var ans = test.Answers.Where(a => a.QuestionId == q.id).FirstOrDefault();
                        if (ans == null)
                        {
                            ans = new Answer()
                            {
                                id = Guid.NewGuid().ToString(),
                                QuestionId = q.id,
                                answer = null,
                                date = DateTime.Now,
                                UserId = User.Identity.Name
                            };
                            if (q.SubText != null)
                                ans.AnswerList = new List<string>();// { "", "", "", "", "", "", "", "", ""};
                            
                        }
                        list.Add(new QAModel() { Question = q, Answer = ans});
                    }
                }
                PageViewModel pageViewModel = new PageViewModel(list.Count, page, pageSize);
                

                var qArray = list.ToArray();
                var item = qArray[page - 1];
                IndexViewModel viewModel = new IndexViewModel();
                viewModel.PageNumber = spage;
                viewModel.OurTestId = test.id;
                viewModel.QuestionId = item.Question.id;
                viewModel.pvmCount = list.Count;
                viewModel.Title = item.Question.category.GetDescription();

                if (item.Question.SubText != null)
                {
                    viewModel.PageViewModel = pageViewModel;
                    viewModel.Question = item.Question;

                   // var ansArray = item.Answer.AnswerList.ToArray();

                    viewModel.answer0 = null; // ansArray[0];
                    viewModel.answer1 = null; // ansArray[1];
                    viewModel.answer2 = null; // ansArray[2];
                    viewModel.answer3 = null; // ansArray[3];
                    viewModel.answer4 = null; // ansArray[4];
                    viewModel.answer5 = null; // ansArray[5];
                    viewModel.answer6 = null; // ansArray[6];
                    viewModel.answer7 = null; // ansArray[7];
                    viewModel.answer8 = null; // ansArray[8];                   

                }
                else if(item.Question.Variants != null) 
                {
                    viewModel.PageViewModel = pageViewModel;
                    viewModel.Question = item.Question;
                    viewModel.RadioAnswer = item.Answer.answer; //Question.Variants[0];
                }
                else
                {
                    viewModel.PageViewModel = pageViewModel;
                    viewModel.Question = item.Question;
                    viewModel.answer0 = item.Answer.answer;
                }
                return View(viewModel);
            }
        }

        

        [HttpPost]
        public IActionResult NextTest(IndexViewModel ivm)
        {
            var question = _mongoDbService.GetQuestion(ivm.QuestionId);

            if (question.SubText != null)
            {
                if (string.IsNullOrWhiteSpace(ivm.answer0))
                    ModelState.AddModelError("answer0", "Pleace, write your answer");
                if (string.IsNullOrWhiteSpace(ivm.answer1))
                    ModelState.AddModelError("answer1", "Pleace, write your answer");
                if (string.IsNullOrWhiteSpace(ivm.answer2))
                    ModelState.AddModelError("answer2", "Pleace, write your answer");
                if (string.IsNullOrWhiteSpace(ivm.answer3))
                    ModelState.AddModelError("answer3", "Pleace, write your answer");
                if (string.IsNullOrWhiteSpace(ivm.answer4))
                    ModelState.AddModelError("answer4", "Pleace, write your answer");
                if (string.IsNullOrWhiteSpace(ivm.answer5))
                    ModelState.AddModelError("answer5", "Pleace, write your answer");
                if (string.IsNullOrWhiteSpace(ivm.answer6))
                    ModelState.AddModelError("answer6", "Pleace, write your answer");
                if (string.IsNullOrWhiteSpace(ivm.answer7))
                    ModelState.AddModelError("answer7", "Pleace, write your answer");
                if (string.IsNullOrWhiteSpace(ivm.answer8))
                    ModelState.AddModelError("answer8", "Pleace, write your answer");

            }
            if (question.Variants == null & question.SubText == null)
            {
                if (string.IsNullOrWhiteSpace(ivm.answer0))
                {
                    ModelState.AddModelError("answer0", "Pleace, write your answer");
                }
            }
           

            if (ModelState.IsValid)
            {
                var answer = new Answer()
                {
                    id = Guid.NewGuid().ToString(),
                    date = DateTime.Now,
                    UserId = User.Identity.Name,
                    QuestionId = ivm.QuestionId
                };
                if (ivm.RadioAnswer != null)
                {
                    answer.answer = ivm.RadioAnswer;
                    var quest = _mongoDbService.GetQuestion(ivm.QuestionId);
                    var ind = quest.Variants.IndexOf(ivm.RadioAnswer);
                    answer.TestIndex = ind;
                }
                else
                {
                    if (ivm.answer1 != null)
                    {
                        answer.AnswerList = new List<string>();
                        answer.AnswerList.Add(ivm.answer0);
                        answer.AnswerList.Add(ivm.answer1);
                        answer.AnswerList.Add(ivm.answer2);
                        answer.AnswerList.Add(ivm.answer3);
                        answer.AnswerList.Add(ivm.answer4);
                        answer.AnswerList.Add(ivm.answer5);
                        answer.AnswerList.Add(ivm.answer6);
                        answer.AnswerList.Add(ivm.answer7);
                        answer.AnswerList.Add(ivm.answer8);
                    }
                    else
                        answer.answer = ivm.answer0;
                }
                
                _mongoDbService.AddNewAnswer(ivm.OurTestId, answer);

                if (ivm.PageNumber == ivm.pvmCount)
                {
                    var testlist = _mongoDbService.GetActualTest(User.Identity.Name);
                    if (testlist.Count == 0)
                        return View("ErrorPage");
                    else
                    {
                        var test = testlist.OrderByDescending(t => t.StartDate).First();
                        test.FinishDate = DateTime.Now;
                        test.finished = true;
                        _mongoDbService.UpdateTest(test.id, test);
                        return RedirectToAction("Results", new { id = test.id });
                    }
                }

                return RedirectToAction("Test", new { spage = ivm.PageNumber + 1 });
            }
            else
            {
                ivm.Question = question;
                ivm.PageViewModel = new PageViewModel(ivm.pvmCount, ivm.PageNumber, 1);
                return View("Test", ivm);
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

    }

}
