using Xunit;
using FluentAssertions;
using Questionnaire.Api;

namespace Questionnaire.Api.Tests
{
    public class QuestionRepositoryTests
    {
        [Fact]
        public void ShouldGetExpectedQuestionnaire()
        {
            var questionRepository = new QuestionRepository();

            var questionnaire = questionRepository.GetQuestionnaire();

            questionnaire.QuestionnaireTitle.Should().Be("Geography Questions");
            questionnaire.QuestionsText[0].Should().Be("What is the capital of Cuba?");
            questionnaire.QuestionsText[1].Should().Be("What is the capital of France?");
            questionnaire.QuestionsText[2].Should().Be("What is the capital of Poland?");
            questionnaire.QuestionsText[3].Should().Be("What is the capital of Germany?");
        }
    }
}