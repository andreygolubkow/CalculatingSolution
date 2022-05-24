using System;

namespace CalculatingSolution.Core.Figures
{
    public static class FigureValidations
    {
        /// <summary>
        /// Throws exception if side value less than zero or zero
        /// </summary>
        /// <param name="argumentName">Argument name</param>
        /// <param name="argumentValue">Argument value(side value)</param>
        /// <param name="sideName">The side name</param>
        /// <exception cref="ArgumentOutOfRangeException">When side value less than zero or zero</exception>
        public static void ValidateSide(string argumentName,double argumentValue, string sideName)
        {
            if (argumentValue <= 0 || double.IsInfinity(argumentValue) || double.IsNaN(argumentValue))
            {
                throw new ArgumentOutOfRangeException(argumentName, $"{sideName} should be greater than 0");
            }
        }
    }
}