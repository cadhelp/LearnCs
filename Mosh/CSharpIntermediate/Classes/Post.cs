// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 07-13-2022
//
// Last Modified By : mworland
// Last Modified On : 07-13-2022
// ***********************************************************************
// <copyright file="Post.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CSharpIntermediate.Classes
{
    using System;

    /// <summary>
    /// Create a fake Stack OVerflow post
    /// </summary>
    internal class Post
    {
        /// <summary>
        /// Gets or sets the post title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the post description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets the date the post was created.
        /// This does not have a setter since it should only be set during creation
        /// </summary>
        /// <value>The created.</value>
        public DateTime Created { get; } = DateTime.Now;

        /// <summary>
        /// Gets the vote count.
        /// Setter is private so it can not be changed outside
        /// it is initialized as 0
        /// </summary>
        /// <value>The vote count.</value>
        public int VoteCount { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Post" /> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="description">The description.</param>
        /// <exception cref="System.ArgumentNullException">title</exception>
        /// <exception cref="System.ArgumentNullException">description</exception>
        public Post(string title, string description)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException(nameof(description));
            }

            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Ups the vote.
        /// </summary>
        public void UpVote()
        {
            this.VoteCount++;
        }

        /// <summary>
        /// Downs the vote.
        /// </summary>
        public void DownVote()
        {
            this.VoteCount--;
        }
    }
}