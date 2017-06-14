using System.Collections.Generic;

namespace Resume.Webapp.Models
{
    public class Project : BaseClass
    {
        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public Work Company { get; set; }

        public List<TechnicalSkill> Technologies { get; set; }

        public string Responsibilities { get; set; }

        public string Logo { get; set; }
    }

}
