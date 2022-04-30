using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TestingSystem.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the TestingSystemUser class
    public class TestingSystemUser : IdentityUser
    {
        public string Nickname { get; set; }
        public LangCode Language { get; set; }
    }
}
