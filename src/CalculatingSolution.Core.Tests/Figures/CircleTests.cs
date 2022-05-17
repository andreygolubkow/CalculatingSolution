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
		[TestCase()]
		public void CalculatingCircleAreaTest_WithCorrectData(double radius, double area)
		{
			var cicrle = Circle.FromR(radius);
			//var algo = new CircleAreaAlgorithm();
			
			//var area = algo.CalculateArea()
		}
	}
}