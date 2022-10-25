//Pedro Castaneda
//10-25-2022
//Greater Than or Less Than - Endpoint
//Create a Controller with and Endpoint that calls a funcionts that compares two numbers inputed by the user then the fucntion returns weather they are greater than, less than, or equal to each other.
//Peer Review by: Freddy Aguilar - The program converts mini challenge 4 into API format. It takes two numbers from the user and outputs onto Postman whether the first number is greater than, less than or equal to the second number. Everything works as intended.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace castanedaPGreaterThanOrLessThanEnpoint.Controllers
{
    [Route("[controller]")]
    public class GreaterThanLessThanController : Controller
    {
        [HttpGet]
        [Route("Than/{num1}/{num2}")]
        public string GreaterLess(string num1, string num2)
        {
            int validNum1 = 0;
            int validNum2 = 0;
            bool checkNum1 = Int32.TryParse(num1, out validNum1);
            bool checkNum2 = Int32.TryParse(num2, out validNum2);
            string result = "";
            if(!checkNum1 || !checkNum2)
            {
                result = "Invalid Entry";
            }
            else if(validNum1 > validNum2)
            {
                result = $"{validNum1} is greater than {validNum2} \n{validNum2} is less than {validNum1}";
            }
            else if(validNum1 < validNum2)
            {
                result = $"{validNum1} is less than {validNum2} \n{validNum2} is greater than {validNum1}";
            }
            else if(validNum1 == validNum2)
            {
                result = $"{validNum1} is equal to {validNum2}";
            }
            return result;
        }
    }
}