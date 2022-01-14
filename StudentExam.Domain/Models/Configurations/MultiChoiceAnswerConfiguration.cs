using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExam.Domain.Models.Configurations
{
    public class MultiChoiceAnswerConfiguration : IEntityTypeConfiguration<MultichoiceAnswer>
    {
        public void Configure(EntityTypeBuilder<MultichoiceAnswer> entity)
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.MultipleAnswers)
                .HasMaxLength(1000);

            entity.HasOne(d => d.Question)
                .WithMany(p => p.MultichoiceAnswers)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK_MultichoiceAnswers_ExamQuestions");
        }
    }
}
