using System;

namespace CalculatingSolution.Core.Figures
{
	/// <summary>
	/// The triangle struct.
	/// </summary>
	public struct Triangle
	{
		private int _a;
		private int _b;
		private int _c;
		
		public Triangle(int a, int b, int c) : this()
		{
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
		public int A
		{
			get => _a;
			private set
			{
				FigureValidations.ValidateSide(nameof(A), value, "A-side");
				_a = value;
			}
		}

		/// <summary>
		/// Triangle B-side.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">
		/// When side value less than zero or equal zero
		/// </exception>
		public int B
		{
			get => _b;
			private set
			{
				FigureValidations.ValidateSide(nameof(B), value, "B-side");
				_b = value;
			}
		}

		/// <summary>
		/// Triangle C-side.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">
		/// When side value less than zero or equal zero
		/// </exception>
		public int C
		{
			get => _c;
			private set
			{
				FigureValidations.ValidateSide(nameof(C), value, "C-side");
				_c = value;
			}
		}
	}
}