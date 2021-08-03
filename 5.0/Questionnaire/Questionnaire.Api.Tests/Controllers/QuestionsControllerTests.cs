using FluentAssertions;
using Questionnaire.Api.Controllers;
using Questionnaire.Api.Tests.Stubs;
using Xunit;

namespace Questionnaire.Api.Tests.Controllers
{
    public class QuestionsControllerTests
    {
        [Fact]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected questions";
            var expectedQuestions = new Questionnaire.Api.Abstractions.Questionnaire() { QuestionnaireTitle = expectedTitle };
            var fakeQuestionRepository = new FakeQuestionRepository() { ExpectedQuestions = expectedQuestions };
            var questionsController = new QuestionsController(fakeQuestionRepository);

            //Act
            var questions = questionsController.Get();

            //Assert
            questions.QuestionnaireTitle.Should().Be(expectedTitle);
        }
    }
}