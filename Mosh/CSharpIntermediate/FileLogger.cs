// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-22-2022
//
// Last Modified By : mworland
// Last Modified On : 07-22-2022
// ***********************************************************************
// <copyright file="FileLogger.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CSharpIntermediate
{
    using System.IO;

    using Extensibility;

    /// <summary>
    /// Class FileLogger.
    /// Implements the <see cref="ILogger" />
    /// </summary>
    /// <seealso cref="ILogger" />
    public class FileLogger : ILogger
    {
        /// <summary>
        /// The path
        /// </summary>
        private readonly string _path;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileLogger"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public FileLogger( string path)
        {
            this._path = path;
        }

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="messageType">Type of the message.</param>
        private void Log(string message, string messageType)
        {
            using (StreamWriter streamWriter = new StreamWriter(this._path, true))
            {
                streamWriter.WriteLine($"{messageType}: {message}");
            }
        }

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogError(string message)
        {
            this.Log(message, ErrorType.Error.ToString());
        }

        /// <summary>
        /// Logs the information.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogInfo(string message)
        {
            this.Log(message, ErrorType.Info.ToString());
        }

       
    }
}