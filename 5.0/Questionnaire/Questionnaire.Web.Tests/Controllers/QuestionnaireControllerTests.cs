using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Questionnaire.Web.Abstractions;
using Questionnaire.Web.Controllers;
using Questionnaire.Web.Models;
using Xunit;

namespace Questionnaire.Web.Tests
{
    public class QuestionnaireControllerTests
    {
        Mock<IQuestionnaireClient> questionnaireClient;
        private QuestionnaireController questionnaireController;

        public QuestionnaireControllerTests()
        {
            this.questionnaireClient = new Mock<IQuestionnaireClient>();
            questionnaireController = new QuestionnaireController(this.questionnaireClient.Object);
        }

        [Fact]
        public async Task ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected questions";

            this.questionnaireClient.Setup(c => c.GetQuestionnaire()).ReturnsAsync(new Questionnaire.Web.Abstractions.Questionnaire(expectedTitle, Enumerable.Empty<string>()) );

            //Act
            var result = (Questionnaire.Web.Abstractions.Questionnaire)(await questionnaireController.Index() as ViewResult).ViewData.Model;

            //Assert
            result.QuestionnaireTitle.Should().Be(expectedTitle);
        }
    }
}