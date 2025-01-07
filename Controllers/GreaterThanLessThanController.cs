using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour_Endpoints.Services;

namespace MiniChallengeTwoToFour_Endpoints.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreaterThanLessThanController : ControllerBase
    {
        private readonly GreaterThanLessThanService _greaterThanLessThanService;
        
        public GreaterThanLessThanController(GreaterThanLessThanService greaterThanLessThanService){
            _greaterThanLessThanService = greaterThanLessThanService;
        }

        [HttpGet]
        [Route("GreaterThanLessThan/{num1}/{num2}")]

        public string GreaterThanLessThan(int num1, int num2){
            return _greaterThanLessThanService.GetGreaterThanOrLessThan(num1,num2);
        }

    }
}