using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExam.Domain.DTOs
{
    public class QuestionDTO
    {
        public string QuestionText { get; set; }
        public bool? IsMultiOption { get; set; }
        public bool? Answer { get; set; }
        public Guid? ExamId { get; set; }
        public List<QuestionOptions> Options { get; set; }
        public string CorrectAnswer { get; set; }
    }

    public class QuestionOptions
    {
        public Guid Id { get; set; }
        public string Option { get; set; }
    }
}
