using StudentExam.Domain.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace POC.Model
{
    public partial class ExamQuestion: BaseEntity
    {
        public ExamQuestion()
        {
            MultichoiceAnswers = new HashSet<MultichoiceAnswer>();
        }

        public Guid Id { get; set; }
        public string QuestionText { get; set; }
        public bool? IsMultiOption { get; set; }
        public bool? Answer { get; set; }
        public Guid? ExamId { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual ICollection<MultichoiceAnswer> MultichoiceAnswers { get; set; }
    }
}
