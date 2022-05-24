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
			return CathetsSquareSum(a, b) - c * c <= CalculatrionRights.Instance.Accuracy;
		}

		/// <summary>
		/// Calculate sum of the cathet squares
		/// </summary>
		/// <param name="a">Cathet A</param>
		/// <param name="b">Cathet B</param>
		/// <returns>a^2 + b^2</returns>
		public static double CathetsSquareSum(double a, double b)
		{
			return a * a + b * b;
		} 
	}
}