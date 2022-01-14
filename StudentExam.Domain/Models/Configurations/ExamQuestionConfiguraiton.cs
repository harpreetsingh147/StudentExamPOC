using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POC.Model;

namespace StudentExam.Domain.Models.Configurations
{
    public class ExamQuestionConfiguraiton : IEntityTypeConfiguration<ExamQuestion>
    {
        public void Configure(EntityTypeBuilder<ExamQuestion> entity)
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.QuestionText)
                .HasMaxLength(500);

            entity.HasOne(d => d.Exam)
                .WithMany(p => p.ExamQuestions)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK_ExamQuestions_Exams");
        }
    }
}
