using CWC.Domain.Objects.Logging;
using CWC.Domain.Objects.Person;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CWC.Gyro.Step.Dector.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoggingService _loggingService;
        private readonly IPersonService _personService;

        public HomeController(ILoggingService loggingService, IPersonService personService)
        {
            _personService = personService;
            _loggingService = loggingService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
