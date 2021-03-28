using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public interface IQuestion
    {
        public string id { get; set; }
        public int number { get; set; }
        public Category category { get; set; }
        public string Text { get; set; }
    }

    public class DetailedOpenQuestion : IQuestion
    {
        public string id { get; set; }
        public int number { get; set; }
        public Category category { get; set; }
        public string Text { get; set; }
        public List<string> SubText { get; set; }
    }

    public class OpenQuestion : IQuestion
    {
        public string id { get; set; }
        public int number { get; set; }
        public Category category { get; set; }
        public string Text { get; set; }

    }

    public class TestQuestion : IQuestion
    {
        public string id { get; set; }
        public int number { get; set; }
        public Category category { get; set; }
        public string Text { get; set; }
        public List<string> Answers { get; set; }
    }
}
