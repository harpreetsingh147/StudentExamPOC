using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExam.UI.Controllers
{
    using global::StudentExam.Services.GenericRepository;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using POC.Model;
    using StudentExam.Services.GenericRepository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace StudentExam.UI.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class ExamQuestionController : Controller
        {
            private readonly IRepository<ExamQuestion> _examRepository = null;
            public ExamQuestionController(IRepository<ExamQuestion> examRepository)
            {
                _examRepository = examRepository;
            }
            [HttpGet]
            [Authorize]
            public IActionResult Get()
            {
                return Ok(_examRepository.GetAll());
            }

            [HttpPost]
            [Authorize]
            public IActionResult Post(Exam DTO)
            {
                _examRepository.Insert(DTO);
                return Ok();
            }
        }
    }

}
