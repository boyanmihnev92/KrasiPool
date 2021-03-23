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
    public class SurveyAnswerConfiguration : IEntityTypeConfiguration<SurveyAnswer>
    {
        public void Configure(EntityTypeBuilder<SurveyAnswer> answers)
        {
            answers
                .HasOne(v => v.Survey)
                .WithMany(v => v.Answers)
                .HasForeignKey(v => v.SurveyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            answers
                .HasOne(v => v.Question)
                .WithMany(v => v.Answers)
                .HasForeignKey(v => v.SurveyQuestionId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
