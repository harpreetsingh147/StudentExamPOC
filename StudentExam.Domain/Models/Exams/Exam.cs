using StudentExam.Domain.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace POC.Model
{
    public partial class Exam: BaseEntity
    {
        public Exam()
        {
            ExamQuestions = new HashSet<ExamQuestion>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime? ExamDate { get; set; }
        public DateTime? ExamEndDate { get; set; }

        public virtual ICollection<ExamQuestion> ExamQuestions { get; set; }
    }
}
