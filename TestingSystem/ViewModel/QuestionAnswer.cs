using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestingSystem.Models;

namespace TestingSystem.ViewModel
{
    
    public class QuestionAnswer
    {
        public List<Question> Questions { get; set; }

        [Required (ErrorMessage = "Pleace, write your answer")]
        public string answer0 { get; set; }
        [Required(ErrorMessage = "Pleace, write your answer")]
        public string answer1 { get; set; }
        [Required(ErrorMessage = "Pleace, write your answer")]
        public string answer2 { get; set; }
        [Required(ErrorMessage = "Pleace, write your answer")]
        public string answer3 { get; set; }
        [Required(ErrorMessage = "Pleace, write your answer")]
        public string answer4 { get; set; }
        [Required(ErrorMessage = "Pleace, write your answer")]
        public string answer5 { get; set; }
        [Required(ErrorMessage = "Pleace, write your answer")]
        public string answer6 { get; set; }
        [Required(ErrorMessage = "Pleace, write your answer")]
        public string answer7 { get; set; }

        public QuestionAnswer(List<Question> list)
        {
            Questions = list;
            answer0 = "";
            answer1 = "";
            answer2 = "";
            answer3 = "";
            answer4 = "";
            answer5 = "";
            answer6 = "";
            answer7 = "";
        }
        public QuestionAnswer()
        {
            Questions = new List<Question>();
            answer0 = "";
            answer1 = "";
            answer2 = "";
            answer3 = "";
            answer4 = "";
            answer5 = "";
            answer6 = "";
            answer7 = "";
        }
    }
}
