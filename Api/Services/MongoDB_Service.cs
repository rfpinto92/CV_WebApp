using Shared.Models;
using MongoDB.Driver;
using System.Text.Json;
using MongoDB.Bson;
using Api.Services.Interface;
using Api.Gateway.Interfaces;
namespace Api.Services;

public class MongoDB_Service : IMongoDB_Service
{
    private readonly IMongoGateway _gateway;

    public MongoDB_Service(IMongoGateway mongoGateway)
    {
        _gateway = mongoGateway;
    }


    public async Task<MainInfoModel> GetMainInfo()
    {

        try
        {
            return await _gateway.GetCV();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return new MainInfoModel();
        }
    }

    public async Task<IReadOnlyList<SkillModel>> GetSkills()
    {
        try
        {
            return await _gateway.GetSkills();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return new List<SkillModel> { };
        }
    }

    public async Task<IReadOnlyList<WorkExperienceModel>> GetWorkExperience()
    {
        try
        {
            return await _gateway.GetWorkExperience();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return new List<WorkExperienceModel> { };
        }
    }


    public async Task<IReadOnlyList<EducationModel>> GetEducation()
    {
        try
        {
            return await _gateway.GetEducation();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return new List<EducationModel> { };
        }
    }

    public async Task<IReadOnlyList<PortfolioModel>> GetPortfolio()
    {
        try
        {
            return await _gateway.GetPortfolio();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return new List<PortfolioModel> { };
        }
    }

    public async Task<IReadOnlyList<ReferenceModel>> GetReferences()
    {
        try
        {
            return await _gateway.GetReferences();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return new List<ReferenceModel> { };
        }
    }

}
