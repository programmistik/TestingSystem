using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class TestModel
    {
        public string id { get; set; }
        public string name { get; set; }

        public List<Question> Questions { get; set; }
        // public List<IQuestion> Questions { get; set; }
    }
}
