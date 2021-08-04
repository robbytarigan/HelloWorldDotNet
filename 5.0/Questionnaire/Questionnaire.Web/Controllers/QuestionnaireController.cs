using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Questionnaire.Web.Abstractions;
using Questionnaire.Web.Models;

namespace Questionnaire.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IQuestionnaireClient questionnaireClient;

        public QuestionnaireController(IQuestionnaireClient questionnaireClient)
        {
            this.questionnaireClient = questionnaireClient;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = await this.questionnaireClient.GetQuestionnaire();
            return base.View(viewModel);
        }

        /* ASYNC ACTION METHOD... IF REQUIRED... */
        //public async Task<ViewResult> Index()
        //{
        //}
    }
}