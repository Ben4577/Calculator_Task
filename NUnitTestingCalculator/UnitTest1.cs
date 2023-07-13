using NUnit.Framework;
using Pharmacy2U_task.Services;

namespace NUnitTestingCalculator
{
    public class Tests 
    {

        private SimpleCalculator _simpleCalculator { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _simpleCalculator = new SimpleCalculator();
        }

        [Test]
        public void TestAdd()
        {
           var firstNumber = 5;
           var secondNumber = 4;
           var result = _simpleCalculator.Add(firstNumber, secondNumber);
           Assert.AreEqual(9,result);
        }

        [Test]
        public void TestSubtract()
        {
            var firstNumber = 5;
            var secondNumber = 4;
            var result = _simpleCalculator.Subtract(firstNumber, secondNumber);
            Assert.AreEqual(1, result);
        }
    }
}