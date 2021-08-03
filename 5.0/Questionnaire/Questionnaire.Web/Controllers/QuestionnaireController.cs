using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Questionnaire.Web.Models;

namespace Questionnaire.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IConfiguration _config;

        public QuestionnaireController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            return View(new QuestionnaireViewModel());
        }

        /* ASYNC ACTION METHOD... IF REQUIRED... */
        //public async Task<ViewResult> Index()
        //{
        //}
    }
}