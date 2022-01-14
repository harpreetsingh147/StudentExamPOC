using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POC.Model;
using StudentExam.Domain.Models.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExam.Domain.Authentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamQuestion> ExamQuestions { get; set; }
        public virtual DbSet<MultichoiceAnswer> MultichoiceAnswers { get; set; }
        public virtual DbSet<UserAnswer> UserAnswers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ExamConfiguration());
            builder.ApplyConfiguration(new ExamQuestionConfiguraiton());
            builder.ApplyConfiguration(new MultiChoiceAnswerConfiguration());
            builder.ApplyConfiguration(new UserAnswerConfiguration());
        }
    }
}
