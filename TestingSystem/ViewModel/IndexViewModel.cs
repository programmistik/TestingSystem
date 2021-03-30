using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingSystem.Models;

namespace TestingSystem.ViewModel
{
    public class IndexViewModel
    {

        public IEnumerable<SingleQuestionAnswer> questions { get; set; }
        public PageViewModel PageViewModel { get; set; }

    }
}
