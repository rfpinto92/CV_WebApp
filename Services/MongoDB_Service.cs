using CV_WebApp.Models;
using MongoDB.Driver;
using System.Text.Json;
using MongoDB.Bson;
using CV_WebApp.Gateway;
using CV_WebApp.Gateway.Interface;
using CV_WebApp.Services.Interface;
namespace CV_WebApp.Services;

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
            var result = await _gateway.GetCV();

            if (result.Count > 0)
            {
                return result[0];
            }
            else
            {
                return new MainInfoModel();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return new MainInfoModel();
        }
    }

    public async Task<List<SkillModel>> GetSkills()
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

    public async Task<List<WorkExperienceModel>> GetWorkExperience()
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


    public async Task<List<EducationModel>> GetEducation()
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

    public async Task<List<PortfolioModel>> GetPortfolio()
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

    public async Task<List<ReferenceModel>> GetReferences()
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
