using Resume.Webapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Webapp.Services.Interfaces
{
    public interface IResumeService
    {
        Task<List<Timeline>> GetTimelines(string userId);

        Task<List<Qualification>> GetQualifications(string userId);

        Task<List<Work>> GetWorkExperiences(string userId);

        Task<List<Project>> GetProjectsList(string userId);

        Task<List<TechnicalSkill>> GetTechnicalSkills(string userId);

    }
}
