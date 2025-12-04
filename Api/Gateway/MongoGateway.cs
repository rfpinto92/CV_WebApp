using Shared.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Api.Gateway.Interfaces;
using Api.Gateway.Configuration;
using MongoDB.Bson.Serialization;

namespace Api.Gateway;

public class MongoGateway : IMongoGateway
{
    private readonly IOptions<MongoClientOptions> _options;
    MongoClientSettings _settings;
    MongoClient _client;
    public MongoGateway(IOptions<MongoClientOptions> options)
    {
        _options = options;
        _settings = MongoClientSettings.FromConnectionString(_options.Value.ConnectionString);
        _settings.ServerApi = new ServerApi(ServerApiVersion.V1);
        _client = new MongoClient(_settings);
    }


    public async Task<MainInfoModel> GetCV()
    {
        var mainDataCollection = _client.GetDatabase("cv").GetCollection<MainInfoModel>("mainData");

        var filter = Builders<MainInfoModel>.Filter.Empty;

        var projection = Builders<MainInfoModel>.Projection.Exclude("_id");

        var result = mainDataCollection.Find(filter).Project(projection).ToList().FirstOrDefault();

        BsonSerializer.Deserialize<MainInfoModel>(result);


        return BsonSerializer.Deserialize<MainInfoModel>(result);
    }

    public async Task<IReadOnlyList<SkillModel>> GetSkills()
    {
        var mainDataCollection = _client.GetDatabase("cv").GetCollection<SkillModel>("profeSkills");

        var filter = Builders<SkillModel>.Filter.Empty;

        var projection = Builders<SkillModel>.Projection.Exclude("_id");

        var result = mainDataCollection.Find(filter).Project(projection).ToList();

        return result
        .Select(x => BsonSerializer.Deserialize<SkillModel>(x))
        .ToList();
    }

    public async Task<IReadOnlyList<WorkExperienceModel>> GetWorkExperience()
    {

        var mainDataCollection = _client.GetDatabase("cv").GetCollection<WorkExperienceModel>("workExpecience");
        var filter = Builders<WorkExperienceModel>.Filter.Empty;
        var projection = Builders<WorkExperienceModel>.Projection.Exclude("_id");

        var result = mainDataCollection.Find(filter).Project(projection).ToList();

        return result.Select(x => BsonSerializer.Deserialize<WorkExperienceModel>(x)).ToList()
            .OrderByDescending(x => x.Index).ToList();

    }


    public async Task<IReadOnlyList<EducationModel>> GetEducation()
    {
        var mainDataCollection = _client.GetDatabase("cv").GetCollection<EducationModel>("education");
        var filter = Builders<EducationModel>.Filter.Empty;
        var projection = Builders<EducationModel>.Projection.Exclude("_id");

        var result= mainDataCollection.Find(filter).Project(projection).ToList();
        
        return result
       .Select(x => BsonSerializer.Deserialize<EducationModel>(x))
       .ToList();

    }

    public async Task<IReadOnlyList<PortfolioModel>> GetPortfolio()
    {

        var mainDataCollection = _client.GetDatabase("cv").GetCollection<PortfolioModel>("portfolio");
        var filter = Builders<PortfolioModel>.Filter.Empty;
        var projection = Builders<PortfolioModel>.Projection.Exclude("_id");
        var result = mainDataCollection.Find(filter).Project(projection).ToList();

        return result
       .Select(x => BsonSerializer.Deserialize<PortfolioModel>(x))
       .ToList();

    }

    public async Task<IReadOnlyList<ReferenceModel>> GetReferences()
    {
        var mainDataCollection = _client.GetDatabase("cv").GetCollection<ReferenceModel>("reference");
        var filter = Builders<ReferenceModel>.Filter.Empty;
        var projection = Builders<ReferenceModel>.Projection.Exclude("_id");
        var result = mainDataCollection.Find(filter).Project(projection).ToList();

        return result
       .Select(x => BsonSerializer.Deserialize<ReferenceModel>(x))
       .ToList();
    }


}
