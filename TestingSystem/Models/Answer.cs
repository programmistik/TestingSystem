using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class Answer
    {
        public string id { get; set; }
        public string UserId { get; set; }
        public DateTime date { get; set; }
        public string QuestionId { get; set; }
        public string answer { get; set; }
        public List<string> AnswerList { get; set; }
    }
}
