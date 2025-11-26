using CV_WebApp.Gateway.Configuration;
using CV_WebApp.Gateway.Interface;
using CV_WebApp.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CV_WebApp.Gateway
{
    public class MongoGateway : IMongoGateway
    {
        private readonly IOptions<MongoClientOptions> _options;
        MongoClientSettings _settings;
        MongoClient _client;
        public MongoGateway(IOptions<MongoClientOptions>options  ) 
        {
            _options = options;
            _settings = MongoClientSettings.FromConnectionString(_options.Value.ConnectionString);
            _settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            _client = new MongoClient(_settings);
        }


        public async Task<IReadOnlyList<MainInfoModel>> GetCV()
        {
            var mainDataCollection = _client.GetDatabase("cv").GetCollection<MainInfoModel>("mainData");

            var filter = Builders<MainInfoModel>.Filter.Empty;

            return mainDataCollection.Find(filter).ToList();
        }

        public async Task<List<SkillModel>> GetSkills()
        {
            var mainDataCollection = _client.GetDatabase("cv").GetCollection<SkillModel>("profeSkills");
            var filter = Builders<SkillModel>.Filter.Empty;

            return mainDataCollection.Find(filter).ToList();
        }

        public async Task<List<WorkExperienceModel>> GetWorkExperience()
        {

            var mainDataCollection = _client.GetDatabase("cv").GetCollection<WorkExperienceModel>("workExpecience");
            var filter = Builders<WorkExperienceModel>.Filter.Empty;
            var result = mainDataCollection.Find(filter).ToList().OrderByDescending(x => x.Index);
            return (result.ToList());
        }


        public async Task<List<EducationModel>> GetEducation()
        {
            var mainDataCollection = _client.GetDatabase("cv").GetCollection<EducationModel>("education");
            var filter = Builders<EducationModel>.Filter.Empty;

            return mainDataCollection.Find(filter).ToList();
        }

        public async Task<List<PortfolioModel>> GetPortfolio()
        {

            var mainDataCollection = _client.GetDatabase("cv").GetCollection<PortfolioModel>("portfolio");
            var filter = Builders<PortfolioModel>.Filter.Empty;

            return mainDataCollection.Find(filter).ToList();
        }

        public async Task<List<ReferenceModel>> GetReferences()
        {
            var mainDataCollection = _client.GetDatabase("cv").GetCollection<ReferenceModel>("reference");
            var filter = Builders<ReferenceModel>.Filter.Empty;

            return mainDataCollection.Find(filter).ToList();
        }


    }
}
