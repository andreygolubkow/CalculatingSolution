using System;
using CalculatingSolution.Core.Interfaces;

namespace CalculatingSolution.Core.Figures
{
	/// <summary>
	/// The circle struct.
	/// </summary>
	public readonly struct Circle: IFigure, IHasArea
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
		/// <returns>Circle</returns>
		/// <exception cref="ArgumentOutOfRangeException">When radius is't number or less or equal 0</exception>
		public static Circle FromR(double r)
		{
			return new Circle(r);
		}

		/// <inheritdoc />
		public double GetArea()
		{
			return Math.PI * R * R;
		}
	}
}