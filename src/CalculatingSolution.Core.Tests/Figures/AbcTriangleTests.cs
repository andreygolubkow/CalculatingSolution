using System;
using CalculatingSolution.Core.Figures;
using NUnit.Framework;
namespace CalculatingSolution.Core.Tests.Figures
{
	[TestFixture]
	public class AbcTriangleTests
	{
		[TestCase(1,1,1, Description = "Creating a AbcTriangle with A=1,B=1,C=1")]
		[TestCase(double.MaxValue, double.MaxValue, double.MaxValue, Description = "Creating a AbcTriangle with double.max values")]
		public void FromSidesCorrectValueTest(double a,double b, double c)
		{
			var t = AbcTriangle.FromSides(a, b, c);
			// ReSharper disable once CompareOfFloatsByEqualityOperator
			Assert.True(t.A == a, "AbcTriangle.A should be equal to a");
			// ReSharper disable once CompareOfFloatsByEqualityOperator
			Assert.True(t.B == a, "AbcTriangle.B should be equal to b");
			// ReSharper disable once CompareOfFloatsByEqualityOperator
			Assert.True(t.C == a, "AbcTriangle.C should be equal to c");
		}

		[TestCase(double.NaN, 1, 1, Description = "Create a AbcTriangle with one NaN value")]
		[TestCase(double.MinValue, 1, 1, Description = "Creating a AbcTriangle with double.min")]
		[TestCase(double.PositiveInfinity,1,1, Description = "Creating a AbcTriangle with positive infinity")]
		[TestCase(double.NegativeInfinity,1,1, Description = "Creating a AbcTriangle with negative infinity")]
		[TestCase(0,1,1, Description = "Creating a triangle with zero")]
		[TestCase(-1,1,1, Description = "Creating a triangle with -1")]
		public void FromSidesThrowsExceptionTest(double invalidNum, double sideOne, double sideTwo)
		{
			TestDelegate actA = () =>
								{
									AbcTriangle.FromSides(invalidNum, sideOne, sideTwo);
								};
			TestDelegate actB = () =>
								{
									AbcTriangle.FromSides(sideOne, invalidNum, sideTwo);
								};
			TestDelegate actC = () =>
								{
									AbcTriangle.FromSides(sideOne, sideTwo, invalidNum);
								};
			
			Assert.Throws<ArgumentOutOfRangeException>(actA, $"{nameof(AbcTriangle.FromSides)} should throw exception when 'a' invalid");
			Assert.Throws<ArgumentOutOfRangeException>(actB,
														$"{nameof(AbcTriangle.FromSides)} should throw exception when 'b' invalid");
			Assert.Throws<ArgumentOutOfRangeException>(actC, $"{nameof(AbcTriangle.FromSides)} should throw exception when 'c' invalid");
		}
	}
}