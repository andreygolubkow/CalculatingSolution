using System;
using CalculatingSolution.Core.Figures;
using NUnit.Framework;
namespace CalculatingSolution.Core.Tests.Figures
{
	[TestFixture]
	public class TriangleTests
	{
		[TestCase(1,1,1, Description = "Creating a Triangle with A=1,B=1,C=1")]
		[TestCase(double.MaxValue, double.MaxValue, double.MaxValue, Description = "Creating a Triangle with double.max values")]
		public void FromSidesCorrectValueTest(double a,double b, double c)
		{
			var t = Triangle.FromSides(a, b, c);
			// ReSharper disable once CompareOfFloatsByEqualityOperator
			Assert.True(t.A == a, "Triangle.A should be equal to a");
			// ReSharper disable once CompareOfFloatsByEqualityOperator
			Assert.True(t.B == a, "Triangle.B should be equal to b");
			// ReSharper disable once CompareOfFloatsByEqualityOperator
			Assert.True(t.C == a, "Triangle.C should be equal to c");
		}

		[TestCase(double.NaN, 1, 1, Description = "Create a Triangle with one NaN value")]
		[TestCase(double.MinValue, 1, 1, Description = "Creating a Triangle with double.min")]
		[TestCase(double.PositiveInfinity,1,1, Description = "Creating a Triangle with positive infinity")]
		[TestCase(double.NegativeInfinity,1,1, Description = "Creating a Triangle with negative infinity")]
		[TestCase(0,1,1, Description = "Creating a triangle with zero")]
		[TestCase(-1,1,1, Description = "Creating a triangle with -1")]
		public void FromSidesThrowsExceptionTest(double invalidNum, double sideOne, double sideTwo)
		{
			TestDelegate actA = () =>
								{
									Triangle.FromSides(invalidNum, sideOne, sideTwo);
								};
			TestDelegate actB = () =>
								{
									Triangle.FromSides(sideOne, invalidNum, sideTwo);
								};
			TestDelegate actC = () =>
								{
									Triangle.FromSides(sideOne, sideTwo, invalidNum);
								};
			
			Assert.Throws<ArgumentOutOfRangeException>(actA, $"{nameof(Triangle.FromSides)} should throw exception when 'a' invalid");
			Assert.Throws<ArgumentOutOfRangeException>(actB,
														$"{nameof(Triangle.FromSides)} should throw exception when 'b' invalid");
			Assert.Throws<ArgumentOutOfRangeException>(actC, $"{nameof(Triangle.FromSides)} should throw exception when 'c' invalid");
		}
	}
}