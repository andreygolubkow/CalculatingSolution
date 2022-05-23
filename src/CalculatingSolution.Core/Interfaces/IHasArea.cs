namespace CalculatingSolution.Core.Interfaces
{
	/// <summary>
	/// The figure with get area;
	/// </summary>
	public interface IHasArea : IFigure
	{
		/// <summary>
		/// Calculate a figure area.
		/// </summary>
		/// <returns></returns>
		double GetArea();
	}
}