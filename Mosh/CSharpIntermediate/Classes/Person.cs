// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-07-2022
//
// Last Modified By : mworland
// Last Modified On : 07-11-2022
// ***********************************************************************
// <copyright file="Person.cs" company="">
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
    /// Class Person.
    /// </summary>
    public class Person
    {


        //field
        /// <summary>
        /// The birthdate
        /// This field is used by the Birthdate property
        /// When you need to call upon a backingfield you would use
        /// this option instead of an Auto-Property
        /// </summary>
        private DateTime _birthdate;

        //Property
        /// <summary>
        /// Gets or sets the birthdate.
        /// This manual way was creating the property would be used when
        /// you need to introduce logic to the getter or setter
        /// In this example, an Auto-Property would have been better
        /// </summary>
        /// <value>The birthdate.</value>
        public DateTime Birthdate {
            get
            {
                return this._birthdate;
            }
            set
            {
                this._birthdate = value;
            }
        }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets the birthdate better.
        /// The setter is private so it is readonly
        /// It is only set once during the constructor and will not change throughout the code life
        /// This ensures that Birthdate and Age will always be in a valid state
        /// </summary>
        /// <value>The birthdate better.</value>
        public DateTime BirthdateBetter { get; private set; } // This is an Auto-implemented Property Used when no logic is needed. No need for backing field


        /// <summary>
        /// Gets the age.
        /// This only has a getter since we can not set someones age
        /// </summary>
        /// <value>The age calculated based on todays date and persons.Birthdate</value>
        public int Age
        {
            get
            {
                TimeSpan timespan = DateTime.Today - BirthdateBetter;
                int years = timespan.Days / 365;
                return years;
            }

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="birthdate">The birthdate.</param>
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
            //Added so Person.Parse will still work
        }

        /// <summary>
        /// Introduces the specified to.
        /// </summary>
        /// <param name="to">To.</param>
        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}.");
        }

        /// <summary>
        /// Parses the specified string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>Person.</returns>
        public static Person Parse(string str)
        {
            Person person = new Person();

            person.Name = str;

            
            return person;
        }

        /// <summary>
        /// Sets the birth date.
        /// </summary>
        /// <param name="birthdate">The birthdate.</param>
        public void SetBirthDate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        /// <summary>
        /// Gets the birthdate.
        /// </summary>
        /// <returns>DateTime.</returns>
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}
