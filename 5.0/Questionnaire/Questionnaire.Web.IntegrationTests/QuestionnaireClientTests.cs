using System;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Questionnaire.Web.Implementations;

namespace Questionnaire.Web.IntegrationTests
{
    public class QuestionnaireClientTests
    {
        private static readonly Uri QuestionnaireApiBaseUrl = new Uri("https://localhost:5001");
        private readonly QuestionnaireClient questionnaireClient;
        public QuestionnaireClientTests()
        {
            var httpClient = new HttpClient { BaseAddress = QuestionnaireApiBaseUrl };
            this.questionnaireClient = new QuestionnaireClient(httpClient);
        }

        [Fact]
        public async Task CanGetQuestionnaire()
        {
            var questionnaire = await this.questionnaireClient.GetQuestionnaire();
            questionnaire.QuestionnaireTitle.Should().NotBeNullOrWhiteSpace();
            questionnaire.QuestionsText.Should().NotBeEmpty().And.HaveCount(4);
        }
    }
}