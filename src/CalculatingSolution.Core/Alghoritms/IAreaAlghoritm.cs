namespace CalculatingSolution.Core.Alghoritms
{
	/// <summary>
	/// Calculating area alghoritm interface
	/// </summary>
	/// <typeparam name="TFig">Figure</typeparam>
	public interface IAreaAlghoritm<in TFig> where TFig:struct
	{
		/// <summary>
		/// Calculate figure area
		/// </summary>
		/// <param name="figure">figure</param>
		/// <returns>area</returns>
		int CalculateArea(TFig figure);
	}
}