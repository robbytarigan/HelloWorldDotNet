using System.Collections.Generic;

namespace Questionnaire.Web.Abstractions
{
    public record Questionnaire(string QuestionnaireTitle, IEnumerable<string> QuestionsText);
}