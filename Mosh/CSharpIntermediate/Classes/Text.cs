// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-13-2022
//
// Last Modified By : mworland
// Last Modified On : 07-13-2022
// ***********************************************************************
// <copyright file="Text.cs" company="">
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
    /// Class Text.
    /// Implements the <see cref="CSharpIntermediate.Classes.PresentationObject" />
    /// </summary>
    /// <seealso cref="CSharpIntermediate.Classes.PresentationObject" />
    internal class Text : PresentationObject
    {
        /// <summary>
        /// Gets or sets the size of the font.
        /// </summary>
        /// <value>The size of the font.</value>
        public int FontSize { get; set; }
        /// <summary>
        /// Gets or sets the name of the font.
        /// </summary>
        /// <value>The name of the font.</value>
        public string FontName { get; set; }

        /// <summary>
        /// Adds the hyperlink.
        /// </summary>
        /// <param name="url">The URL.</param>
        public void AddHyperlink(string url)
        {
            Console.WriteLine($"You added a link to: {url}");
        }
    }
}
