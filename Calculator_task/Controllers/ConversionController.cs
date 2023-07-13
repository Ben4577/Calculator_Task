using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pharmacy2U_task.Models;
using Pharmacy2U_task.Services;


namespace Pharmacy2U_task.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ConversionController : Controller
    {

        //string sessionKey = "sk";
      
        private readonly ISimpleCalculator _simpleCalculator;

        public ConversionController(ISimpleCalculator simpleCalculator)
        {
            _simpleCalculator = simpleCalculator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("CalculateAdd")]
        public IActionResult CalculateAdd([FromBody] UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _simpleCalculator.Add(user.firstNum, user.secondNum);
            return Ok(result);
        }


        [HttpPost("CalculateMinus")]
        public IActionResult CalculateMinus([FromBody] UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _simpleCalculator.Subtract(user.firstNum, user.secondNum);
            return Ok(result);
        }





    }
}