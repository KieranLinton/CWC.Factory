using CWC.Domain.Objects.Logging;
using CWC.Domain.Objects.Person;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CWC.Gyro.Step.Dector.Web.Controllers
{
    /// <summary>
    /// Api Sevice Provider
    /// </summary>
    [Route("api/[controller]")]
    public class ServicesController : Controller
    {
        private readonly ILoggingService _loggingService;
        private readonly IPersonService _personService;

        public ServicesController(ILoggingService loggingService, IPersonService personService)
        {
            _personService = personService;
            _loggingService = loggingService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> TestService()
        {
            return Ok("service is live");
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> TestLoggin()
        {  
            // create message to output 
            LoggingMessage loggingMessage = new LoggingMessage
            {
                DateAdded = DateTime.Now,
                Message = "Message To Log",
                MessageFrom = "CWC.Gyro.Step.Detector"
            };

            // send message to log
            await _loggingService.SendMessageToLog(loggingMessage);

            return Ok(loggingMessage);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> TestNewPerson()
        {
            // create new person
            PersonClaim personClaim = new PersonClaim
            {
                DateJoined = DateTime.Now,
                IsActive = true,
                Email = "email@emai.com",
                UserName = "kiern",
                Password = "password"
            };

            // add preson to db
            personClaim = await _personService.AddPerson(personClaim);
            return Ok(personClaim);
        }
    }
}