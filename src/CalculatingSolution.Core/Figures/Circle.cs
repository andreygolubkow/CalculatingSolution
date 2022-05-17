using System;

namespace CalculatingSolution.Core.Figures
{
	/// <summary>
	/// The circle struct.
	/// </summary>
	public struct Circle
	{
		private Circle(double radius)
		{
			FigureValidations.ValidateSide(nameof(R), radius, "Radius");
			R = radius;
		}
		
		/// <summary>
		/// Radius.
		/// Should be >0
		/// </summary>
		public double R { get; }

		/// <summary>
		/// Create new circle by radius value.
		/// </summary>
		/// <param name="r">Radius</param>
		/// <returns></returns>
		public static Circle FromR(double r)
		{
			return new Circle(r);
		}
	}
}