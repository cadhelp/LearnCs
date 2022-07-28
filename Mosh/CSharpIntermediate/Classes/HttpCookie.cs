// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-11-2022
//
// Last Modified By : mworland
// Last Modified On : 07-11-2022
// ***********************************************************************
// <copyright file="HttpCookie.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CSharpIntermediate.Classes
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class HttpCookie.
    /// </summary>
    public class HttpCookie
    {
        //Dictionaries are great for retrieving an item from a collection using a key, if you need
        // to retrieve data using and index count, then lists are better.
        // Dictionaries use Hash Tables which are very fast for retrieving data. 
        /// <summary>
        /// The dictionary
        /// </summary>
        private readonly Dictionary<string,string> _dictionary = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets the expiry.
        /// </summary>
        /// <value>The expiry.</value>
        public DateTime Expiry { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpCookie"/> class.
        /// </summary>
        public HttpCookie()
        {

        }

        /// <summary>
        /// Gets or sets the <see cref="System.String"/> with the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.String.</returns>
        public string this[string key]
        {
            get
            {
                return this._dictionary[key];
            }
            set
            {
                this._dictionary[key] = value;
            }
        }
    }
}