using System.Collections.Generic;
using Questionnaire.Api.Abstractions;

namespace Questionnaire.Api
{
    public class QuestionRepository : IQuestionRepository
    {
        public Questionnaire.Api.Abstractions.Questionnaire GetQuestionnaire()
        {
            return new Questionnaire.Api.Abstractions.Questionnaire
            {
                QuestionnaireTitle = "Geography Questions",
                QuestionsText = new List<string>
                {
                    "What is the capital of Cuba?",
                    "What is the capital of France?",
                    "What is the capital of Poland?",
                    "What is the capital of Germany?"
                }
            };
        }
    }
}