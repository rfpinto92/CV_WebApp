using CV_WebApp.Models;

namespace CV_WebApp.Gateway.Interface;

public interface IMongoGateway
{
    Task<IReadOnlyList<MainInfoModel>> GetCV();
    Task<List<SkillModel>> GetSkills();
    Task<List<WorkExperienceModel>> GetWorkExperience();
    Task<List<EducationModel>> GetEducation();
    Task<List<PortfolioModel>> GetPortfolio();
    Task<List<ReferenceModel>> GetReferences();
}
