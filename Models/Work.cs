using System.Collections.Generic;

namespace Resume.Webapp.Models
{
    public class Work : BaseClass
    {
        public int Index { get; set; }

        public string Company { get; set; }

        public string Address { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string CompanyLogo { get; set; }

        public List<Project> Projects { get; set; } = new List<Project>();


    }

}
