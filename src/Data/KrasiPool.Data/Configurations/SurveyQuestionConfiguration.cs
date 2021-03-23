using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KrasiPool.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KrasiPool.Data.Configurations
{
    public class SurveyQuestionConfiguration : IEntityTypeConfiguration<SurveyQuestion>
    {
        public void Configure(EntityTypeBuilder<SurveyQuestion> question)
        {
            question
                 .HasOne(v => v.Survey)
                 .WithMany(v => v.Questions)
                 .HasForeignKey(v => v.SurveyId)
                 .IsRequired()
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
