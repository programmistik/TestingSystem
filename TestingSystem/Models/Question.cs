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
        // methodology
        public string Description { get; set; }
        public string Level1 { get; set; }
        public string Level2 { get; set; }
        public string Level3 { get; set; }
        public string Level4 { get; set; }
        public string Level5 { get; set; }
    }
}
