using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using POC.Model;
using StudentExam.Domain.DTOs;
using StudentExam.Services.GenericRepository;
using System;
using Newtonsoft.Json;

namespace StudentExam.UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamController : Controller
    {
        private readonly IRepository<Exam> _examRepository = null;
        private readonly IRepository<ExamQuestion> _questionRepository = null;
        private readonly IRepository<MultichoiceAnswer> _optionsRepository = null;
        public ExamController(IRepository<Exam> examRepository,
            IRepository<ExamQuestion> questionRepository,
            IRepository<MultichoiceAnswer> optionsRepository)
        {
            _examRepository = examRepository;
            _questionRepository = questionRepository;
            _optionsRepository = optionsRepository;
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

        [HttpPost]
        [Authorize]
        public IActionResult PostQuestion(QuestionDTO DTO)
        {
            Guid ID=_questionRepository.Insert(new ExamQuestion()
            {
                ExamId = new Guid(),
                IsMultiOption = DTO.IsMultiOption,
                Answer = DTO.Answer,
                QuestionText = DTO.QuestionText
            });

            _optionsRepository.Insert(new MultichoiceAnswer()
            {
                Id = new Guid(),
                QuestionId=ID,
                MultipleAnswers = JsonConvert.SerializeObject(DTO.Options)
            });

            return Ok();
        }
    }
}
