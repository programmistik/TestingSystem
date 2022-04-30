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
                },
                Description = @"Level of involvement of Company Owners in the conflict resolution process indicates how well established is the corporate governance process and how independent are the managers of the organization. The real problem occurs when the owners instead of thinking strategically or dealing with strategic issues, are intensively involved in conflicts resolution and cannot leave the company on its own.",
                Level1 = @"Level 1 means that owners are doing nothing else, but just rulling out the existing conflicts between different employees and doing the non-value adding activities. ",
                Level2 = @"Level 2 means that there is no healthy and trustful environment among employees and they are not able to solve their own problems without communicating them to Owners. ",
                Level3 = @"Level 3 is almost right situation, but not in every case, i.e., if the business is small or medium, then the owners may participate in the strategic management and conflict case resolution. However, if the organization is large enough and there is an appropriate corporate governance system, processes, procedures and right management team, then there is no need in owners involvement at all. ",
                Level4 = @"Level 4 means that there is a corporate governance system, managers are independent and there is a healthy corporate culture and trust among employees. Nevetheless, if there is still some involvement of owners in conflict resolution, this can indicate to lack of decision making rights or inappropriate delegation of them, hence a more detailed assessment would be required.",
                Level5 = @"Level 5 is an absolute ideal case, which is a target state to be achieved and when every part of business runs smoothly and automatically with minimum interference of owners or dependence on people. ThichLevel could be achieved when all business processes are established and mapped, R&Rs are clear and effectively delegated, KPIs are established and monitoring and control system is in place."
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
                },
                Description = @"Long-term vision and consistent understanding of business in a form of written document is an important factor in corporate governance process. If there is no written program/plan and common understanding, then this situation may lead to principal-agent problem, where the owner's expectations are different to the top management ones and company development is driven in the different way.",
                Level1 = @"Level 1 organization has no defined business direction and owners are busy with day-to-day firefighting rather than effective steering of the business through longer-term horizons. It is necessary to carry out a detailed intereview process with the owners and establish a mutually acceptable development plan written in a document.",
                Level2 = @"Level 2. There is some understing of what to do and where to go, however, as it is not written in a document format, it may not be a commonly accepted vision and maybe interpreted differently by different people. Thus, it is definitely important to translate this vision into document and make sure that all owners put a visa on that document and accept the vision equally.",
                Level3 = @"Level 3. There is a written document and the vision is clearly stated to everybody, so that no second interpretation is possible. Nevertheless, it is still far from desired state, as it only provides a vision for a tactical period of time, which is not enough for sustainable business development. Therefore, besides of the tactical plan it is required to develop a more long-term business pland and prepare the relevant roadmaps to make it related to operations.",
                Level4 = @"Level 4. The company have made a significant progress in determing their business goals and cascading them down into business plans for their achievement, which shows that owners and managers are in agreement and know where they want to get. However, besides of those attempts it is a must to have clear-cut roadmaps and appropriately developed performance management system to achieve the target picture.",
                Level5 = @"Level 5. This is an ideal case, when there is a clear definition of roles, responsibilities and settlement of various initiatives with transparrent roadmaps for delivery of results. There is a transparrent linkage among different managementLevels and common understanding between owners and top management.Organization should follow this approach."
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
                },
                Description = @"The frequency of meetings that owners have to discuss the strategy indicateLevel of maturity for corporate governance system. IF there is a clearly defined system and structure to manage the business then there should be a pre-defined schedule for meeting with the purpose of discussing and setting the future direction. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The frequency of work attendance that owners have is another indicator regarding the corporate governance process, i.e., the more frequently they come, the worse is the status of corporate governance. Therefore, similarly as in the description to previous question owners visit to work place is only desirable for a discussion of strategic issues and taking strategically important corrective actions, rather than involvement in day-to-day operational issues.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Task delegation is a factor describing the maturityLevel of communication system in a company, in other terms if there is an appropriate corporate governance system which has an established communication channel and comprehensive task assignment processes then all the expectations are easily translated into strategic and operational plans.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The decision making process is another indicator explaining how well developed the corporate governance process is. Obviously, the more mature the sysstem becomes the more objective decision making process is adopted, i.e., all the decisions are carefully technically, financially and strategically evaluated by those people who has the best knowledge and can effectively implement the decision in business operations.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The mission is very important indicator of whether company owners/top management understand what is their purpose of existence and what they are aimed to deliver to the surrounding environment/society. İf there is no mission or it is not reflected in the strategy document, then neither the owners and top management nor the lowerLevel employees understand their value to sciety and what it is the company tries to achieve.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Strategic planning process is an indicator of how well organization manages to get involved all its stakeholders / employees in activity planning, target setting and goal achievement process. The more the employees / partners / suppliers / customers are engaged in these activities the better is the outcome of such strategic planning activity. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                @"Only long - term goals are defined",
                @"Long - term development programs / initiatives(3 years and more)  have been created",
                @"Target indicators of programs / projects and deadlines of their achievement are determined",
                @"Detailed roadmaps of projects and areas of responsibility for the objectives have been defined"
                },
                Description = @"Comprehensive strategic plan is like a bunch of several tools for each managementLevel, i.e., top management needs to have a highLevel understanding for the business direction, midLevel managers need to know allLevels, i.e., highLevel, tacticalLevel which is more detailed plan for 1-3 years and an operationalLevel with detailed course of action for the year, finally shop-floorLevel employees need to know the operationalLevel plan. Obviously, if the organization has all threeLevel plans and they are fully backed by all relevant documents and other elements then there is no room for misunderstanding or probability of taking wrong decisions is minimized.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The linkage of business processes to strategy is another important factor which indicates how well the organizational business model and structure supports the delivery of strategy, i.e., as if there is weak relation of strategy to business processes, then the execution of the later will deliver different results.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Participation of top management in the strategy development process is very important factor as it may describe the management style and explain more about the reasons for failure or success in the strategy delivery process.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Current dynamic and competitive environment makes It necessary to review the organizational strategy for validity at some systematic and defined periods of time. As if this is not done on a timely basis, the validity of strategy may be lost and business may fail.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Organization may have a competitive advantage if there is a competitive pricing for offerings and the cost of their development is low. In other words, such situation may create a healthy financial position and make the organization more stronger in competition. Therefore, the more weight is placed on the importance of prices (costs) or strengthening the financial position the worse is the current position of the organization. Thus,Level 5 is an ideal case when minimum balls (weights) are assigned and the organization places minimum importance on the factor.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Organization may have a competitive advantage if there is a competitive employee remuneration and effective resourcing system is put in place, i.e., if there is an appropriately skilled employee who is performing the work and he or she is adequately remunerated for performance, then there is a healthy environment within the organization and all employees are motivated enough to achieve and exceed the targets assigned. Therefore, the more weight is placed on the importance of factor the worse is the current position of the organization andLevel 5 is an ideal case when minimum balls (weights) are assigned and the organization places minimum importance on the factor.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Corporate culture similarly to interaction with the owners are also factors which may create a competitive advantage. In other words, if there is a well defined corporate culture with transparrent attributes of the behaviour and communication of the person who belongs to the organization, then it means that employees have unconcious loyalty and pride that they are part of this group of people, they belong to this organization. Similarly, interaction / communication with owners is another side of the coin, as for the large companies which are usually PLSC listed on stock exchanges the processes are almost completely regulateed and the communication channels and frequency are transparent defined in advance. However, for the SME organizations owners may be heavily involved in the management process, therefore it is very important to have similarly well defined and transparrent channels of interaction / communication with them and make sure that the business development is indeed increasing the shareholder value in accordance to the expectations.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The importance of these two factors in development of competitive advantage is the fact that if there are high quality products / services and there is enough flexibility for choise in organizational offering, then it means that organization is flexible and robust enough to successfully meet the majority of customer demands. Obviously, the lower the importance of this factor the higher is the quality of products / services produced. It is expected that the customers (both internal or external) are adequately satisfied.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The market position or geographical presence of the company are important in terms of being competitive and successfull. There are case, when organization deliberately select a particular market niche and serinvg the customers of that target auditory, obviously this is good approach, but if diving a bit deeper there may be that auditory group has a low incomeLevel and the company therefore produces / serves low quality, low cost offerings. In the latest case the market position may be good for that particular auditory, but not good for others as well as other geographical regions. Therefore, if there factor is important this means that it may be the right time for organization to change its positioning and enter some other markets as well.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Linkage of strategy to personnel KPIs delegated among structural positions is very important factor as it described how well cascaded is the strategy and if employees understand what is being done, why it is done and the end result will affect their remuneration.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Employee awareness of the long-term organizational vision is similarly important as their awareness of strategy. In other words, long-term vision is a statement which briefly describes what organization wants to achieve in the foreseeable horizon and if the employees are not aware of this statement this means that there is no proper communication or interaction system in place and there is a lack of transparency within the organization. Therefore, eventually the vision could be completely forgotten and business development may lead to different results.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Innovation planning and execution system is very important if the organization is in a dynamic and highly competitive environment, like telecommunication, High-tech, Automobile and other similar industries. Therefore, if there is a limited innovation planning and execution process then there is high probability of failure to achieve the expected results.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Levels indicate how well developed is the corporate governance structure and how well balanced is the time management process for top managers. As a golden rule the more time top management spends on strategic direction the more beneficial it may be to the organizational sustainable performance. On the other hand, if on contrary top management spends a lot of time resolving day-to-day issues, it means that the organization is always in fire-fighting process and has no appropriate systematic decision making process or no corporate governance at all.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Flexibility means being able to meet as much customized customer request as possible. Flexibility means being able to meet the order within a very tight deadline. Flexibility means being able to suddenly increase the volume of production / service and etc... Therefore, the more flexible is the organization the more satisfied are its customers. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The approach used for taking the operational decisions is another indicator representing the status of corporate governance system within the organization. Obviously, the better developed is the corporate governance system, the more clear and transparrent is the decision making process within the organization. Operational decisions areLevel of middle and lowerLevel management / supervisory personnel, therefore if the top management is heavily involved within the process then this is not normal.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"This factor reflects another element of corporate governance system. The well developed system must have an established set of systematic meetings with clear agenda and roles and responsibilities of those meetings. Different committees, operational groups, steering boards and others should provide the basis for the decision making process.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Planning and execution system for annual business plan is another important factor which desribes if there is a properly developed tactical management tool in the hands of employees to plan and perform the tasks during a year. If there is no such tool, then the communication and interaction among employees is poor and generally organization will work in silos mode.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"These three indicators are grouped into one question in order to aggregate the situation of the corporate governance system. In other words, the system is measured through the prism of: - proper governance methodologies, procedures, processes; - proper information system used to supply timely and relevant information to the required users; - finally, proper management / supervisory personnel who is skilled enough to be able to utilize the tools and information available and steer the organization in the expected direction. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"These three indicators are grouped into one question in order to aggregate the situation of the corporate governance system. In other words, the system is measured through the prism of: - proper governance methodologies, procedures, processes; - proper information system used to supply timely and relevant information to the required users; - finally, proper management / supervisory personnel who is skilled enough to be able to utilize the tools and information available and steer the organization in the expected direction. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"These three indicators are grouped into one question in order to aggregate the situation of the corporate governance system. In other words, the system is measured through the prism of: - proper governance methodologies, procedures, processes; - proper information system used to supply timely and relevant information to the required users; - finally, proper management / supervisory personnel who is skilled enough to be able to utilize the tools and information available and steer the organization in the expected direction. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"This is a quality management system indicator, used in order to understand the volume (status) of organization's re-work operations. Therefore, it is obvious that the lower is the re-workLevel the better is the situation withing the organization (less time and other resources used to correct the mistakes).",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"This is a quality management system indicator, used in order to understand how good are the services / products in compare to the competitor offerings. Therefore, it is obvious that the lower isLevel of defects in quality of the services / products the better is the situation withing the organization (less time and other resources used to correct the mistakes).",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"This is a quality management system indicator, used in order to understand the volume (status) of reports prepared with mistakes. Therefore, it is obvious that the lower is the re-workLevel for the reports the better is the situation within the organization (less time required for information comprehension and decision making).",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"This is an indicator of the professionalism in the planning process, i.e., how well thought is the planning at all. Obviously, the more conservative the organization is the more traditional planning and budgeting system is utilized and the less accurate it may become in the current dynamic and competitive environment.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Budgeting process is very similar to planning process, however, it requires a very detailed attention to the activities to be performed during the next short-term to mid-term period and thus the maturity of this process helps to generate more accurate budgets and easily execute the activities.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Level of problems in several different areas are used to understand the pain-point of the organization. What the managers are seeing as the most important problem to be solved.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Level of problems in several different areas are used to understand the pain-point of the organization. What the managers are seeing as the most important problem to be solved.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Level of problems in several different areas are used to understand the pain-point of the organization. What the managers are seeing as the most important problem to be solved.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Level of problems in several different areas are used to understand the pain-point of the organization. What the managers are seeing as the most important problem to be solved.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Level of problems in several different areas are used to understand the pain-point of the organization. What the managers are seeing as the most important problem to be solved.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Level of problems in several different areas are used to understand the pain-point of the organization. What the managers are seeing as the most important problem to be solved.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Level of problems in several different areas are used to understand the pain-point of the organization. What the managers are seeing as the most important problem to be solved.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Level of problems in several different areas are used to understand the pain-point of the organization. What the managers are seeing as the most important problem to be solved.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Level of problems in several different areas are used to understand the pain-point of the organization. What the managers are seeing as the most important problem to be solved.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Level of problems in several different areas are used to understand the pain-point of the organization. What the managers are seeing as the most important problem to be solved.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Level of problems in several different areas are used to understand the pain-point of the organization. What the managers are seeing as the most important problem to be solved.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Effectiveness of reports is very important factor, as this one indicates how well organized is the information quality, flow, distribution and communication process. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The quality management system is a must attribute of any global and contemporary organization. The QMS enables a standardized approach for any process withing the orgazanition and helps to map end-to-end processes to achieve a transparrent system which makes sure that organizational targets are achieved, customers are happy and revenues are high.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Setup time or flexibility in terms of time to deliver the required product / service is another important factor in the current dynamic and competitive market environment. The shorter is the setup time the more flexible the organization is and the more competitive it becomes.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Manufacturing companies usually incur high maintenance costs. Generally, the cost driver behind this is that there is no appropriate maintenance system and it is only done when there is a break in equipment or any other asset. Therefore, any organization if wants to suceed must develop its maintenance practices toLevels of higher maturity and have a system with systematic and timely maintenance audits which will allow to take preventative actions and increase the explaitation period of any equipment. This kind of approach will eventually lead to a higher performance and organization will be more sustainable.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Pull production / lean management / JIT production system are all different names of one same strategy, which is used basically to optimize production and other business processes to the extent that is required by customer. In other words, if there is no demad for a service / product it is not produced. Obviously for a large scale manufacturing process, no production does not mean that there is a zero number of finished goods, work in progress or inventory, however, it means that there is a very limited volume of those which usually fits within two so called ""kanban""s. The kanban itself could be in different forms, shapes, sizes and is used as a signal to the supplying / producing side that if kanban is empty, then  there is a need to produce more. This philosophy, helps organizations achieve higher efficiency and effectiveness, more flexibility and reduces throughput time. Therefore, this philosophy has become quite popular for the last 40-50 years  and is an approach utilized by top performer organizations.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Quality of production / information flow is a very important indicator of how well the production and information processes are developed. The organization has better performance and sustainability when every single production related material, spare parts, or any other products are sorted out and placed in relevant standardized areas in small volumes, so that whenever required the item could be easily replaced and / or re-ordered a different type of it. Moreover, the production flow also means that similar group of production activities are grouped together and related activities create a structured and systematic flow which doesn't create any botlleneck along the production chain. Similarly, the same is relevant for information flow, i.e., proper information sharing, communication and distribution process should be in place, which can deliver all the required data and information to the associated task groups / teams and provide them a valuable and reliable data for operational, tactical and strategic decision making process. Therefore, the higher is the maturity the better is the peroformance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The accounting system is a very important factor indicating how well developed is the organization. For example, in a less developed organizations there is usually a traditional accounting system wchih does not motivate personnel or management team to focus on real cost drivers and eliminate non-value adding activities. Thus, usually man-hour or machine hour based cost drivers are used to calculate the costs and develop budgets, which is not a correct reflection of what is the real reason for the cost occurence. In contrary, the implementation of lean practices within the organization and especially within accounting system, motivates the employees to re-think the whole process, to change the the whole approach of how products / services are produced and how the production process is accounted for. To get all potential benefits from this activity organization thus has to map all the value streams and update its costing methods.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Simple indicator of how well the warehousing process is organized within the organization. Obviously, there are some cases when there is no need for the storage at all. However, except no need, if the organization is manufacturing company, then there should be an appropriately developed storage and inventory management system. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The more advanced and comprehensive is the sourcing process the more benefits are available to organization. In other words, a proper definition of supply chain sourcing strategy enables the company to clearly inform the suppliers about the rules which are effective for the procurement process and thus, can increase the quality and efficiency of procurement and reduce production costs further",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Kaizen or continuous improvement is another factor of organizational developmentLevel. Thus the more developed the organization is (proper knowledge management system in place, new ideas are adequately implemented, employees are motivated and engaged and etc) the more new opportunities are coming from inside and outside sources and the higher is profitability. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Proficiency in project management is required to successfully perform organizational strategies and achieve the targeted performance objectives. As for example, the standard process of strategy development begins with goals identification, then continues with target setting, creation of relevant initiatives to achieve the targets and cascading those down into separate projects which correspond to a WBS of the overall strategy program and delivers an individual contribution in achieving the organizational strategy. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The group of factors are related to both project and process management proficiency. Obviously, the higher is the maturityLevel the better developed is the organization.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The group of factors are related to both project and process management proficiency. Obviously, the higher is the maturityLevel the better developed is the organization.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The group of factors are related to both project and process management proficiency. Obviously, the higher is the maturityLevel the better developed is the organization.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The group of factors are related to both project and process management proficiency. Obviously, the higher is the maturityLevel the better developed is the organization.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The group of factors are related to both project and process management proficiency. Obviously, the higher is the maturityLevel the better developed is the organization.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The group of factors are related to both project and process management proficiency. Obviously, the higher is the maturityLevel the better developed is the organization.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"The group of factors are related to both project and process management proficiency. Obviously, the higher is the maturityLevel the better developed is the organization.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""
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
                },
                Description = @"Distribution of roles and responsibilities among employees is a significant indicator of how well balanced is the organization and how well designed is the decision making process. If there is an improperly balanced decision making rights then there could be a situation when some group of managers can have more rights and privileges and others no, the decisions could therefore be unfairly biased. Furthermore, there could be an authoritative management style which is not the best option, especially when the organization is large and diversified enough so that the authoritative decision maker may not have all the right information and skills about the issue to be solved. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"WorkloadLevel or scope of work volume is a significant indicator of how demanded is the service or product of the organization. On the other hand-side it also shows how well organization is managing to deliver the expected work. Obviously the higher is the workloadLevel the better is the utilization coefficient and the higher are the returns on the invesments.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"WorkloadLevel or scope of work volume is a significant indicator of how demanded is the service or product of the organization. On the other hand-side it also shows how well organization is managing to deliver the expected work. Obviously the higher is the workloadLevel the better is the utilization coefficient and the higher are the returns on the invesments.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"Employee empowerment factor is a fundamental indicator of organizational development, i.e., employees are the most important internal resource of the organization. Employees are the one who make the wheel running and without properly motivated, satisfied and engaged employees no business can exist for a long time. Therefore, the higher is the empowermentLevel the more effective is the decision making process and the more competitive is the organization.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"Regulatory documents in organization is another indicator of its well development, i.e., the more informational guidelines are given by the company the more transparrent are the processes and the easier it becomes to perform the work. This is especially important for newcomers, as usually they know little about the internal processes of the organization and therefore in order to eliminate the volume of mistakes and ease the integration process it is very important to have such documentation in place. On the other hand-side, the more there is aLevel of regulation within the organization the more independent the organization becomes from its employees and the easier for organization to change the employee if someone decides to leave.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The rates of different factors determine overall environment within the organization related to employee engagement and relations to the other colleagues within the same company. Obviously, as was stated in the previous explanation the higher is the employees satisfaction, loyalty, motivation, and the lower are the complaints or negative attitudeLevels the better is the overall organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The rates of different factors determine overall environment within the organization related to employee engagement and relations to the other colleagues within the same company. Obviously, as was stated in the previous explanation the higher is the employees satisfaction, loyalty, motivation, and the lower are the complaints or negative attitudeLevels the better is the overall organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The rates of different factors determine overall environment within the organization related to employee engagement and relations to the other colleagues within the same company. Obviously, as was stated in the previous explanation the higher is the employees satisfaction, loyalty, motivation, and the lower are the complaints or negative attitudeLevels the better is the overall organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The rates of different factors determine overall environment within the organization related to employee engagement and relations to the other colleagues within the same company. Obviously, as was stated in the previous explanation the higher is the employees satisfaction, loyalty, motivation, and the lower are the complaints or negative attitudeLevels the better is the overall organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The rates of different factors determine overall environment within the organization related to employee engagement and relations to the other colleagues within the same company. Obviously, as was stated in the previous explanation the higher is the employees satisfaction, loyalty, motivation, and the lower are the complaints or negative attitudeLevels the better is the overall organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The rates of different factors determine overall environment within the organization related to employee engagement and relations to the other colleagues within the same company. Obviously, as was stated in the previous explanation the higher is the employees satisfaction, loyalty, motivation, and the lower are the complaints or negative attitudeLevels the better is the overall organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The rates of different factors determine overall environment within the organization related to employee engagement and relations to the other colleagues within the same company. Obviously, as was stated in the previous explanation the higher is the employees satisfaction, loyalty, motivation, and the lower are the complaints or negative attitudeLevels the better is the overall organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The rates of different factors determine overall environment within the organization related to employee engagement and relations to the other colleagues within the same company. Obviously, as was stated in the previous explanation the higher is the employees satisfaction, loyalty, motivation, and the lower are the complaints or negative attitudeLevels the better is the overall organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The rates of different factors determine overall environment within the organization related to employee engagement and relations to the other colleagues within the same company. Obviously, as was stated in the previous explanation the higher is the employees satisfaction, loyalty, motivation, and the lower are the complaints or negative attitudeLevels the better is the overall organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The rates of different factors determine overall environment within the organization related to employee engagement and relations to the other colleagues within the same company. Obviously, as was stated in the previous explanation the higher is the employees satisfaction, loyalty, motivation, and the lower are the complaints or negative attitudeLevels the better is the overall organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The rates of different factors determine overall environment within the organization related to employee engagement and relations to the other colleagues within the same company. Obviously, as was stated in the previous explanation the higher is the employees satisfaction, loyalty, motivation, and the lower are the complaints or negative attitudeLevels the better is the overall organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"Evaluation of professional competencies is required to reveal the missing points and lacking skills within different employees. If not carried out on a systematic basis the employees may miss the latest developments in the industry and may loose the competitive advantage. Therefore, it is advised that there should be a systemic review process combined with external consultancy and training activities to be able to utilize the best practices and stay competitive. Obviously depending on the industry the frequency of such review activities may be different.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

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
                },
                Description = @"The unitsLevel of effectiveness means the % of correct decisions / activities / reports / operations / achievement of targeted results and etc. It is measured on an individual structural unitLevel to understand how well each separate unit / team / function / department / division and etc has been able to achieve the desired objectives. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 81,
                Text = @"Level of communication effectiveness?",
                Variants = new List<string>() {
                     @"N/A",
                @"Frequent conflicts involving top management",
                @"Communication only through managers",
                @"Created working groups / teams",
                @"There are working groups / teams plus applied comprehensive mechanisms of oral and written communication",
                @"There are working groups / teams, comprehensive oral and written communication mechanisms as well as there is an open access to top management, i.e., an environment of trust and openness is created"
                },
                Description = @"The communicationLevel is important indicator of how ready are the employees to share the relevant information with appropriate employees within the organization. The indicator reflects the working environment in terms of trust, ease of communication and fair, objective treatment among all employees.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 82,
                Text = @"How often are operational meetings held at the Company?",
                Variants = new List<string>() {
                     @"N/A",
                @"Just meeting as needed (which ones)",
                @"Once a month (which ones)",
                @"Every day (which ones)",
                @"Once a week (which ones)",
                @"All meetings are strictly regulated."
                },
                Description = @"The frequency of operational meetings are as important as the strategic meetings, even more important as without such meeting there is no opportunity to effectively manage the day-to-day operations. Therefore, organization should have an established calendar and timeline for such meetings and employees should be aware of that in order to be well prepared and ready to report the current situation, exisitng problems and forecasts to find timely solutions. Apparently from company to company this frequency may differ and the content of such meetings may be different, however, generally spealing the higher is the frequency the more chances to be more effective and efficient.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 83,
                Text = @"What % of employees is aware of your organization’s value to customers?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"Organizational value contribution is a very important element in organizational management process. In order to become a sustainable business entity the organization must be able to make aware all its employees about the value that it delivers to customers and what is the role of each employee in this process. Hence, the higher isLevel of awareness the better is the organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 84,
                Text = @"What % of top management believes in transparency of the organization’s strategy for the next 1-2 years?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"Transparrent organizational strategy is very important if any organization wants to successfully deliver the strategy. In other words, the higher the % of those managers who believe that the strategy is transparrent enough the higher are the chances that all employees among the organization will understand the strategy and successfully deliver their parts in it.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 85,
                Text = @"What % of employees know about the priorities and goals of the organization for this year?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"Priorities and goals for a year ahead are very important elements of strategy or plan for the year. Therefore, the more % of employees are aware of them the higher is the chance that they will deliver the expected results.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 86,
                Text = @"What % of employees agree that working time is enough to efficiently and effectively perform all the tasks assigned?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"The working time is important as it simply indicatesLevel of workload of the employees, if there are a lot of complaints about the shortage of time to deliver the work, then it means that there is no effective work distribution system within the organization. Therefore, it is very important to balance the work and distribute it as evenly as possible.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 87,
                Text = @"What % of employees agree that priorities are stable and do not change without cause?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"Priority in work delivery is another important factor, as if there is no work prioritisation, then some works could be done when it is already too late and business will lose the desired opportunities. On the other hand-side, it may even delay the whole production process and lead to a major problem in other parts of business. Thus, it is always important to know the cause of change in prioritisation and do not change them without necessity. Eventually the higher is the % of employees who agree that the priorities are stable the higher are the chances to get the expected business results.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 88,
                Text = @"In what % of the meetings were the objectives and written agenda stated in advance?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"The meeting just for meeting is not an effective or productive way to solve the problems and guide the organization. Therefore, it is important to always have an agenda and objectives from the meeting in advance, to enable the participants to be well prepared and find the solution at the meeting. Therefore, the higher is the %Level the better for the organizational performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 89,
                Text = @"At which % of the meetings are all the “right” people present?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"The higher is the %-ge of participation of relevant people at meetings the higher is the probability that the meeting will be more productive and the problems will find the required solutions, thus enabling better performance of the organization. Generally, there should be a pre-defined list of attendees for each type of meeting that organization may organize.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 90,
                Text = @"What % of meetings starts and ends on time?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"This is another indicator of how well organized is the process of meeting, i.e., if all participants are well prepared and there is a relevant agenda and objectives of the meeting stated in advance, then there is no reason either to start or finish later the meeting. Otherwise, the is no sense in agenda and list of attendees and the time management effectiveness is lost. Therefore, the higher is the %-geLevel in this indicator the higher is the performance of the organization.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 91,
                Text = @"What % of  employees are  highly effective  in solving problems?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"The higher is the % of the employees who can effectively solve the existing problems the higher is the organizational performance. In order to achieve this it is a must that the organization has a knowledge management system and employees practice some learning and development programs.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 92,
                Text = @"What % of employees consistently determine the  root  causes  (compared  with  the  transition  to “solutions”)?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"The higher the % of the employees who can find the root causes of the problems the higher is the % of the employees who can effectively solve the existing problems. In other words, it is not enough to simply solve the problem it is necessary to identify the root causes, so that the current problem is prevented from happening again.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.OrganisationalStructure,
                number = 93,
                Text = @"What % of employees are actively involved in developing improved processes?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"The higher is the engagement of employees in improving the business processes the higher is the business performance outcome, as this means that there is a continuous improvement program running throught the organization, which will eventually lead to better performance.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 94,
                Text = @"The level of effectiveness of the sales system? (check all relevant answers)",
                Variants = new List<string>() {
                     @"N/A",
                @"Spontaneous sales (Customers find you)",
                @"There are ready-made commercial offer templates",
                @"The same as in 2) plus created promotional materials (including a database of completed projects / works)",
                @"The same as in 3) plus there is a CRM system (with detailed categorization of customers)",
                @"The same as in 4) plus there is a continuous search / participation in tenders"
                },
                Description = @"The sales effectivenss is very important factor and the more professional the sales employees are the higher is the outcome of business. ",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 95,
                Text = @"What is level of customer service?",
                Variants = new List<string>() {
                     @"N/A",
                @"Most of the focus is on solving a customer's problem once it occurs, but little emphasis is placed on trying to improve the overall process and prevent the same problem from recurring again. Customer feedback is poor and rarely considered when developing service and products.  Products and services have bad reputations for quality in the eyes of the customer",
                @"Most customers are identified; however there is no overall system for collecting continous customer feedback. Quality standards are improved for some products and services. The future needs of customers are not yet considered. New ideas for improving customer service are not easily accepted. Some customer groups are segmented and managed differently",
                @"Customer surveys are used throughout the company for continuous improvements. Employees who are in direct contact with customers are well trained for servicing the customer base. The company promotes customer awareness and satisfaction. Systems are in place for moving customer feedback into various product and service lines",
                @"Effective customer feedback systems are in place, ensuring continuous improvement. Management is very focused on the customer, promoting programs that enhance customer relationships. New ideas on how to improve customer service are easily introduced. Customer related training is available and customers have easy access to resources for resolving their issues",
                @"Customer metrics (surveys, focus groups, exit interviews, etc.) reveal very strong performance in meeting customer needs. Similarly, measurements of  customer repurchase patterns and other behavior relative to the competition are also very favorable. Management is very focused on the customer. Customer service and relationship training and development is mandated throughout the entire company. Products and services have reputations for quality in the eyes of the customer"
                },
                Description = @"Customer service is very important to retain the customers and increase the profits of the organization. Basically, customer service is the same as customer relationship management. Therefore, the higher is the customer serviceLevel the higher will be the CRMLevel and organizational profit.",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 96,
                Text = @"How competitive is Your main industry? (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 97,
                Text = @"How competitive is Your price compared to major players? (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 98,
                Text = @"How competitive is Your Quality of Products / Services? (on a 5-point scale, 5 - the highest ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 99,
                Text = @"What is the market share?",
                Variants = new List<string>() {
                     @"N/A",
                @"Less than 20%",
                @"From 20 to 40%",
                @"From 41 to 60%",
                @"From 61 to 80%",
                @"More than 80%"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 100,
                Text = @"To what extent Increasing production / service volume influence the  potential  to  increase  the  share  of  regular customers of the organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 101,
                Text = @"To what extent Development of new products / services influence the  potential  to  increase  the  share  of  regular customers of the organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 102,
                Text = @"To what extent Improving the quality of products / services influence the  potential  to  increase  the  share  of  regular customers of the organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 103,
                Text = @"To what extent Optimization of business processes influence the  potential  to  increase  the  share  of  regular customers of the organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 104,
                Text = @"To what extent Increasing the level of advertising influence the  potential  to  increase  the  share  of  regular customers of the organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 105,
                Text = @"To what extent Increasing flexibility / agility influence the  potential  to  increase  the  share  of  regular customers of the organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 106,
                Text = @"To what extent Reducing costs influence the  potential  to  increase  the  share  of  regular customers of the organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 107,
                Text = @"To what extent other factors influence the  potential  to  increase  the  share  of  regular customers of the organization? (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 108,
                Text = @"How   is   the   price   of   products   /   services formulated?",
                Variants = new List<string>() {
                     @"N/A",
                @"Intuitively (based on manager's understanding)",
                @"Total Costs of production / service delivery are calculated + Profit Margin ",
                @"Direct Production Costs are calculated + Margin covering fixed costs and Profit contribution is added on top",
                @"Based on market research - detailed target costing study is performed, so that customer gets the most value for what he/she pays for",
                @"There are relevant price developement models and each sales case is based on mutual price agreement"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 109,
                Text = @"What  is  the  approach  to  develop  product  / service range and product / service portfolio of the company?",
                Variants = new List<string>() {
                     @"N/A",
                @"The range does not change",
                @"Intuitively",
                @"At the request of customers",
                @"Similarly as in 3) plus based on market research",
                @"Similarly as in 4) plus tracked product life cycle (BCG)"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 110,
                Text = @"What is the level of market awareness?",
                Variants = new List<string>() {
                     @"N/A",
                @"Based on rumors",
                @"The market is not analyzed / Competitor behavior is copied",
                @"There is a system for regular collection of data and analysis of the market",
                @"The same as in 3) plus a marketing plan was drawn up (with a budget and a clear action plan)",
                @"The same as in 4) plus involves external partners for high-quality analytics"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 111,
                Text = @"Rate customer satisfaction level. (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            tm.Questions.Add(new Question
            {
                id = Guid.NewGuid().ToString(),
                category = Category.MarketingAndSales,
                number = 112,
                Text = @"Assess the level of perception of the image of the brand or company brands. (on a 5-point scale, 5 - is the minimum ball)",
                Variants = new List<string>() {
                     @"N/A",
                @"1",
                @"2",
                @"3",
                @"4",
                @"5"
                },
                Description = @"",
                Level1 = @"",
                Level2 = @"",
                Level3 = @"",
                Level4 = @"",
                Level5 = @""

            });
            
        }
    }
}
