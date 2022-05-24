using System;
using CalculatingSolution.Core.Interfaces;
using CalculatingSolution.Core.Theorems;

namespace CalculatingSolution.Core.Figures
{
	/// <summary>
	/// The 3-sides triangle struct.
	/// </summary>
	public struct AbcTriangle: ITriangle, IHasArea
	{
		private AbcTriangle(double a, double b, double c) : this()
		{
			A = a;
			B = b;
			C = c;
		}
		
		/// <summary>
		/// AbcTriangle A-side.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">
		/// When side value less than zero or equal zero
		/// </exception>
		public double A { get; }

		/// <summary>
		/// AbcTriangle B-side.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">
		/// When side value less than zero or equal zero
		/// </exception>
		public double B { get; }

		/// <summary>
		/// AbcTriangle C-side.
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
		/// <returns>AbcTriangle</returns>
		/// <exception cref="ArgumentOutOfRangeException">When side is't number or less or equal 0</exception>
		public static AbcTriangle FromSides(double a, double b, double c)
		{
			//TODO: Check that triangle with abc is possible
			FigureValidations.ValidateSide(nameof(a), a, "A-side");
			FigureValidations.ValidateSide(nameof(b), b, "B-side");
			FigureValidations.ValidateSide(nameof(c), c, "C-side");
			return new AbcTriangle(a, b, c);
		}

		/// <inheritdoc />
		public double GetArea()
		{
			var p = (A + B + C)/2.0;

			return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
		}

		/// <inheritdoc />
		public bool IsRectangular()
		{
			if (A > B && A > C)
			{
				return PythagoreanTheorem.IsRectangularTriangle(B, C, A);
			}

			if (B > A && B > C)
			{
				return PythagoreanTheorem.IsRectangularTriangle(A, C, B);
			}

			if (C > A && C > B)
			{
				return PythagoreanTheorem.IsRectangularTriangle(A, B, C);
			}
			return false;
		}
	}
}