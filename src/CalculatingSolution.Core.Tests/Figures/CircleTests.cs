using System;
using System.Threading;
using CalculatingSolution.Core.Algorithms;
using CalculatingSolution.Core.Figures;
using NUnit.Framework;
namespace CalculatingSolution.Core.Tests.Figures
{
	[TestFixture]
	public class CircleTests
	{
		[TestCase(1, Description = "Creating a Circle with R=1")]
		[TestCase(double.MaxValue, Description = "Creating a Circle with r = double.max")]
		public void FromRCorrectValueTest(double r)
		{
			var circle = Circle.FromR(r);
			// ReSharper disable once CompareOfFloatsByEqualityOperator
			// circle.R should be identical 
			Assert.True(circle.R == r, "Circle.R should be equal to test value");
		}

		[TestCase(double.NaN, Description = "Create a Circle with NaN value")]
		[TestCase(double.MinValue, Description = "Creating a Circle with double.min")]
		[TestCase(double.PositiveInfinity, Description = "Creating a Circle with positive infinity")]
		[TestCase(double.NegativeInfinity, Description = "Creating a Circle with negative infinity")]
		[TestCase(0, Description = "Creating a circle with zero radius")]
		[TestCase(-1, Description = "Creating a circle with -1 radius")]
		public void FromRThrowsExceptionTest(double r)
		{
			TestDelegate act = () =>
								{
									Circle.FromR(r);
								};
			Assert.Throws<ArgumentOutOfRangeException>(act, $"{nameof(Circle.FromR)} should throw exception");
		}
	}
}