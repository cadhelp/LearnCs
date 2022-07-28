// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-07-2022
//
// Last Modified By : mworland
// Last Modified On : 07-07-2022
// ***********************************************************************
// <copyright file="Point.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Classes
{
    /// <summary>
    /// Class Point.
    /// </summary>
    internal class Point
    {
        /// <summary>
        /// The x
        /// </summary>
        public int X;
        /// <summary>
        /// The y
        /// </summary>
        public int Y;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }

        /// <summary>
        /// Moves the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Moves the specified new location.
        /// </summary>
        /// <param name="newLocation">The new location.</param>
        /// <exception cref="System.ArgumentNullException">newLocation</exception>
        public void Move( Point newLocation)
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException(nameof(newLocation));
            }

            Move(newLocation.X, newLocation.Y);
        }
    }
}
