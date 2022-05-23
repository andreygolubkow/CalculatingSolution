namespace CalculatingSolution.Core.Theorems
{
	public static class PythagoreanTheorem
	{
		/// <summary>
		/// Checking the triangle
		/// </summary>
		/// <param name="a">Cathet A</param>
		/// <param name="b">Cathet B</param>
		/// <param name="c">Hypotenuse</param>
		/// <returns>If it's rectangular - true</returns>
		public static bool IsRectangularTriangle(double a, double b, double c)
		{
			return CathetsSum(a, b) - c * c <= CalculatrionRights.Instance.Accuracy;
		}

		public static double CathetsSum(double a, double b)
		{
			return a * a + b * b;
		} 
	}
}