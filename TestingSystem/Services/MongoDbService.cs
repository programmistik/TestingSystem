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

        //public List<Category> GetCategories() =>
        //    _category.Find(c => true).ToList();

        //public Category CreateCategory(Category cat)
        //{
        //    _category.InsertOne(cat);
        //    return cat;
        //}

        public TestModel GetTestModel()
        {
            var tm = _testModel.Find(c => true).FirstOrDefault();

            return tm; // new TestModel();
        }

        public void UpdateTestModel(string id, TestModel tm) =>
            _testModel.ReplaceOne(testm => testm.id == id, tm);

        //public Profile Get(string id) =>
        //    _profile.Find<Profile>(prof => prof.AppUserId == id).FirstOrDefault();

        public TestModel Create(TestModel tm)
        {
            _testModel.InsertOne(tm);
            return tm;
        }

        //public void Update(string id, Profile profIn) =>
        //    _profile.ReplaceOne(prof => prof.Id == id, profIn);

        //public void Remove(Profile profIn) =>
        //    _profile.DeleteOne(prof => prof.AppUserId == profIn.Id);

        //public void Remove(string id) =>
        //    _profile.DeleteOne(prof => prof.AppUserId == id);
    }
}
