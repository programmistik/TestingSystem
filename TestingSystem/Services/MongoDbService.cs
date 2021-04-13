using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using TestingSystem.Models;

namespace TestingSystem.Services
{
    public class MongoDbService
    {

        private readonly IMongoCollection<TestModel> _testModel;
        private readonly IMongoCollection<OurTest> _test;

        public MongoDbService(IMongoDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _testModel = database.GetCollection<TestModel>(settings.TestModelCollectionName);
            _test = database.GetCollection<OurTest>(settings.TestCollectionName);
        }


        public TestModel GetTestModel()
        {
            var tm = _testModel.Find(c => true).FirstOrDefault();

            return tm; // new TestModel();
        }

        public void UpdateTestModel(string id, TestModel tm) =>
            _testModel.ReplaceOne(testm => testm.id == id, tm);

        public OurTest GetTest(string id) =>
            _test.Find<OurTest>(prof => prof.UserName == id & prof.finished == false).FirstOrDefault();

        public List<OurTest> GetActualTest(string id)
        {
           var list = _test.Find<OurTest>(prof => prof.UserName == id & prof.finished == false).ToList();

            return list; // list.OrderByDescending(t => t.StartDate).First();
        }

        public void UpdateTest(string id, OurTest t) =>
            _test.ReplaceOne(test => test.id == id, t);

        public TestModel Create(TestModel tm)
        {
            _testModel.InsertOne(tm);
            return tm;
        }

        public OurTest CreateTest(OurTest ot)
        {
            _test.InsertOne(ot);
            return ot;
        }
        // id - OurTestId
        public void AddNewAnswer(string id, Answer newAnswer)
        {
            var test = _test.Find<OurTest>(t => t.id == id).FirstOrDefault();
            test.Answers.Add(newAnswer);
            _test.ReplaceOne(t => t.id == id, test);
        }

        public Question GetQuestion(string id)
        {
            var tm = _testModel.Find(c => true).FirstOrDefault();
            var question = tm.Questions.Where(q => q.id == id).FirstOrDefault();

            return question; 
        }

        public List<OurTest> GetAllTests()
        {
            var list = _test.Find(c => true).ToList();

            return list; 
        }

        //public void Remove(Profile profIn) =>
        //    _profile.DeleteOne(prof => prof.AppUserId == profIn.Id);

        //public void Remove(string id) =>
        //    _profile.DeleteOne(prof => prof.AppUserId == id);
    }
}
