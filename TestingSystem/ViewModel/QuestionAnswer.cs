using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingSystem.Models;

namespace TestingSystem.ViewModel
{
    public class QuestionAnswer
    {
        public Question question { get; set; }
        public Answer answer { get; set; }
    }

    public class QuestionAnswerList
    {
        public List<QuestionAnswer> list { get; set; }
    }

    public class AnswerListHelper
    {
        public string answer0 { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public string answer4 { get; set; }
        public string answer5 { get; set; }
        public string answer6 { get; set; }
        public string answer7 { get; set; }
        public string answer8 { get; set; }
        public string answer9 { get; set; }
    }
}
