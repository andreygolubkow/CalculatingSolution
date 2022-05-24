using System;
namespace CalculatingSolution.Core.Figures
{
	public static class TriangleValidations
	{
		/// <summary>
		/// Check sides of triangle
		/// </summary>
		/// <param name="a">A</param>
		/// <param name="b">B</param>
		/// <param name="c">C</param>
		/// <exception cref="ArgumentException">a >= b+c or b >= a+c or c>= a+b</exception>
		public static void CanCreateTriangle(double a, double b, double c)
		{
			if (a >= b+c || b >= a+c || c >=a+b)
			{
				throw new ArgumentException("Can't create a triangle with this sides");
			}
		}
	}
}