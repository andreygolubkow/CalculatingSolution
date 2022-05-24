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
		
		private CalculatrionRights() { }
	
		public static CalculatrionRights Instance => _lazy.Value;

		public double Accuracy { get; set; } = 0.1;
	}
}