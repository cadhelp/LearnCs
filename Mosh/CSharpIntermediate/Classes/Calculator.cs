// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-07-2022
//
// Last Modified By : mworland
// Last Modified On : 07-07-2022
// ***********************************************************************
// <copyright file="Calculator.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CSharpIntermediate.Classes
{
    /// <summary>
    /// Class Calculator.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Adds the specified numbers.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        /// <returns>System.Int32.</returns>
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}