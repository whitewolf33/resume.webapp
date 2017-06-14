using System;

namespace Resume.Webapp.Models
{
    public class Qualification : BaseClass
    {
        public string Degree { get; set; }

        public string University { get; set; }

        public string Type { get; set; }

        public string Logo { get { return String.Format("{0}.png", University); } }
    }

}
