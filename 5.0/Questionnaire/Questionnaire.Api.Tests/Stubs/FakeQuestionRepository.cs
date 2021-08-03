using Questionnaire.Api.Abstractions;

namespace Questionnaire.Api.Tests.Stubs
{
    public class FakeQuestionRepository : IQuestionRepository
    {
        public Questionnaire.Api.Abstractions.Questionnaire ExpectedQuestions { get; set; }
        public Questionnaire.Api.Abstractions.Questionnaire GetQuestionnaire()
        {
            return ExpectedQuestions;
        }
    }
}