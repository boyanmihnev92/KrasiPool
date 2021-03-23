using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using KrasiPool.Data.Common.Models;

namespace KrasiPool.Data.Models
{
    public class Service : BaseDeletableModel<int>
    {
        public int VisitId { get; set; }

        public Visit Visit { get; set; }

        public int ServiceTypeId { get; set; }

        public ServiceType ServiceType { get; set; }

        public int StatusId { get; set; }

        public Status Status { get; set; }

        public int SurveyId { get; set; }

        public Survey Survey { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; } = new HashSet<SurveyAnswer>();
    }
}
