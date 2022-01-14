using StudentExam.Domain.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace POC.Model
{
    public partial class MultichoiceAnswer: BaseEntity
    {
        public Guid Id { get; set; }
        public string MultipleAnswers { get; set; }
        public Guid? CorrectAnswer { get; set; }
        public Guid? QuestionId { get; set; }

        public virtual ExamQuestion Question { get; set; }
    }
}
