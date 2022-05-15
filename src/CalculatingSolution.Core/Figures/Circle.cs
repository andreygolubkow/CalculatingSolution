using System;

namespace CalculatingSolution.Core.Figures
{
	/// <summary>
	/// The circle struct.
	/// </summary>
	public struct Circle
	{
		private int _r;

		/// <summary>
		/// Radius.
		/// Should be >0
		/// </summary>
		public int R
		{
			get => _r;
			set
			{
				FigureValidations.ValidateSide(nameof(R), value, "R-side");
				_r = value;
			}
		}
	}
}