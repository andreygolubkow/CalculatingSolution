using System;
using CalculatingSolution.Core.Figures;
using NUnit.Framework;
namespace CalculatingSolution.Core.Tests.Figures
{
    [TestFixture]
    public class FigureValidationsTests
    {
        private const string TestSideName = "TestSide";
        private const string TestSideParamName = "nameof(TestSide)";
        
        [TestCase(1, Description = "Try validate correct value '0' ")]
        [TestCase(double.MaxValue, Description = "Try validate correct value 'double.max'")]
        public void CorrectValueTest(double value)
        {
            FigureValidations.ValidateSide(TestSideParamName, value, TestSideName);
            Assert.Pass("Correct value test");
        }

        [TestCase(0,Description ="Validation throws exception, because of zero is incorrect value")]
        [TestCase(-1,Description = "Validation throws exception, because of -1 is incorrect value")]
        [TestCase(double.NaN,Description = "Validation throws exception, because of double.nan is incorrect value")]
        [TestCase(double.PositiveInfinity,Description = "Validation throws exception, because of double.positiveInfinity is incorrect value")]
        [TestCase(double.NegativeInfinity, Description ="Validation throws exception, because of double.negativeInfinity is incorrect value")]
        [TestCase(double.MinValue, Description = "Validation throws exception, because of double.minValue is incorrect value")]
        public void ThrowExceptionTest(double value)
        {
            TestDelegate action = () =>
                                  {
                                      FigureValidations.ValidateSide(TestSideParamName, value, TestSideName);
                                  };
            
            var outOfRangeException = Assert.Throws<ArgumentOutOfRangeException>(action);
            Assert.IsNotNull(outOfRangeException, "Validation does not throw exception");
            Assert.IsTrue(typeof(ArgumentOutOfRangeException) == outOfRangeException.GetType(), 
                          $"Validation does not throw ArgumentException, but throws {outOfRangeException.GetType()}");
            Assert.IsTrue(outOfRangeException.ParamName == TestSideParamName, 
                          "The exception does not contains correct argument name");
            Assert.IsTrue(outOfRangeException.Message.Contains(TestSideName, StringComparison.InvariantCulture), 
                          "The exception does not contains correct side name");
        }
    }
}