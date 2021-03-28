using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class OurTest
    {
        public string id { get; set; }
        public bool finished { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string UserName { get; set; }
        public TestModel Test { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
