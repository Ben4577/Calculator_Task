using Pharmacy2U_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy2U_task.Services
{
    public interface ISimpleCalculator
    {
        public double Add(double firstNum, double secondNum);
        public double Subtract(double firstNum, double secondNum);
    }
}
