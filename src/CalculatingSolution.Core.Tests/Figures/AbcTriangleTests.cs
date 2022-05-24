﻿using System;
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
		public void FromSidesThrowsInvalideSidesExceptionTest(double invalidNum, double sideOne, double sideTwo)
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

		[TestCase(1,2,6, Description = "Trying to create a impossible triangle")]
		public void FromSidesThrowsImpossibleTriangleExteptionTests(double a, double b, double c)
		{
			TestDelegate act = () =>
								{
									AbcTriangle.FromSides(a, b, c);
								};
			Assert.Throws<ArgumentException>(act, 
														$"{nameof(AbcTriangle.FromSides)} should throw exception, because of it's impossible triangle");
		}

		[TestCase(1,1,1,false,Description = "Test IsRectangular with non-rectangular triangle")]
		[TestCase(5,2,5.385, true, Description = "Test IsRectangular with rectangular triangle")]
		[TestCase(2,5.385,5, true, Description = "Test IsRectangular with rectangular triangle")]
		[TestCase(5.385,5,2, true, Description = "Test IsRectangular with rectangular triangle")]
		public void IsRectangularTests(double a, double b, double c, bool isRectangular)
		{
			var triangle = AbcTriangle.FromSides(a, b, c);
			
			Assert.True(triangle.IsRectangular() == isRectangular, 
						$"{nameof(AbcTriangle.IsRectangular)} returned incorrect value");
		}

		[TestCase(2,5,6,4.6837)]
		public void GetAreaTest(double a, double b, double c, double expectedArea)
		{
			var triangle = AbcTriangle.FromSides(a, b, c);
			var area = triangle.GetArea();
			
			Assert.AreEqual(area, expectedArea, TestConstants.Accuracy,
							$"{nameof(AbcTriangle.GetArea)} returned incorrect value");
		}
	}
}