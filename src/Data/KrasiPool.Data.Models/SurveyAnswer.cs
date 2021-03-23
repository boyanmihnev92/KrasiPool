using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KrasiPool.Data.Models
{
    public class SurveyAnswer
    {
        public int Id { get; set; }

        public int SurveyQuestionId { get; set; }

        public SurveyQuestion Question { get; set; }

        public int SurveyId { get; set; }

        public Survey Survey { get; set; }

        [Required]
        public string Value { get; set; }
    }
}
