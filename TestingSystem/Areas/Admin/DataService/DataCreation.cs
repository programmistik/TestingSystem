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
                @"N/A",
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
                     @"N/A",
                @"We do not pay much attention to a more distant future, current and operational problems are more important for us",
                @"There is a certain idea about the future of the company, however it is not stated in writing and does not turn into a plan",
                @"There is a written vision of a time horizon of 1–2 years on which short- term plans are based",
                @"Attempts are being made to develop the vision and a business plan for at least the medium term (3-5 years or 2-3 generations of products)",
                @"There is a clearly agreed development program broken down by initiatives and a feasible roadmap"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OwnersInvolvement,
                number = 3,
                Text = @"How often the owners Meet to discuss strategic issues?",
                Variants = new List<string>() {
                     @"N/A",
                @"Just as needed",
                @"Once every two weeks",
                @"Once a month",
                @"Once a year",
                @"Quarterly"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OwnersInvolvement,
                number = 4,
                Text = @"How often the owners Come to work?",
                Variants = new List<string>() {
                     @"N/A",
                @"Just as needed",
                @"Once every two weeks",
                @"Once a month",
                @"Once a year",
                @"Quarterly"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OwnersInvolvement,
                number = 5,
                Text = @"How do owners assign tasks to the top management?",
                Variants = new List<string>() {
                     @"N/A",
                @"Do not assign",
                @"Everyone verbally",
                @"In writing with a copy to the partner",
                @"On boards of directors / shareholders",
                @"As part of the strategy with the fixation in the protocol"
                }
            });

            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OwnersInvolvement,
                number = 6,
                Text = @"How are decisions made with different visions among Owners?",
                Variants = new List<string>() {
                     @"N/A",
                @"Emotionally - by force",
                @"Voting",
                @"Discussion and approval",
                @"There is a decision procedure",
                @"All decisions are compared with the strategy and feasibility / risk assessments and contingency plans are made"
                }
            });
            //------------
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 7,
                Text = @"How   clearly   is   the   mission   of   the   company reflected in the strategy of the company?",
                Variants = new List<string>() {
                     @"N/A",
                @"There is no mission",
                @"There is a mission, but there is no strategy",
                @"There is a strategy, however, it doesn’t reflect the mission",
                @"The mission is partly reflected in the strategy",
                @"The strategy is based on the mission and long-term vision of the business"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 8,
                Text = @"Rate the Strategic planning level",
                Variants = new List<string>() {
                     @"N/A",
                @"Strategic planning is not visible or understood within the organization. Senior management develops the strategy with no input from customers, suppliers, employees, or other stakeholder groups. The strategic plan is very ""inward"" thinking with little focus on the customer",
                @"Key functional parts of the organization have strategic goals. Overall there is a strategic planning process with some involvement from customers and suppliers. Senior management approves the final strategic plan",
                @"Key organizational units have operating plans in place, linked to the company's overall strategy. Managers are held accountable for meeting strategic goals. The strategic planning process uses some key indicators, surveys, and other benchmark data. Senior level management approves the final strategic plan",
                @"The organization has established a complete strategic plan for addressing quality improvement, including mission, vision, goals, specific tasks, targets and programs. A broad planning process is used, involving customers, suppliers, and employees. The strategic planning process includes key quality indicators, benchmarks, and other quality information. Operating plans are developed throughout the entire company, linked to the company's overall strategy. Managers are held accountable for meeting strategic goals",
                @"Strategic planning is used regularly to develop goals and objectives for improving quality. All levels of the company participate in some form of strategic planning. Employees, suppliers, customers, and other stakeholder groups are actively engaged in strategic planning decisions. Management is very involved in planning related activities. Strategic planning includes key performance indicators, surveys, benchmark data, and other quality information to ensure that strategic planning is strong and viable for all parts of the company"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 9,
                Text = @"How detailed is the strategic plan?",
                Variants = new List<string>() {
                     @"N/A",
                @"There is No strategic plan",
                @".Only long - term goals are defined",
                @"Long - term development programs / initiatives(3 years and more)  have been created",
                @"Target indicators of programs / projects and deadlines of their achievement are determined",
                @"Detailed roadmaps of projects and areas of responsibility for the objectives have been defined"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 10,
                Text = @"How   much   does   the   organization’s   business processes support the strategy?",
                Variants = new List<string>() {
                     @"N/A",
                @"Business  processes  are  not  built  (nothing  is  executed  similarly  for  2nd time)",
                @"Business processes have been developed historically and haven’t been described",
                @"The main business processes (list them) have been described and support the strategy",
                @"All  business  processes  have  been  described  and  created  in  accordance with the strategy and organizational business model",
                @"There is a department responsible for continuous monitoring, optimization and adaptation of business processes in accordance with the strategy"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 11,
                Text = @"What   is   the   level   of   participation   of   top- management in the strategy development process?",
                Variants = new List<string>() {
                     @"N/A",
                @"Do not participate and are not aware",
                @"Do not participate, but everyone knows",
                @"Strategy developed only by Gen. Director / General Manager",
                @"All top-management participate and further inform the rest of the company employees",
                @"There is a top manager responsible for the Strategy with the relevant department  engaged  in  ongoing  monitoring, controlling  and  informing stakeholders about the status of the strategy"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 12,
                Text = @"How often is strategy revised / updated?",
                Variants = new List<string>() {
                     @"N/A",
                @"Not revised",
                @"Once every 3 years",
                @"As required",
                @"Once a year",
                @" Once every half year"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 13,
                Text = @"To what extent do you agree that reducing prices (costs) and strengthening the financial position are important for your organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 14,
                Text = @"To what extent do you agree that establishing effective employee remuneration and resourcing are important for your organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 15,
                Text = @"To what extent do you agree that Improving Corporate culture of the company and interaction with the owners are important for your organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 16,
                Text = @"To what extent do you agree Introducing new products (services) and improving the quality of products (services) activities are important for your organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 17,
                Text = @"To what extent do you agree that Enhancing company's market position and geographical expansion are important for your organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });

            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 18,
                Text = @"The  level  of  linkage  of  strategic  goals  with structural positions and personnel motivation system?",
                Variants = new List<string>() {
                     @"N/A",
                @"No job descriptions and links are available",
                @"Job descriptions exist, but are not related to strategic goals",
                @"Job descriptions partially reflect strategic goals, but are not motivational",
                @"Job descriptions are tied to strategic goals and to rewards for the result",
                @"Job descriptions are tied to strategic goals, to rewards for the result and finally are developed and updated based on roles in business processes"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 19,
                Text = @"The level of awareness of employees with a long- term vision of the organization?",
                Variants = new List<string>() {
                     @"N/A",
                @"There  is  no  need  to  present  a  vision  to  employees;  Their  tasks  are determined by their superiors according to the needs of the company",
                @"If interested, employees can learn about the vision of the company from their senior colleagues",
                @"Vision is regularly communicated to company employees",
                @"Company employees are involved in shaping the company's vision, and their comments are reviewed at the management level",
                @"There is a department of strategy coordinating the awareness and success of the strategy implementation within the organization"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 20,
                Text = @"Ratio  of  time  top  managers  spent  on  solving strategic / operational problems (%)?",
                Variants = new List<string>()
                {
                    @"N/A",
                    @"Only short-term plans are drawn up in accordance with current market opportunities, the company does not have a comprehensive  innovation program / budget",
                    @"The plan is drawn up for one year taking into account the current situation in the company; companies lack resources to create innovative programs",
                    @"The approximate plan is prepared for 2-3 years, innovative programs are accepted when the company is forced to introduce innovations due to the activity of competitors in the market",
                    @"The business plan relies on the introduction of innovations as a prerequisite for achieving the company's vision",
                    @"There is a center for continuous improvement  /  The  company  works closely with consulting / research organizations and the budget is laid in strategic initiatives"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 21,
                Text = @"Ratio  of  time  top  managers  spent  on  solving strategic / operational problems (%)?",
                Variants = new List<string>() {
                     @"N/A",
                @"0 / 100",
                @"20 / 80",
                @"40 / 60",
                @"60 / 40",
                @"80 / 20"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.StrategyManagement,
                number = 22,
                Text = @"What is the level of organization flexibility?",
                Variants = new List<string>() {
                     @"N/A",
                @"There is no opportunity to quickly adapt to dynamically changing market conditions",
                @"Partially used services of strategic partners for innovative solutions",
                @"Non-key business processes outsourcing services are actively used / there is a SSC (specify directions)",
                @"When required, sub-contractors are used to perform core business",
                @"Business concept is built on outsourcing business model"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 23,
                Text = @"How operational decisions are taken?",
                Variants = new List<string>() {
                    @"N/A",
                    @"Central Commissions / Committees / Supervisory Boards",
                    @"Individually by first persons",
                    @"According to the situation",
                    @"Functional managers",
                    @"There are procedures / instructions in job descriptions"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 24,
                Text = @"How  often  do  top  management  meetings  take place?",
                Variants = new List<string>() 
                {
                    @"N/A",
                    @"Just meeting as needed (which ones)",
                    @"Every day (which ones)",
                    @"Once a year (which ones)",
                    @"Once a month / week (which ones)",
                    @"There is a defined schedule of meetings (with clear agendas and list of attendees)"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 25,
                Text = @"How well developed is the planning and execution system of the annual business plan?",
                Variants = new List<string>() {
                     @"N/A",
                @"Planning is not applied - tasks / requests are solved as they arise",
                @"There is an annual program (plan) in all areas of work, which is carried out without changes",
                @"The  Balanced  Scorecard  is  applied  -  BSC  (KPIs  in  FINANCES  - CLIENTS   -  PROCESSES   -  PERSONNEL)   and  the  results   of   the performance analysis are the basis for adjustments",
                @"Similarly as in 3, but additionally planned / analyzed personal performance indicators of employees",
                @"Similarly as in 4, but additionally an ERP system is used (specify the modules and all solutions used), all deviations, as well as their causes, are instantly visible"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 26,
                Text = @"What is the level of independence of governance from people? (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 27,
                Text = @"What is the level of information  system  (by  category  if  there  are several different systems)? (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 28,
                Text = @"What is the level of management qualifications? (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 29,
                Text = @"Specify the level of defects in % Business processes (re-processing) (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 30,
                Text = @"Specify the level of defects in % Quality of services / products (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 31,
                Text = @"Specify the level of defects in % In the preparation of reports (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 32,
                Text = @"Determine  the  level  of  the  financial  planning process?",
                Variants = new List<string>() {
                     @"N/A",
                @"Financial indicators of the plan are not specified in advance",
                @"The company monitors costs in relation to operating profit, other data (other than revenue) is not important for the company",
                @"The company uses zero based / activity based budgeting process to develop its plans",
                @"The financial plan is the result of a clear causal planning, starting from sales, up to supplies",
                @"The  goal  and  strategies  of  the  business  plan  are  converted  into  clear financial plan indicators, and each business case is evaluated according to them before it is accepted. The process is fully automated"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 33,
                Text = @"Determine the level of the budgeting process. Attach budgets of the following units:
                        1. Finance / Accounting
                        2. Human Resources
                        3. IT
                        4. Logistics / Procurement
                        5. Production
                        6. Marketing
                        7. Administrative
                        8. Maintenance                                        
                        9. Sales                                                          
                        10. Management (Project / Strategy / General)   ",
                Variants = new List<string>() {
                     @"N/A",
                @"Budgets are not drawn up",
                @"Budgets are compiled without coordination between departments",
                @"Budgets are agreed, but are based on historical data",
                @"Budgets are coordinated and take into account the external environment, and also lay the coefficients of improvement",
                @"There  is  an  automated  budgeting  process  associated  with  the  strategy based on ERP systems"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 34,
                Text = @"Define the level of margin (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 35,
                Text = @"Define the level of cost (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 36,
                Text = @"Define the level of Inaccuracy of budgets (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 37,
                Text = @"Define the level of difficulty in determining costs (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 38,
                Text = @"Define the level of sales (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 39,
                Text = @"Define the level of working capital (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 40,
                Text = @"Define the level of volume in inventory storage (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 41,
                Text = @"Define the level of inventory turnover (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 42,
                Text = @"Define the level of credit load (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 43,
                Text = @"Define the amount of time required for Period closure (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 44,
                Text = @"Define the level of quality of On-demand reporting (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 45,
                Text = @"What is the effectiveness of reports in work?",
                Variants = new List<string>() {
                     @"N/A",
                @"The reporting is not adjusted, there are no formulated information needs",
                @"A  lot  of  reports  /  information  is  duplicated,  the  time  spent  on  their preparation is more than necessary",
                @"Reports  are  standardized,  but  not  effective,  it  is  difficult  to  obtain  the information necessary for operational management",
                @"Company  reports  are  suitable  for  operational  management,  but  do  not contain processed information for strategic management",
                @"There  is  an  automated  system  for  accounting  and  preparing  reports (including  document  circulation)  of  the  company.  The  information  is suitable for both operational and strategic management"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 46,
                Text = @"What    is    the    level    of    development    and effectiveness of the quality management system (QMS) in general?",
                Variants = new List<string>() {
                     @"N/A",
                @"There is no quality management system, the defect is detected only on the basis of complaints from customers",
                @"Attempts to create a quality management system are present, but only on core business processes",
                @"ISO  9001  certification  is  available,  but  requirements  are  not  always followed",
                @"Besides of the obtained ISO 9001 certification a QM department has been established and regular internal audits and trainings are conducted in order to improve the quality of services",
                @"As in level 4 plus the company systematically conducts both internal and external quality audits from its suppliers. Moreover, all processes and the costs associated with them, as well as the contribution of  employees  and  teams  to  quality and  their  motivation,  are  regularly assessed"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 47,
                Text = @"How quickly can an organization reconfigure the production process to a new product / service?",
                Variants = new List<string>() {
                     @"N/A",
                @"Setup time is not measured. The process of reducing the processing time on any equipment / process is not given any value",
                @"Setup time is known and taken into account when scheduling work. No thinking of reducing Setup time",
                @"Limited  use  of  informal  reduction  of  settings  in  isolated  places.  Some training and some awareness of the setup reduction process exist",
                @"A team is formed and there is an official program for reducing the time for setup",
                @"The  reduction  program  has  reached  a  50%  reduction  in  time  in  some equipment  or  processes.  Approaches  to  reducing  setup  time  are  well defined and widely understood"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 48,
                Text = @"How effective is the maintenance process?",
                Variants = new List<string>() {
                     @"N/A",
                @"Maintenance is performed only when the machine is broken. No official preventative maintenance system exist",
                @"Preventive   maintenance   is   done   on   occasion,   but   the   equipment maintenance history is not maintained",
                @"Introduced  the  official  system  of  preventive  maintenance.  Idle  time  is scheduled. History is preserved",
                @"Maintenance personnel and operators work together to identify root causes and develop solutions. Teams are formed to improve equipment through upgrades    and    modifications.    Appropriate    maintenance    has    been transferred to operators",
                @"Operators and administrative personnel become owners of the equipment and  are  trained  to  perform  daily  and  weekly  maintenance  tasks.  The maintenance personnel is only warned about the need for major repairs"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 49,
                Text = @"How  developed  is  the  on-demand  (pull  system) production / processing system?",
                Variants = new List<string>() {
                     @"N/A",
                @"Plan /  Schedule  of  production /  procurement  is  based on  forecasts.  No processes running on pull-system",
                @"Plan  /  Schedule  of  production  /  procurement  based  on  requests  from customers,  however  there  is  no  wide-spread  understanding  of  work  on pull-system",
                @"In some areas, besides production / procurement, a kanban form is used and employees understand the value of a visual alarm system. Also, a small number of employees are trained on the pull system",
                @"Kanban is used to plan finished products. Consumer demand drives the system.  The  system  is  clear  and  visible  to  all  employees.  Widespread training  about  pull  systems.  Some  pull  systems  are  even  used  for administrative processes or support",
                @"Customers, suppliers, manufacturing and also office work on the principle of kanban system. The system is clear and visible to all employees and ongoing improvement projects are carried out"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 50,
                Text = @"Quality of production / information flow?",
                Variants = new List<string>() {
                     @"N/A",
                @"There is no fixed flow for products, materials or information. Only a small flow is visible, since it is complicated by disorder, large batches and work in progress (WIP)",
                @"There  are  prerequisites  for  product  flow.  Analysis,  development  and documentation  of  flowcharts  for  the  sequence  of  production  processes were carried out in some parts",
                @"Flow can be seen in some areas. The takt time is known, but not fully utilized. Large batches and excessive WIP still exist",
                @"Continuous  flow  can  be  seen  in  the  product  family,   material  and information flow. The tact time used and the reduced batch and queue sizes are obvious",
                @"All areas have been converted to stream. All production, material and administrative flows were compared to the value stream. Batch and WIP sizes are at minimum levels. Standard work is done in all areas"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 51,
                Text = @"What  is  the  level  of  maturity  of  the  accounting system?",
                Variants = new List<string>() {
                     @"N/A",
                @"The  accounting  system  provides  basic  financial  data  based  on  cost accounting and serial production methodology. Little is known about the role of bookkeeping in supporting lean initiatives",
                @"There  is  an  understanding  that  accounting  plays  an  important  role  in supporting  lean  initiatives.  Some  accounting  and  support  staff  were trained in lean accounting, and an initial analysis was conducted",
                @"All   key   accounting   and   support   staff   have   been   trained   in   Lean Accounting. The pilot project began in a value stream or cell using lean financial measurements. Accounting began to focus on the elimination of waste in their own processes",
                @"A   number   of   key   value   streams   or   cells   use   Lean   performance measurements.  Accounting  created  a  flowchart  of  the  value  stream for most  of  its  own  processes.  Some  initial  studies  have  begun  to  revise existing standard costing methods ",
                @"All value streams or cells use Lean performance measurements. Everywhere there is a revision of the existing standard costing methods"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 52,
                Text = @"What is the warehouse management level?",
                Variants = new List<string>() {
                     @"N/A",
                @"Warehousing is based on manual accounting and there is no integration with production / procurement processes",
                @"Warehousing is automated via RFID, but not integrated with production / purchasing processes",
                @"Warehouse  management  takes  into account the  work of  the KANBAN principle and uses calculations to determine the level of re-order",
                @"Warehousing is automated and integrated with production / purchasing processes ",
                @" Besides of the automated and integrated WMS there is a SCM department which integrates and coordinates the whole SC staring from the receiving of customer orders and ending at ordering the production materials from suppliers"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 53,
                Text = @"What is the level of supply chain sourcing?",
                Variants = new List<string>() {
                     @"N/A",
                @"Decisions on supply are made only by price. Supplier metrics are not used",
                @"The company has regular suppliers and distributors, other opportunities are not considered ",
                @"The management selects suppliers for individual orders via tender",
                @"The company has a database of its pre-qualified suppliers, the efficiency of supply is assessed on an ongoing basis (tender and audits of suppliers during procurement process)",
                @"Besides of the database of pre-qualified suppliers and continuous assessment of suppliers performance, the company has established strategic partnerships for some of its needs and tires to utilize this outsourcing practice as much as possible"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 54,
                Text = @"How effective are continuous improvement operations?",
                Variants = new List<string>() {
                     @"N/A",
                @"New ideas are not tracked, the company succeeds even without them",
                @"The  company  does  not  suppress  the  initiative  of  employees,  if  the innovation is beneficial for the company then it is used",
                @"There is a knowledge management system, but it is not widely used",
                @"New  ideas  are  systematically  collected  and  evaluated,  they  serve  as  a source of product and / or process innovation, while cost and risk analysis is carried out",
                @"Besides of the systematic collection and evaluation of the new ideas the organization has established a center of excellence which is responsible for continuous improvement operations and developed a reward based system for the motivation of the creative potential of employees"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 55,
                Text = @"Assess the Project Management Level",
                Variants = new List<string>() {
                     @"N/A",
                @"The company is dominated by operational, day-to-day management, new approaches are not considered",
                @"Projects are selected on an operational basis, taking into account market opportunities, full utilization of the company's capacity is a priority",
                @"The choice of new projects always corresponds to the long-term strategy of the company, which focuses on innovation as a means of increasing the future value of the company",
                @"Processes,  procedures,  and  methodologies  for  project  selection  and management have been developed",
                @"There are PM processes, procedures, methodologies and established PM office, which controls and manages all projects"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 56,
                Text = @"What % of projects / initiatives / improvements initiated each year are actually completed?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 57,
                Text = @"What % of projects / initiatives / improvements that  are  completed  each  year  give  outstanding results?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 58,
                Text = @"What  % of the  processes  are  documented (in such  a  way  that  for  new  employees  it  is  clear exactly  how  they  should  carry  out  their  work tasks)?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 59,
                Text = @"What % of documented processes are current?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 60,
                Text = @"What % of processes have 2-5 key performance indicators, which are consistently used to measure success and improve?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 61,
                Text = @"What % of the processes are formally revised and improved at least once a year?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 62,
                Text = @"What % of the processes has a clearly identified owner  of the process who is responsible for the performance?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                }
            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.BusinessManagement,
                number = 63,
                Text = @"How effectively are role-based areas of responsibility distributed between departments  / people?",
                Variants = new List<string>() {
                     @"N/A",
                @"There is no clear distribution, many overlapping functions / divisions",
                @"Separation on the basis of a conservative organizational structure",
                @"Roles are created only for the main business processes",
                @"There are clearly described roles for all business processes",
                @"There are clearly described roles for all business   processes and remuneration is based on work results"
                }

            });
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 64,
                Text = @"What is the load level (in % ratio to capacity) for Personnel (by category)?",
                Variants = new List<string>() {
                     @"N/A",
                @"Workload is not measured",
                @"Low level of load due to frequent failures / malfunctions",
                @"Average workload due to seasonality",
                @"Higher workload than competitors",
                @"High workload associated with continuous improvement process"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 65,
                Text = @"What is the load level (in % ratio to capacity) for Fixed assets?",
                Variants = new List<string>() {
                     @"N/A",
                @"Workload is not measured",
                @"Low level of load due to frequent failures / malfunctions",
                @"Average workload due to seasonality",
                @"Higher workload than competitors",
                @"High workload associated with continuous improvement process"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 66,
                Text = @"What is the level of employee empowerment and development?",
                Variants = new List<string>() {
                     @"N/A",
                @"Training and development of employees is not practiced. Few employees are empowered and no priority is given to building the human resources of the company. Reward and recognition programs are not focused on employee performance and quality improvement",
                @"Employee empowerment is not encouraged. Rewards and recognition for quality improvement is not fully deployed. Most of the focus is on individual employee recognition and not teams or groups. Not all employee development programs are linked to the company's strategy and quality objectives. There is no consistent support with requirements of employees",
                @"Many parts of the organization have empowered their employees through cross functional teams and sharing of information. The company has an overall plan to fully develop its human resource capital. Employees are rewarded for making improvements to quality. The organization is sensitive to the needs of employees",
                @"Senior management and most middle level managers are very supportive of strong human resource practices to build and develop employees. Work teams and groups are empowered, providing valuable improvements in almost every part of the business. Employees have quick access to data for analysis and sharing of information in most parts of the company. Employee ideas for making improvements is strongly encouraged and acted upon",
                @"Full implementation and integration of employee growth plans, including training programs, career development paths, evaluation, compensation, empowerment, and measurable results. Very high levels of involvement by employees in day to day operations and planning the business. People work well within teams and across organizational functions. The organization is working hard to make sure employees are productive and satisfied"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 67,
                Text = @"What is the level of regulation in management?",
                Variants = new List<string>() {
                     @"N/A",
                @"No regulatory documents",
                @"Developed job descriptions (JDs)",
                @"There are JDs plus there are charters for divisions",
                @"JDs, charter of divisions, plus created charters on committees / commissions",
                @" JDs, charters for divisions and committees / commissions plus there  are  all  Regulatory  Documents  (including  project  management  / product creation, etc.)"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 68,
                Text = @"Rate the level of Salary in the enterprise (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 69,
                Text = @"Rate the level of Staff turnover in the company (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 70,
                Text = @"Rate the level of Ability to attract and retain talents (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 71,
                Text = @"Rate the level of The quality of your company's staff (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 72,
                Text = @"Rate the level of Employee satisfaction (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 73,
                Text = @"Rate the level of General mood of employees (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 74,
                Text = @"Rate the level of Attitude to management (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 75,
                Text = @"Rate the level of Employee motivation (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 76,
                Text = @"Rate the level of Employee loyalty (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 77,
                Text = @"Rate the level of Employee complaints (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 78,
                Text = @"Rate the level of Mutual understanding among managers (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 79,
                Text = @"How   often   are   professional   competencies evaluated?",
                Variants = new List<string>() {
                     @"N/A",
                @"Not carried out",
                @"Just as needed",
                @"Once every 3 years",
                @"Once a year",
                @"Once every half year"
                }

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 80,
                Text = @"The units level of effectiveness?",
                Variants = new List<string>() {
                     @"N/A",
                @"Effectiveness is not measured",
                @"Low effectiveness (describe the reasons)",
                @"Effectiveness is acceptable, deviations are eliminated post-factum",
                @"High effectiveness, monitoring indicators are introduced for preliminary elimination of deviations",
                @"There is a process and project management department responsible for monitoring and controlling performance"
                }

            });
        }
    }
}
