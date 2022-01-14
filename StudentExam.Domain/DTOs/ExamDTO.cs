using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExam.Domain.DTOs
{
    public class ExamDTO
    {
        public string Title { get; set; }
        public DateTime? ExamDate { get; set; }
        public DateTime? ExamEndDate { get; set; }
    }
}
