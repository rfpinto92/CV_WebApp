using CV_WebApp.Models;

namespace CV_WebApp.Services.Interface
{
    public interface IMongoDB_Service
    {
        Task<MainInfoModel> GetMainInfo();
        Task<List<SkillModel>> GetSkills();
        Task<List<WorkExperienceModel>> GetWorkExperience();
        Task<List<EducationModel>> GetEducation();
       Task<List<PortfolioModel>> GetPortfolio();
        Task<List<ReferenceModel>> GetReferences();
    }
}
