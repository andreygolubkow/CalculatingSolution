using CalculatingSolution.Core.Figures;
namespace CalculatingSolution.Core.Alghoritms
{
	public class AreaAlghoritm: IAreaAlghoritm<Circle>,
								 IAreaAlghoritm<Triangle>
	{
		/// <inheritdoc />
		public int CalculateArea(Circle figure)
		{
			throw new System.NotImplementedException();
		}

		/// <inheritdoc />
		public int CalculateArea(Triangle figure)
		{
			throw new System.NotImplementedException();
		}
	}
}