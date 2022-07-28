// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-15-2022
//
// Last Modified By : mworland
// Last Modified On : 07-15-2022
// ***********************************************************************
// <copyright file="StackClass.cs" company="">
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
    using System.Collections;

    /// <summary>
    /// Class StackClass.
    /// Exercise: Design a Stack
    /// A Stack is a data structure for storing a list of elements in
    /// a LIFO (last in, first out) fashion. Design a class called
    /// Stack with three methods.
    /// void Push(object obj)
    /// object Pop()
    /// void Clear()
    /// The Push() method stores the given object on top of the stack.
    /// We use the “object” type here so we can store any objects inside
    /// the stack. Remember the “object” class is the base of all classes
    /// in the .NET Framework. So any types can be automatically upcast to
    /// the object. Make sure to take into account the scenario that null
    /// is passed to this object. We should not store null references in
    /// the stack. So if null is passed to this method, you should throw
    /// an InvalidOperationException. Remember, when coding every method,
    /// you should think of all possibilities and make sure the method
    /// behaves properly in all these edge cases. That’s what distinguishes
    /// you from an “average” programmer.
    /// The Pop() method removes the object on top of the stack and returns it.
    /// Make sure to take into account the scenario that we call the Pop()
    /// method on an empty stack. In this case, this method should throw an
    /// InvalidOperationException. Remember, your classes should always be in a
    /// valid state and used properly. When they are misused, they should throw
    /// exceptions. Again, thinking of all these edge cases, separates you from
    /// an average programmer. The code written this way will be more robust
    /// and with less bugs.
    /// The Clear() method removes all objects from the stack.
    /// We should be able to use this stack class as follows:
    /// var stack = new Stack();
    /// stack.Push(1);
    /// stack.Push(2);
    /// stack.Push(3);
    /// Console.WriteLine(stack.Pop());
    /// Console.WriteLine(stack.Pop());
    /// Console.WriteLine(stack.Pop());
    /// The output of this program will be
    /// 3
    /// 2
    /// 1
    /// Note: The downside of using the object class here is that
    /// if we store value types (eg int, char, bool, DateTime)
    /// in our Stack, boxing and unboxing occurs, which comes with
    /// a small performance penalty. In my C# Advanced course, I’ll
    /// teach you how to resolve this by using generics, but for now don’t worry about it.
    /// Real-world use case: Stacks are very popular in real-world applications.
    /// Think of your browser. As you navigate the web, the address of each page
    /// you visit is stored in a stack. As you click the Back button, the most
    /// recent address is popped. This is because of the LIFO behaviour of stacks.
    /// </summary>
    internal class StackClass
    {
        /// <summary>
        /// The array list
        /// </summary>
        private readonly ArrayList  _arrayList  = new ArrayList();
        /// <summary>
        /// Initializes a new instance of the <see cref="StackClass"/> class.
        /// </summary>
        public StackClass()
        {
            
        }
        /// <summary>
        /// Pushes the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="System.ArgumentNullException">obj</exception>
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            this._arrayList.Add(obj);
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns>System.Object.</returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public object Pop()
        {
            if (this._arrayList.Count <= 0)
            {
                throw new InvalidOperationException();
            }
            int index = this._arrayList.Count - 1;
            object returnObject = this._arrayList[index];
            this._arrayList.RemoveAt(index);
            return returnObject;
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            this._arrayList.Clear();
        }
    }
}
