using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POC.Model;

namespace StudentExam.Domain.Models.Configurations
{
    public class ExamConfiguration:IEntityTypeConfiguration<Exam>  
    {
        public void Configure(EntityTypeBuilder<Exam> entity)
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.ExamDate).HasColumnType("datetime");

            entity.Property(e => e.ExamEndDate).HasColumnType("datetime");

            entity.Property(e => e.Title)
                .HasMaxLength(500);
        }
    }
}
