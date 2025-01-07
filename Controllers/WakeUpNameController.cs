using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour_Endpoints.Services;

namespace MiniChallengeTwoToFour_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WakeUpNameController : ControllerBase
    {
        private readonly WakeUpNameService _wakeUpNameService;
        public WakeUpNameController(WakeUpNameService wakeUpNameService){
            _wakeUpNameService=wakeUpNameService;
        }

        [HttpGet]
        [Route("GetWakeUpNameTime/{name}/{wakeUpTime}")]

        public string GetWakeUpName(string name, string wakeUpTime){
            return _wakeUpNameService.GetWakeUpName(name, wakeUpTime);
        }
        
    }
}