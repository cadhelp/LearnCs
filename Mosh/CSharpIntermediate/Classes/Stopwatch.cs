// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-12-2022
//
// Last Modified By : mworland
// Last Modified On : 07-12-2022
// ***********************************************************************
// <copyright file="Stopwatch.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CSharpIntermediate.Classes
{
    using System;

    /// <summary>
    /// Class Stopwatch.
    /// </summary>
    public class Stopwatch
    {
        /// <summary>
        /// The start time
        /// </summary>
        private DateTime _startTime;

        /// <summary>
        /// The is started
        /// </summary>
        private bool _isStarted = false;

        /// <summary>
        /// Starts this instance.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Stopwatch is already started</exception>
        public void Start()
        {
            if (_isStarted)
            {
                throw new InvalidOperationException("Stopwatch is already started");
            }
            _isStarted = true;
            this._startTime = DateTime.Now;

        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        /// <returns>System.Double.</returns>
        public double Stop()
        {
            _isStarted = false;
            TimeSpan duration= DateTime.Now - this._startTime;
             return duration.TotalMinutes;
        }
    }
}