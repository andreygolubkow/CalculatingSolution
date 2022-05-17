namespace CalculatingSolution.Core.Algorithm
{
	/// <summary>
	/// Calculating area alghoritm interface
	/// </summary>
	/// <typeparam name="TFig">Figure</typeparam>
	public interface IAreaAlgorithm<in TFig> where TFig:struct
	{
		/// <summary>
		/// Calculate figure area
		/// </summary>
		/// <param name="figure">figure</param>
		/// <returns>area</returns>
		double CalculateArea(TFig figure);
	}
}