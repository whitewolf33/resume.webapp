namespace Resume.Webapp.Models
{
    public class TechnicalSkill 
    {
        public string Name { get; set; }

        public int Strength { get; set; }

        public string Type { get; set; }

        public int Years { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Timeline
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

    }

}
