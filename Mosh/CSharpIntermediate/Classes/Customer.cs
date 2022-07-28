// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-07-2022
//
// Last Modified By : mworland
// Last Modified On : 07-11-2022
// ***********************************************************************
// <copyright file="Customer.cs" company="">
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
    /// Class Customer.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public int Id;
        /// <summary>
        /// The name
        /// </summary>
        public string Name;

        /// <summary>
        /// The orders
        /// </summary>
        public List<Order> Orders;
        /// <summary>
        /// The orders good
        /// </summary>
        public List<Order> OrdersGood = new List<Order>();// This would replace the default constructor below
        /// <summary>
        /// The orders better
        /// </summary>
        public readonly List<Order> OrdersBetter = new List<Order>();// This ensures Orders is only initialized once and wont allow you to overwrite the data if you forget and try to re-initialize it later.


        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
            this.Orders = new List<Order>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public Customer( int id) : this() 
        // Doing : this() tells the compiler that it also needs to run the default constructor first
        {
            this.Id = id;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        public Customer(int id, string name) : this(id)
        // and by passing this(id) it goes to initialize constructor on line 23, which must initialize constructor on line 18
        // Not the best practice and work flow. The two overloaded constructors are not necessary and not needed.
        {
            this.Name = name;
        }

    
    }
}
