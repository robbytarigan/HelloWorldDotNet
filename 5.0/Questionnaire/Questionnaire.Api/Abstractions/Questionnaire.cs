using System.Collections.Generic;

namespace Questionnaire.Api.Abstractions
{
    public class Questionnaire
    {
        public string QuestionnaireTitle { get; set; }
        public IList<string> QuestionsText { get; set; }
    }
}