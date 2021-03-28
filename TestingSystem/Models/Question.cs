using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class Question
    {
        public string id { get; set; }
        public int number { get; set; }
        public Category category { get; set; }
        public string Text { get; set; }
        public List<string> SubText { get; set; }
        public List<string> Variants { get; set; }
    }
}
