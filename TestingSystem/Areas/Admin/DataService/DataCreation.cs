using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingSystem.Models;

namespace TestingSystem.Areas.Admin.DataService
{
    public static class DataCreation
    {
        public static void CreateAllData(TestModel tm)
        {
            tm.id = Guid.NewGuid().ToString();
            tm.Questions = new List<Question>();
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BriefInfo,
                number = 1,
                Text = "Contact Person"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BriefInfo,
                number = 2,
                Text = "Name of organization, form of ownership"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BriefInfo,
                number = 3,
                Text = "Location of the company's head office (country, city, address, contact phone number, e-mail)"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BriefInfo,
                number = 4,
                Text = "Age of business (s)"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BriefInfo,
                number = 5,
                Text = "Owners (number, full name)"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BriefInfo,
                number = 6,
                Text = "The main activities, products / services, the market in which the company operates (by product or service)"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BriefInfo,
                number = 7,
                Text = "Number of employees in the company / (% of vacancies). Attach the org. structure, as well as specify the Number of branches / offices"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BriefInfo,
                number = 8,
                Text = "Key trademarks of the company"
            });
            /////////////////////////
            ///

            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 1,
                Text = "What transformation / automation projects are currently running in the organization?"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 2,
                Text = "What are the most significant changes in the enterprise over the past 2 years? (Restructuring, Changes in business model, Implementation of accounting and planning systems, Implementation of the system of wage premiums for the result, Other)"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 3,
                Text = "Have there been any attempts of getting help from business consultants in the last 2 years? If so, who was involved, and for what? Are you satisfied?"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 4,
                Text = "According to you what critical changes are necessary for business today? (In internal communications, planning methods, management, etc.)"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 5,
                Text = "What are your expectations from Robertson & Blums business consultants? "
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 6,
                Text = @"What would you like to get ""at the exit"" of the cooperation?"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 7,
                Text = @"Average  Annual  OH  rate  (in  %)  for:  2017,  2018  and 2019 (expected)?"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 8,
                Text = @"What  is  the  sales  margin  in  %  for  2017,  2018,  2019? (Contribution \ Rev)"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 9,
                Text = @"Number of Customers in 2017, 2018 and 2019 (expected)?"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 10,
                Text = @"YoY  %  sales  increase  in  2019  (expected)  and  2018, 2017, 2016?"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 11,
                Text = @"Describe when you were proud of your company last time?"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 12,
                Text = @"Number of employees in the company / (% of vacancies)",
                SubText = new List<string>() {
                @"Sales / Business Development",
                @"Marketing / Customer Service",
                @"Production",
                @"Procurement / Logistics",
                @"Finance / Accounting",
                @"Strategy / Project / Business Management",
                @"Maintenance",
                @"IT",
                @"Other Administative"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 13,
                Text = @"Operating Budget per function. (If there is no budget please provide actual expenses)",
                SubText = new List<string>() {
                @"Sales / Business Development",
                @"Marketing / Customer Service",
                @"Production",
                @"Procurement / Logistics",
                @"Finance / Accounting",
                @"Strategy / Project / Business Management",
                @"Maintenance",
                @"IT",
                @"Other Administative"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 14,
                Text = @"Determine the three most valuable employees of your company."
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 15,
                Text = @"What is your company's management style?"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 16,
                Text = @"What are the qualities you value most in your employees?"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 17,
                Text = @"What drives you to work, what inspires?"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 18,
                Text = @"What hinders your work most?"
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.GeneralInfo,
                number = 19,
                Text = @"What are the current ""Corporate Values""."
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OwnersInvolvement,
                number = 1,
                Text = @"How owners participate in Conflicts resolution?",
                Variants = new List<string>() {
                @"They are not solved without them",
                @"Often have to get involved",
                @"Participate only in strategic",
                @"Rare",
                @"None"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OwnersInvolvement,
                number = 2,
                Text = @"Do owners have a consistent vision / understanding of business development in the form of a document?",
                Variants = new List<string>() {
                @"We do not pay much attention to a more distant future, current and operational problems are more important for us",
                @"There is a certain idea about the future of the company, however it is not stated in writing and does not turn into a plan",
                @"There is a written vision of a time horizon of 1–2 years on which short- term plans are based",
                @"Attempts are being made to develop the vision and a business plan for at least the medium term (3-5 years or 2-3 generations of products)",
                @"There is a clearly agreed development program broken down by initiatives and a feasible roadmap"
                }
            });
        }
    }
}
