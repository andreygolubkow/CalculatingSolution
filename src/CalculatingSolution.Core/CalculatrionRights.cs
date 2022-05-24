using System;
namespace CalculatingSolution.Core
{
	/// <summary>
	/// The calculation rights:
	/// Accuracy
	/// </summary>
	public sealed class CalculatrionRights
	{
		private static readonly Lazy<CalculatrionRights> _lazy =
				new Lazy<CalculatrionRights>(() => new CalculatrionRights());
		private double _accuracy = 0.1;

		private CalculatrionRights() { }
	
		public static CalculatrionRights Instance => _lazy.Value;

		public double Accuracy
		{
			get => _accuracy;
			set
			{
				if (value <= 0 || double.IsInfinity(value) || double.IsNaN(value))
				{
					throw new ArgumentOutOfRangeException("Accuracy should be a number and greater than 0");
				}
				_accuracy = value;
			}
		}
	}
}