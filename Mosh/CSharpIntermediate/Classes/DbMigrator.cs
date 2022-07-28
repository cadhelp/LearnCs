// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-13-2022
//
// Last Modified By : mworland
// Last Modified On : 07-13-2022
// ***********************************************************************
// <copyright file="DbMigrator.cs" company="">
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
    /// Class DbMigrator.
    /// </summary>
    internal class DbMigrator
    {
        /// <summary>
        /// The logger
        /// </summary>
        private readonly Logger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="DbMigrator"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public DbMigrator(Logger logger)
        {
            this._logger = logger;
        }

        /// <summary>
        /// Migrates this instance.
        /// </summary>
        public void Migrate()
        {
            this._logger.Log("We are migrating blah blah blah ...");
        }
    }
}
