using System.Threading.Tasks;

namespace Questionnaire.Web.Abstractions
{
    public interface IQuestionnaireClient
    {
        Task<Questionnaire> GetQuestionnaire();
    }
}