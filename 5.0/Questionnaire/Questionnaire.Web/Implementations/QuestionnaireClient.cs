using System.Net.Http;
using System.Threading.Tasks;
using Questionnaire.Web.Abstractions;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;

namespace Questionnaire.Web.Implementations
{
    public sealed class QuestionnaireClient : IQuestionnaireClient
    {
        private readonly HttpClient httpClient;
        private readonly ILogger<QuestionnaireClient> logger;

        public QuestionnaireClient(HttpClient httpClient, ILogger<QuestionnaireClient> logger)
        {
            this.httpClient = httpClient;
            this.logger = logger;
        }

        public async Task<Abstractions.Questionnaire> GetQuestionnaire()
        {
            var response = await this.httpClient.GetAsync("/questions");
            return await response.Content.ReadFromJsonAsync<Abstractions.Questionnaire>();
        }
    }
}