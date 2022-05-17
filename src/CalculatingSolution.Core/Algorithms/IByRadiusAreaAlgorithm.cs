namespace CalculatingSolution.Core.Algorithms
{
	/// <summary>
	/// Calculating area by radius alghoritm interface
	/// </summary>
	public interface IByRadiusAreaAlgorithm
	{
		/// <summary>
		/// Calculate circle area by radius.
		/// </summary>
		/// <returns>area</returns>
		double CalculateArea(double radius);
	}
}