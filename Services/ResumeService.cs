using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Resume.Webapp.Models;
using Resume.Webapp.Services.Interfaces;

namespace Resume.Webapp.Services
{
    public class ResumeService : IResumeService
    {

        #region Technical Skills
        TechnicalSkill cSharp = new TechnicalSkill { Name = "C#", Strength = 3, Type ="Programming Language" };
        //TechnicalSkill objC = new TechnicalSkill { Name = "Objective C" };
        TechnicalSkill xaml = new TechnicalSkill { Name = "XAML",  Strength = 3, Type = "Scripting Language"};
        TechnicalSkill js = new TechnicalSkill { Name = "JavaScript", Strength = 3, Type = "Scripting Language" };
        TechnicalSkill html = new TechnicalSkill { Name = "HTML 5.0", Strength = 3, Type = "Scripting Language" };
        TechnicalSkill css = new TechnicalSkill { Name = "CSS 3.0", Strength = 2, Type = "Scripting Language" };

        TechnicalSkill asp = new TechnicalSkill { Name = "ASP", Strength = 1, Type = "Web Technology" };
        TechnicalSkill aspMvc = new TechnicalSkill { Name = "ASP.Net MVC", Strength = 3, Type = "Web Technology" };
        TechnicalSkill angJs = new TechnicalSkill { Name = "angularJS", Strength = 3, Type = "Web Technology" };
        TechnicalSkill angJs4 = new TechnicalSkill { Name = "angularJS 4", Strength = 2, Type = "Web Technology" };
        TechnicalSkill webApi = new TechnicalSkill { Name = "ASP.Net Web API", Strength = 3, Type = "Web Technology" };
        TechnicalSkill jQuery = new TechnicalSkill { Name = "jQuery", Strength = 2, Type = "Web Technology" };
        TechnicalSkill knockJs = new TechnicalSkill { Name = "Knockout.js", Strength = 2, Type = "Web Technology" };
        TechnicalSkill winForms = new TechnicalSkill { Name = "WinForms", Strength = 2, Type = "Windows Technology" };
        TechnicalSkill wpf = new TechnicalSkill { Name = "WPF", Strength = 3, Type = "Windows Technology" };
        TechnicalSkill win8Apps = new TechnicalSkill { Name = "Win 8.1 Apps", Strength = 3, Type = "Windows Technology" };
        TechnicalSkill uwp = new TechnicalSkill { Name = "UWP", Strength = 2, Type = "Windows Technology" };
        TechnicalSkill iOS = new TechnicalSkill { Name = "iOS", Strength = 3, Type = "Mobile Technology" };
        TechnicalSkill android = new TechnicalSkill { Name = "Android", Strength = 3, Type = "Mobile Technology" };
        TechnicalSkill wp8 = new TechnicalSkill { Name = "WP 8", Strength = 3, Type = "Mobile Technology" };
        TechnicalSkill winCE = new TechnicalSkill { Name = "Windows CE 6.5", Strength = 3, Type = "Mobile Technology" };
        TechnicalSkill tfs = new TechnicalSkill { Name = "TFS", Strength = 3, Type = "Source Control" };
        TechnicalSkill git = new TechnicalSkill { Name = "Git", Strength = 3, Type = "Source Control" };
        TechnicalSkill dotNetCore = new TechnicalSkill { Name = ".Net Core", Strength = 3, Type = "Cross Platform" };
        TechnicalSkill mono = new TechnicalSkill { Name = "Xamarin.iOS", Strength = 3, Type = "Cross Platform" };
        TechnicalSkill monoDroid = new TechnicalSkill { Name = "Xamarin.Droid", Strength = 3, Type = "Cross Platform" };
        TechnicalSkill xamForms = new TechnicalSkill { Name = "Xamarin Forms", Strength = 3, Type = "Cross Platform" };
        TechnicalSkill vs = new TechnicalSkill { Name = "Visual Studio", Strength = 3, Type = "IDE" };
        TechnicalSkill xs = new TechnicalSkill { Name = "Xamarin Studio", Strength = 3, Type = "Cross Platform" };
        TechnicalSkill xcode = new TechnicalSkill { Name = "XCode", Strength = 2, Type = "Cross Platform" };
        TechnicalSkill sketch = new TechnicalSkill { Name = "Sketch", Strength = 2, Type = "UX Tools" };
        TechnicalSkill invision = new TechnicalSkill { Name = "InvisionApp", Strength = 2, Type = "UX Tools" };
        TechnicalSkill zepplin = new TechnicalSkill { Name = "Zepplin", Strength = 3, Type = "UX Tools" };
        TechnicalSkill balsamiq = new TechnicalSkill { Name = "Balsamiq", Strength = 2, Type = "UX Tools" };
        TechnicalSkill azure = new TechnicalSkill { Name = "Microsoft Azure - PaaS, SaaS, IaaS", Strength = 3, Type = "Cloud Solutions" };
        TechnicalSkill testCloud = new TechnicalSkill { Name = "Xamarin Test Cloud", Strength = 3, Type = "Testing Framework" };
        TechnicalSkill xamTestRec = new TechnicalSkill { Name = "Xamarin UI Testing", Strength = 3, Type = "Testing Framework" };
        TechnicalSkill nUnit = new TechnicalSkill { Name = "NUnit Unit Testing", Strength = 3, Type = "Testing Framework" };
        TechnicalSkill msUnit = new TechnicalSkill { Name = "MS Unit Testing", Strength = 3, Type = "Testing Framework" };
        TechnicalSkill jsUnit = new TechnicalSkill { Name = "Jasmin Unit Testing", Strength = 3, Type = "Testing Framework" };
        TechnicalSkill specFlow = new TechnicalSkill { Name = "SpecFlow API Testing", Strength = 3, Type = "Testing Framework" };
        TechnicalSkill waterFall = new TechnicalSkill { Name = "Waterfall", Strength = 3, Type = "Development Methodology" };
        TechnicalSkill scrum = new TechnicalSkill { Name = "Agile - Scrum", Strength = 3, Type = "Development Methodology" };
        TechnicalSkill kanban = new TechnicalSkill { Name = "Agile - Kanban", Strength = 3, Type = "Development Methodology" };
        TechnicalSkill sql = new TechnicalSkill { Name = "SQL Server" };
        TechnicalSkill sqlite = new TechnicalSkill { Name = "SQLite" };
        #endregion


