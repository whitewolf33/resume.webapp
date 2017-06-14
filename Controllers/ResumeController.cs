using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using resume_webapp.Models;
using Resume.Webapp.Services.Interfaces;
using System;
using System.Collections.Generic;
using Resume.Webapp.Models;

namespace Resume.Webapp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ResumeController : Controller
    {
        private IResumeService _resumeService;

        public ResumeController(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }
        //[Route("api/mobile/v1.0/[action]")]
        public async Task<List<Timeline>> GetTimelines(string userId)
        {
            try
            {
               var list = await _resumeService.GetTimelines(userId);
                return list;

            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Qualification>> GetQualifications(string userId)
        {
            try
            {
                var list = await _resumeService.GetQualifications(userId);
                return list;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Work>> GetWorkExperiences(string userId)
        {
            try
            {
                var list = await _resumeService.GetWorkExperiences(userId);
                return list;

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public async Task<List<Project>> GetProjects(string userId)
        {
            try
            {
                var list = await _resumeService.GetProjectsList(userId);
                return list;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<TechnicalSkill>> GetTechnicalSkills(string userId)
        {
            try
            {
                var list = await _resumeService.GetTechnicalSkills(userId);
                return list;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
