using Microsoft.AspNetCore.Mvc;
using Questionnaire.Api.Abstractions;

namespace Questionnaire.Api.Controllers
{
    [Route("[controller]")]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionsController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        // GET api/questions
        [HttpGet]
        public Questionnaire.Api.Abstractions.Questionnaire Get()
        {
            return _questionRepository.GetQuestionnaire();
        }

        // GET api/questions/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "";
        }

        // POST api/questions
        public void Post([FromBody] string value)
        {
        }

        // PUT api/questions/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/questions/5
        public void Delete(int id)
        {
        }
    }
}