        #region Work

        Work _telstra;

        Work  _city;

        Work  _fred;

        Work  _cadability;

        #endregion

        public static List<Project> Projects { get; set; } = new List<Project>();

        public ResumeService()
        {

            _telstra = new Work
            {
                Index = 1,
                Company = "Telstra Health",
                Address = " Level 3, 222, QV Building, Melbourne, VIC - 3000",
                StartDate = new DateTime(2015, 12, 07),
                EndDate = DateTime.Today,
                Latitude = -37.8106622,
                Longitude = 144.9635376,
                CompanyLogo = "thealth.png"
            };
            _city = new Work
            {
                Index = 2,
                Company = "City Holdings Aus Pty Ltd",
                Address = " Level 3, 222, QV Building, Melbourne, VIC - 3000",
                StartDate = new DateTime(2015, 06, 01),
                EndDate = new DateTime(2015, 12, 01),
                Latitude = -37.9194124,
                Longitude = 145.1577831,
                CompanyLogo = "city.png"
            };
            _fred = new Work
            {
                Index = 3,
                Company = "FRED IT Group",
                Address = " Level 3, 222, QV Building, Melbourne, VIC - 3000",
                StartDate = new DateTime(2008, 01, 01),
                EndDate = new DateTime(2015, 01, 01),
                Latitude = -37.7993071,
                Longitude = 144.9976491,
                CompanyLogo = "fred.png"
            };
            _cadability = new Work
            {
                Index = 4,
                Company = "Cadability Pty Ltd",
                Address = " Level 3, 222, QV Building, Melbourne, VIC - 3000",
                StartDate = new DateTime(2008, 01, 01),
                EndDate = new DateTime(2015, 06, 01),
                Latitude = -37.7993071,
                Longitude = 144.9976491,
                CompanyLogo = "fred.png"
            };

            Project cpc = new Project();
            cpc.Name = "Care Plan Connect";
            cpc.Logo = "cpc.png";
            cpc.StartDate = new DateTime(2015, 12, 01);
            cpc.EndDate = new DateTime(2016, 06, 01);
            //cpc.Duration = "Dec 2015 - June 2016";

            cpc.ShortDescription = "iOS and Android App";
            cpc.Description = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            //cpc.Technology = "Xamarin Forms, Web API, Azure PaaS SQL Server";
            cpc.Technologies = new List<TechnicalSkill>
                    {
                        xamForms,webApi, azure, sql, sqlite
                    };
            cpc.Responsibilities = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            cpc.Company = _telstra;
            _telstra.Projects.Add(cpc);

            Project cc = new Project();
            cc.Name = "Consumer Channel";
            cc.Logo = "consumerchannel.png";
            cpc.StartDate = new DateTime(2016, 07, 01);
            cpc.EndDate = new DateTime(2016, 09, 01);
            //cc.Duration = "July 2016 - September 2016";

            cc.ShortDescription = "iOS and Android App";
            cc.Description = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            //cc.Technology = "Xamarin Forms, Web API, Azure PaaS SQL Server";
            cc.Technologies = new List<TechnicalSkill> { xamForms, webApi, azure, sql };
            cc.Responsibilities = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            cc.Company = _telstra;
            _telstra.Projects.Add(cc);

            Project hg = new Project();
            hg.Name = "HealthNow";
            hg.Logo = "healthgateway.png";
            hg.StartDate = new DateTime(2016, 09, 01);
            hg.EndDate = DateTime.Today;
            //hg.Duration = "September 2016 - Till date";
            hg.ShortDescription = "iOS and Android App";
            hg.Description = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            //hg.Technology = "Xamarin Forms, Web API, Azure PaaS SQL Server";
            hg.Technologies = new List<TechnicalSkill> { xamForms, webApi, azure, sql };
            hg.Responsibilities = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            hg.Company = _telstra;
            _telstra.Projects.Add(hg);

            Project myAssets = new Project();
            myAssets.Name = "MyAssets";
            myAssets.Logo = "healthgateway.png";
            myAssets.StartDate = new DateTime(2015, 06, 01);
            myAssets.EndDate = new DateTime(2015, 08, 01);
            //myAssets.Duration = "September 2016 - Till date";
            myAssets.ShortDescription = "iOS and Android App";
            myAssets.Description = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            //hg.Technology = "Xamarin Forms, Web API, Azure PaaS SQL Server";
            myAssets.Technologies = new List<TechnicalSkill> { xamForms, webApi, azure, sql };
            myAssets.Responsibilities = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            myAssets.Company = _city;
            _city.Projects.Add(myAssets);

            Project myFM = new Project();
            myFM.Name = "MyFM";
            myFM.Logo = "healthgateway.png";
            myFM.StartDate = new DateTime(2015, 06, 01);
            myFM.EndDate = new DateTime(2015, 08, 01);
            myFM.ShortDescription = "iOS and Android App";
            myFM.Description = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            //hg.Technology = "Xamarin Forms, Web API, Azure PaaS SQL Server";
            myFM.Technologies = new List<TechnicalSkill> { xamForms, webApi, azure, sql };
            myFM.Responsibilities = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            myFM.Company = _city;
            _city.Projects.Add(myFM);


            Project myAvailability = new Project();
            myAvailability.Name = "MyAvailability";
            myAvailability.Logo = "healthgateway.png";
            myAvailability.StartDate = new DateTime(2015, 06, 01);
            myAvailability.EndDate = new DateTime(2015, 08, 01);
            //myAvailability.Duration = "September 2016 - Till date";
            myAvailability.ShortDescription = "iOS and Android App";
            myAvailability.Description = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            //hg.Technology = "Xamarin Forms, Web API, Azure PaaS SQL Server";
            myAvailability.Technologies = new List<TechnicalSkill> { xamForms, webApi, azure, sql };
            myAvailability.Responsibilities = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            myAvailability.Company = _city;
            _city.Projects.Add(myAvailability);

            Project fredNxtOffice = new Project();
            fredNxtOffice.Name = "Fred Nxt Office";
            fredNxtOffice.Logo = "healthgateway.png";
            fredNxtOffice.StartDate = new DateTime(2015, 06, 01);
            fredNxtOffice.EndDate = new DateTime(2015, 08, 01);
            //fredNxtOffice.Duration = "September 2016 - Till date";
            fredNxtOffice.ShortDescription = "iOS and Android App";
            fredNxtOffice.Description = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            //hg.Technology = "Xamarin Forms, Web API, Azure PaaS SQL Server";
            fredNxtOffice.Technologies = new List<TechnicalSkill> { xamForms, webApi, azure, sql };
            fredNxtOffice.Responsibilities = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            fredNxtOffice.Company = _fred;
            _fred.Projects.Add(fredNxtOffice);


            Project fredOffice = new Project();
            fredOffice.Name = "Fred Office";
            fredOffice.Logo = "healthgateway.png";
            fredOffice.StartDate = new DateTime(2015, 06, 01);
            fredOffice.EndDate = new DateTime(2015, 08, 01);
            //fredOffice.Duration = "September 2016 - Till date";
            fredOffice.ShortDescription = "iOS and Android App";
            fredOffice.Description = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            //hg.Technology = "Xamarin Forms, Web API, Azure PaaS SQL Server";
            fredOffice.Technologies = new List<TechnicalSkill> { xamForms, webApi, azure, sql };
            fredOffice.Responsibilities = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            fredOffice.Company = _fred;
            _fred.Projects.Add(fredOffice);

            Project fredRapid = new Project();
            fredRapid.Name = "Fred Rapid";
            fredRapid.Logo = "healthgateway.png";
            fredRapid.StartDate = new DateTime(2015, 06, 01);
            fredRapid.EndDate = new DateTime(2015, 08, 01);
            //fredRapid.Duration = "September 2016 - Till date";
            fredRapid.ShortDescription = "iOS and Android App";
            fredRapid.Description = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            //hg.Technology = "Xamarin Forms, Web API, Azure PaaS SQL Server";
            fredRapid.Technologies = new List<TechnicalSkill> { xamForms, webApi, azure, sql };
            fredRapid.Responsibilities = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            fredRapid.Company = _fred;
            _fred.Projects.Add(fredRapid);

            Project scoringSystem = new Project();
            scoringSystem.Name = "Data Capture Systems";
            scoringSystem.Logo = "healthgateway.png";
            scoringSystem.StartDate = new DateTime(2015, 06, 01);
            scoringSystem.EndDate = new DateTime(2015, 08, 01);
            //scoringSystem.Duration = "September 2016 - Till date";
            scoringSystem.ShortDescription = "iOS and Android App";
            scoringSystem.Description = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            //hg.Technology = "Xamarin Forms, Web API, Azure PaaS SQL Server";
            scoringSystem.Technologies = new List<TechnicalSkill> { xamForms, webApi, azure, sql };
            scoringSystem.Responsibilities = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            scoringSystem.Company = _cadability;
            _cadability.Projects.Add(scoringSystem);

            Project delivery = new Project();
            delivery.Name = "Data Delivery Systems";
            delivery.Logo = "healthgateway.png";
            delivery.StartDate = new DateTime(2015, 06, 01);
            delivery.EndDate = new DateTime(2015, 08, 01);
            //delivery.Duration = "September 2016 - Till date";
            delivery.ShortDescription = "iOS and Android App";
            delivery.Description = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            //hg.Technology = "Xamarin Forms, Web API, Azure PaaS SQL Server";
            delivery.Technologies = new List<TechnicalSkill> { xamForms, webApi, azure, sql };
            delivery.Responsibilities = "Care Plan Connect is a smarter way of helping Type 2 Diabetes patients keep their blood sugar level under control.....";
            delivery.Company = _cadability;
            _cadability.Projects.Add(delivery);

            Projects = _telstra.Projects.Union(_city.Projects).Union(_fred.Projects).Union(_cadability.Projects).ToList();
        }

