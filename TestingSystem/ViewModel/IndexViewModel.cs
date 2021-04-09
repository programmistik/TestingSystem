using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestingSystem.Models;

namespace TestingSystem.ViewModel
{
    public class IndexViewModel
    {

        public PageViewModel PageViewModel { get; set; }
        public int PageNumber { get; set; }

        public string OurTestId { get; set; }
        public string QuestionId { get; set; }
        public int pvmCount { get; set; }

        public string Title { get; set; }

        public Question Question { get; set; }

        public string answer0 { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public string answer4 { get; set; }
        public string answer5 { get; set; }
        public string answer6 { get; set; }
        public string answer7 { get; set; }
        public string answer8 { get; set; }

        public string RadioAnswer { get; set; }

    }
   
}
