
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Pharmacy2U_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy2U_task.Services
{
    public class SimpleCalculator : ISimpleCalculator
    {
        //ISession session;
        private List<User> userList;
        const string sessionKey = "userList";

       public double Add(double firstNum, double secondNum)
       {
            var result = firstNum + secondNum;
            return result;
       }


        public double Subtract(double firstNum, double secondNum)
        {
            var result = firstNum - secondNum;
            return result;
        }


    }
}
