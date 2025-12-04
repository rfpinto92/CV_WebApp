using Shared.Models;

namespace Api.Services.Interface;

public interface IMongoDB_Service
{
    Task<MainInfoModel> GetMainInfo();
    Task<IReadOnlyList<SkillModel>> GetSkills();
    Task<IReadOnlyList<WorkExperienceModel>> GetWorkExperience();
    Task<IReadOnlyList<EducationModel>> GetEducation();
   Task<IReadOnlyList<PortfolioModel>> GetPortfolio();
    Task<IReadOnlyList<ReferenceModel>> GetReferences();
}
