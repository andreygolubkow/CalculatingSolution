namespace CalculatingSolution.Core.Interfaces
{
	/// <summary>
	/// Triangle.
	/// </summary>
	public interface ITriangle: IFigure
	{
		/// <summary>
		/// Check triangle, if it's rectangular - returns true.
		/// </summary>
		bool IsRectangular();
	}
}