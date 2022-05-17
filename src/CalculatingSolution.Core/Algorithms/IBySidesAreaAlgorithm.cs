namespace CalculatingSolution.Core.Algorithms
{
	/// <summary>
	/// Calculating area by side lengths.
	/// </summary>
	public interface IBySidesAreaAlgorithm
	{
		/// <summary>
		/// Calculating figure area by length.
		/// </summary>
		/// <param name="sideLength">Side lengths</param>
		/// <returns>Area</returns>
		double CalculateArea(params double[] sideLength);
	}
}