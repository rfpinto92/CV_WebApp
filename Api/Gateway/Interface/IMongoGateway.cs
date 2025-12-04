using Shared.Models;

namespace Api.Gateway.Interfaces;

public interface IMongoGateway
{
    Task<MainInfoModel> GetCV();
    Task<IReadOnlyList<SkillModel>> GetSkills();
    Task<IReadOnlyList<WorkExperienceModel>> GetWorkExperience();
    Task<IReadOnlyList<EducationModel>> GetEducation();
    Task<IReadOnlyList<PortfolioModel>> GetPortfolio();
    Task<IReadOnlyList<ReferenceModel>> GetReferences();
}
