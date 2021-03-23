using System.Collections.Generic;

namespace KrasiPool.Data.Models
{
    public class Survey
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Supressed { get; set; }

        public virtual ICollection<SurveyAnswer> Answers { get; set; } = new HashSet<SurveyAnswer>();

        public virtual ICollection<SurveyQuestion> Questions { get; set; } = new HashSet<SurveyQuestion>();

        public virtual ICollection<Service> Services { get; set; } = new HashSet<Service>();
    }
}
