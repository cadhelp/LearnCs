// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-13-2022
//
// Last Modified By : mworland
// Last Modified On : 07-13-2022
// ***********************************************************************
// <copyright file="Installer.cs" company="">
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
    /// Class Installer.
    /// </summary>
    internal class Installer
    {
        /// <summary>
        /// The logger
        /// </summary>
        private readonly Logger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="Installer"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        /// <summary>
        /// Installs this instance.
        /// </summary>
        public void Install()
        {
            this._logger.Log("We are installing the application.");
        }
    }
}
