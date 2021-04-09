using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public enum Category
    {
        BriefInfo,
        GeneralInfo,
        OwnersInvolvement,
        StrategyManagement,
        BusinessManagement,
        OrganisationalStructure,
        MarketingAndSales
    }

    public static class Extensions
    {
        public static string GetDescription(this Category cat)
        {
            var str = "";

            switch (cat)
            {
                case Category.BriefInfo:
                    str = "";
                    break;
                case Category.GeneralInfo:
                    str = "GENERAL INFORMATION";
                    break;
                case Category.OwnersInvolvement:
                    str = "OWNERS INVOLVEMENT";
                    break;
                case Category.StrategyManagement:
                    str = "STRATEGY MANAGEMENT";
                    break;
                case Category.BusinessManagement:
                    str = "BUSINESS MANAGEMENT";
                    break;
                case Category.OrganisationalStructure:
                    str = "ORGANISATIONAL STRUCTURE AND PERSONNEL";
                    break;
                case Category.MarketingAndSales:
                    str = "MARKETING AND SALES";
                    break;
            }

            return str;
        }
    }
}
