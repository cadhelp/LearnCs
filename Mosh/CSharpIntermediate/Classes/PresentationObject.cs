// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-13-2022
//
// Last Modified By : mworland
// Last Modified On : 07-13-2022
// ***********************************************************************
// <copyright file="PresentationObject.cs" company="">
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
    /// Class PresentationObject.
    /// </summary>
    internal class PresentationObject
    {
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        public int Height { get; set; }
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        public int Width { get; set; }

        /// <summary>
        /// Copies this instance.
        /// </summary>
        public void Copy()
        {
            Console.WriteLine("Object was copied to clipboard.");
        }

        /// <summary>
        /// Duplicates this instance.
        /// </summary>
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }
    }
}