        public async Task<List<Timeline>> GetTimelines(string userId)
        {
            var timelineList = new List<Timeline>();
            timelineList.Add(new Timeline { Id = 1, Year = 1983, Title = "Born", SubTitle = "Chennai, India" });
            timelineList.Add(new Timeline { Id = 2, Year = 2004, Title = "B.Tech I.T.", SubTitle = "University of Madras, India" });
            timelineList.Add(new Timeline { Id = 3, Year = 2006, Title = "M.Tech I.T.", SubTitle = "R.M.I.T, Melblourne, Australia" });
            timelineList.Add(new Timeline { Id = 4, Year = 2006, Title = "Cadability Pty Ltd", SubTitle = "Data Capture Analyst" });
            timelineList.Add(new Timeline { Id = 4, Year = 2008, Title = "FRED I.T.", SubTitle = "Development Consultant" });
            timelineList.Add(new Timeline { Id = 5, Year = 2012, Title = "FRED I.T.", SubTitle = "Development Team Lead" });
            timelineList.Add(new Timeline { Id = 6, Year = 2015, Title = "FRED I.T.", SubTitle = "Senior Development Consultant" });
            timelineList.Add(new Timeline { Id = 7, Year = 2015, Title = "City Holdings", SubTitle = "Xamarin Developer" });
            timelineList.Add(new Timeline { Id = 8, Year = 2015, Title = "Telstra Health", SubTitle = "Senior Technical Specialist" });

            return await Task.FromResult(timelineList);
        }

