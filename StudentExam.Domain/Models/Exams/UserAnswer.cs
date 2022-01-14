using StudentExam.Domain.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace POC.Model
{
    public partial class UserAnswer: BaseEntity
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public Guid? QuestionId { get; set; }
        public Guid? AnswerId { get; set; }
    }
}
