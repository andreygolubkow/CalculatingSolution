using System;

namespace CalculatingSolution.Core.Figures
{
	/// <summary>
	/// The triangle struct.
	/// </summary>
	public struct Triangle: IFigure
	{
		private Triangle(double a, double b, double c) : this()
		{
			FigureValidations.ValidateSide(nameof(a), a, "A-side");
			FigureValidations.ValidateSide(nameof(b), b, "B-side");
			FigureValidations.ValidateSide(nameof(c), c, "C-side");
			A = a;
			B = b;
			C = c;
		}
		
		/// <summary>
		/// Triangle A-side.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">
		/// When side value less than zero or equal zero
		/// </exception>
		public double A { get; }

		/// <summary>
		/// Triangle B-side.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">
		/// When side value less than zero or equal zero
		/// </exception>
		public double B { get; }

		/// <summary>
		/// Triangle C-side.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">
		/// When side value less than zero or equal zero
		/// </exception>
		public double C { get; }

		/// <summary>
		/// Create triangle from a,b,c side values
		/// </summary>
		/// <param name="a">A-side</param>
		/// <param name="b">B-side</param>
		/// <param name="c">C-side</param>
		/// <returns>Triangle</returns>
		/// <exception cref="ArgumentOutOfRangeException">When side is't number or less or equal 0</exception>
		public static Triangle FromSides(double a, double b, double c)
		{
			return new Triangle(a, b, c);
		}
	}
}