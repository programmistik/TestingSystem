using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingSystem.Models;

namespace TestingSystem.ViewModel
{
    public class PageViewModel
    {
        public Question Question { get; set; }
        public int PageNumber { get; set; }
        public bool HasNext { get; set; }
        public bool HasPre { get; set; }

        //public int PageNumber { get; private set; }
        //public int TotalPages { get; private set; }

        //public PageViewModel(int count, int pageNumber, int pageSize)
        //{
        //    PageNumber = pageNumber;
        //    TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        //}

        //public bool HasPreviousPage
        //{
        //    get
        //    {
        //        return (PageNumber > 1);
        //    }
        //}

        //public bool HasNextPage
        //{
        //    get
        //    {
        //        return (PageNumber < TotalPages);
        //    }
        //}
    }
}