        public async Task<List<Qualification>> GetQualifications(string userId)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var graduationGroup = new List<Qualification>();
                    Qualification masters = new Qualification { Degree = "Master of Technology - Information Technology", University = "rmit", StartDate = new DateTime(2004,07,01), EndDate= new DateTime(2006, 04,01)};
                    Qualification bachelors = new Qualification { Degree = "Bachelor of Technology - Information Technology", University = "unimad", StartDate = new DateTime(2000,06,01), EndDate= new DateTime(2004, 04,01) };
                    graduationGroup.Add(masters);
                    graduationGroup.Add(bachelors);

                    var certificationGroup = new List<Qualification>();
                    certificationGroup.Add(new Qualification { Degree = "Xamarin Certified Mobile Developer", University = "xamuni", StartDate = new DateTime(2015,08,01), EndDate = new DateTime(2016, 08,01) });
                    certificationGroup.Add(new Qualification { Degree = "ASP.NET 4.5, MVC 4.0, Web Development", University = "microsoft", StartDate = new DateTime(2014, 05, 26), EndDate = new DateTime(2014, 05, 26) });
                    certificationGroup.Add(new Qualification { Degree = "SharePoint® 2010, Application Development", University = "microsoft", StartDate = new DateTime(2012, 05, 18), EndDate = new DateTime(2012, 05, 18) });
                    certificationGroup.Add(new Qualification { Degree = ".NET Framework 4, Data Access", University = "microsoft", StartDate = new DateTime(2012, 01, 27), EndDate = new DateTime(2012, 01, 27) });
                    certificationGroup.Add(new Qualification { Degree = "SQL Server® 2008, Implementation & Maintenance", University = "microsoft", StartDate = new DateTime(2011, 08, 12), EndDate = new DateTime(2011, 08, 12) });
                    certificationGroup.Add(new Qualification { Degree = "Microsoft Dynamics® AX 2009", University = "microsoft", StartDate = new DateTime(2010, 11, 29), EndDate = new DateTime(2010, 11, 29) });
                    certificationGroup.Add(new Qualification { Degree = ".NET Framework 4, Service Communication Applications", University = "microsoft", StartDate = new DateTime(2010, 08, 16), EndDate = new DateTime(2010, 08, 16) });
                    certificationGroup.Add(new Qualification { Degree = ".NET Framework 4, Windows® Applications", University = "microsoft", StartDate = new DateTime(2010, 06, 05), EndDate = new DateTime(2010, 06, 05) });

                    
                    return graduationGroup.Union(certificationGroup).ToList();
                }
                catch (Exception ex)
                {
                    
                    return new List<Qualification>();
                }
            });

        }

        public async Task<List<TechnicalSkill>> GetTechnicalSkills(string userId)
        {
            return await Task.Run(() =>
            {
                var techStack = new List<TechnicalSkill>();
                techStack.Add(cSharp);
                techStack.Add(xaml);
                techStack.Add(js);
                techStack.Add(html);
                techStack.Add(css);
                techStack.Add(asp);

                techStack.Add(aspMvc);
                techStack.Add(angJs);
                techStack.Add(aspMvc);
                techStack.Add(jQuery);
                techStack.Add(knockJs);

                techStack.Add(winForms);
                techStack.Add(wpf);
                techStack.Add(win8Apps);

                techStack.Add(iOS);
                techStack.Add(android);
                techStack.Add(wp8);
                techStack.Add(uwp);
                techStack.Add(winCE);
               
                techStack.Add(sql);
                techStack.Add(sqlite);
               
                techStack.Add(tfs);
                techStack.Add(git);
                techStack.Add(dotNetCore);
                techStack.Add(mono);
                techStack.Add(monoDroid);
                techStack.Add(xamForms);
               
                techStack.Add(vs);
                techStack.Add(xs);
                techStack.Add(xcode);

                techStack.Add(sketch);
                techStack.Add(invision);
                techStack.Add(zepplin);
                techStack.Add(balsamiq);

                techStack.Add(azure);

                techStack.Add(testCloud);
                techStack.Add(xamTestRec);
                techStack.Add(nUnit);
                techStack.Add(msUnit);
                techStack.Add(specFlow);

                techStack.Add(waterFall);
                techStack.Add(scrum);
                techStack.Add(kanban);
                return techStack;
            });
        }

        public async Task<List<Work>> GetWorkExperiences(string userId)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<Work> Works = new List<Work>();
                    Works.Add(_telstra);
                    Works.Add(_city);
                    Works.Add(_fred);
                    Works.Add(_cadability);

                    return Works;
                }
                catch (Exception ex)
                {
                   
                    return new List<Work>();
                }
            });
        }

        public async Task<List<Project>> GetProjectsList(string userId)
        {
            return await Task.Run(() =>
            {
                try
                {
                    return Projects;
                }
                catch (Exception ex)
                {
                   
                    return new List<Project>();
                }
            });
        }
    }
}
