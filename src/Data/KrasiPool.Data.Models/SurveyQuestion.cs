using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KrasiPool.Data.Models
{
    public class SurveyQuestion
    {
        public int Id { get; set; }

        public int SurveyId { get; set; }

        public Survey Survey { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<SurveyAnswer> Answers { get; set; } = new HashSet<SurveyAnswer>();
    }
}
