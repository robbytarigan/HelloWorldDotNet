using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Moq;
using Questionnaire.Web.Controllers;
using Questionnaire.Web.Models;
using Xunit;

namespace Questionnaire.Web.Tests
{
    public class QuestionnaireControllerTests
    {
        private Mock<IConfiguration> _config;
        private QuestionnaireController _questionnaireController;

        public QuestionnaireControllerTests()
        {
            _config = new Mock<IConfiguration>();
            _questionnaireController = new QuestionnaireController(_config.Object);
        }

        [Fact]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected quesitons";

            //Act
            var result = (QuestionnaireViewModel)_questionnaireController.Index().ViewData.Model;

            //Assert
            result.QuestionnaireTitle.Should().Be(expectedTitle);
        }
    }
}