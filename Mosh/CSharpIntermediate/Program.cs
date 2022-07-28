// ***********************************************************************
// Assembly         : CSharpIntermediate
// Author           : mworland
// Created          : 06-30-2022
//
// Last Modified By : mworland
// Last Modified On : 07-22-2022
// ***********************************************************************
// <copyright file="Program.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************

/// <summary>
/// The CSharpIntermediate namespace.
/// </summary>
namespace CSharpIntermediate
{
    using System;
    using System.Collections;

    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using System.Net.Http.Headers;
    using System.Runtime.CompilerServices;

    using Casting;

    using Constructors;

    using CSharpIntermediate.Classes;

    using Extensibility;

    using PolyOverriding;
    using Interfaces;

    using WorkflowEngine;

    using DbMigrator = CSharpIntermediate.Classes.DbMigrator;
    using Order = Interfaces.Order;
    using Text = CSharpIntermediate.Classes.Text;

    using PolyShape = PolyOverriding.Shape;
    using PolyCanvas = PolyOverriding.Canvas;

    /// <summary>
    /// Class Program.
    /// </summary>
    internal class Program
    {


        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            #region Classes
            //Note Intro
            //Person person  = new Person();
            //person.Name = "matt";
            //person.Introduce("Mosh");

            //Person person2 = Person.Parse("John"); // Since this is static, no need to new up Person first, that happens in the Parse method.
            //person2.Introduce("Mosh");

            //Note Constructors
            //Customer customer = new Customer(1,"John");

            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);

            //// Note the above customer could be written using Object Initializeers like this:
            //Customer customer2 = new Customer
            //                         {
            //                             Id = 1, 
            //                             Name = "John"
            //                         };

            //Note Methods
            //UsePoints();
            //UserParams();
            //UseOutModifier();

            //Note Access Modifiers
            //Person person = new Person();
            //person.SetBirthDate(new DateTime(1982, 1, 1));
            //Console.WriteLine(person.GetBirthdate());

            //Note Properties
            /*
            To See how things are built in the IL (ntermediate language) you can build the project and go to the  executible and run "ildasm Executible.exe"
            So for this project I went to PS D:\MyRepos\LearnCs\Mosh\CSharpIntermediate\bin\debug> ildasm chsaprintermediate.exe
            I could see the automatically created backing field for BirthdateBetter and the getter and setter methods
             *
             */
            //Person person = new Person(new DateTime(1982,1,1));
            //Console.WriteLine($"Age is: {person.Age}");


            //Note Indexers
            /*
            Indexers are very helpful when trying to retrieve an item from a collection class
            if you have a collection class you should implement an indexer
             */
            //HttpCookie cookie = new HttpCookie();
            //cookie["name"] = "Mosh";
            //Console.WriteLine(cookie["name"]);

            //Note Exercise 1
            //Stopwatch();

            //Note Exercise 2 
            //StackOverFlowPost();
            #endregion

            #region Composition

            //CompositionExample();

            #endregion

            #region Inheritance

            #region Constructors

            //Car car = new Car("Reg Number");

            #endregion

            #region Casting

            //CastingTests();


            #endregion

            #region InheritanceExample

            //DesignAStack();

            #endregion

            #endregion


            #region Polymorphism

            //PolyShapes();
            //DatabaseConnection();
            //DatabaseCommand();

            #endregion

            #region Interfaces

            #region Testability

            //ProcessTheOrder();


            #endregion

            #region Extensibility

            //MigrateDatabase();

            #endregion
            
            #region Workflow Exercise

            WorkFlowExercise();


            #endregion

            #endregion

        }

        #region Private Methods

        #region Classes

        /// <summary>
        /// Uses the out modifier.
        /// </summary>
        private static void UseOutModifier()
        {
            bool parsed = int.TryParse("abc", out int number);
            if (parsed)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

        /// <summary>
        /// Users the parameters.
        /// </summary>
        private static void UserParams()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(new[] { 1, 2, 3, 4 })); // both lines achieve the same thing.
            Console.WriteLine(calculator.Add(1, 2, 3, 4)); // however since we have the params int[] in the method, we dont need to new up the int[]
        }

        /// <summary>
        /// Uses the points.
        /// </summary>
        private static void UsePoints()
        {
            try
            {
                Point point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine($"Point is at ({point.X}, {point.Y})");

                point.Move(100, 200);
                Console.WriteLine($"Point is at ({point.X}, {point.Y})");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"An unexpected error occurred: {exception}");
            }
        }

        /// <summary>
        /// Stopwatches this instance.
        /// </summary>
        private static void Stopwatch()
        {
            /*
         * Exercise 1: Design a Stopwatch
         * Design a class called Stopwatch.
         * The job of this class is to simulate a stopwatch.
         * It should provide two methods: Start and Stop.
         * We call the start method first, and the stop method next.
         * Then we ask the stopwatch about the duration between start and stop.
         * Duration should be a value in TimeSpan. Display the duration on the console.
         * We should also be able to use a stopwatch multiple times.
         * So we may start and stop it and then start and stop it again.
         * Make sure the duration value each time is calculated properly.
         * We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time).
         * So the class should throw an InvalidOperationException if its started twice.
         *
         * Educational tip: The aim of this exercise is to make you understand that a class should be always
         * in a valid state. We use encapsulation and information hiding to achieve that.
         * The class should not reveal its implementation detail. It only reveals a little bit, like a blackbox.
         * From the outside, you should not be able to misuse a class because you shouldn’t be able to see the implementation detail.
         *
         */

            Stopwatch stopwatch = new Stopwatch();
            string result = "result";
            while (!string.IsNullOrWhiteSpace(result) && result != "x")
            {
                Console.WriteLine($"Press 'S' to start the stopwatch.{Environment.NewLine}Press 'E' to stop the stopwatch.{Environment.NewLine}Press 'X' to exit.");
                result = Console.ReadLine().ToLower();
                if (result.Trim() == "s")
                {
                    stopwatch.Start();
                }
                else if (result.Trim() == "e")
                {
                    Console.WriteLine($"Duration was: {stopwatch.Stop()}");
                }
            }
        }

        /// <summary>
        /// Stacks the over flow post.
        /// </summary>
        private static void StackOverFlowPost()
        {
            /*
             * ‘Exercise 2: Design a StackOverflow Post
             * Design a class called Post.
             * This class models a StackOverflow post.
             * It should have properties for title, description and the date/time it was created.
             * We should be able to up-vote or down-vote a post. We should also be able to see the current vote value.
             * In the main method, create a post, up-vote and down-vote it a few times and then display the the
             * current vote value. In this exercise, you will learn that a StackOverflow post should provide methods
             * for up-voting and down-voting. You should not give the ability to set the Vote property from the outside,
             * because otherwise, you may accidentally change the votes of a class to 0 or to a random number.
             * And this is how we create bugs in our programs. The class should always protect its state and hide its
             * implementation detail.
             *
             * Educational tip: The aim of this exercise is to help you understand that classes should
             * encapsulate data AND behaviour around that data. Many developers (even those with years of experience)
             * tend to create classes that are purely data containers, and other classes that are purely behaviour
             * (methods) providers. This is not object-oriented programming. This is procedural programming.
             * Such programs are very fragile. Making a change breaks many parts of the code.
             */
            Post post = new Post("Title1", "Title1 Description");
            string result = "result";
            while (!string.IsNullOrWhiteSpace(result) && result != "x")
            {
                Console.WriteLine($"Press 'U' to Up vote post {post.Title}.{Environment.NewLine}Press 'D' to Down vote post {post.Title}.{Environment.NewLine}Press 'X' to exit.");
                result = Console.ReadLine().ToLower();
                if (result.Trim() == "u")
                {
                    post.UpVote();
                    Console.WriteLine($"{post.Title} has a vote count of: {post.VoteCount}");
                }
                else if (result.Trim() == "d")
                {
                    post.DownVote();
                    Console.WriteLine($"{post.Title} has a vote count of: {post.VoteCount}");
                }
            }
        }

        /// <summary>
        /// Compositions the example.
        /// </summary>
        private static void CompositionExample()
        {
            //Instead of using inheritance we can reuse Logger over and over
            //This is called composition and it is preferred to inheritance.
            //since this is a loosely coupled vs inheritance which is tightly coupled.
            //https://codewithmosh.com/courses/224763/lectures/3497892
            //Favour Composition over Inheritance -Problems with inheritance:
            //•Easily abused by amateur designers / developers
            //•Leads to large complex hierarchies•
            //Such hierarchies are very fragile and a change may affect many classes
            //•Results in tight coupling
            //-Benefits of composition:
            //•Flexible•Leads to loose coupling
            //-Having said all that, it doesn’t mean inheritance should be avoided at all times.
            //In fact, it’s great to use inheritance when dealing with very stable classes on top of small hierarchies.
            //As the hierarchy grows (or variations of classes increase), the hierarchy, however, becomes fragile.
            //And that’s where composition can give you a better design
            DbMigrator dbMigrator = new DbMigrator(new Logger());

            Logger logger = new Logger();
            Installer installer = new Installer(logger);


            dbMigrator.Migrate();

            installer.Install();
        }

        #endregion

        #region Casting
        /// <summary>
        /// Castings the tests.
        /// </summary>
        private static void CastingTests()
        {
            //Casting.Text text = new Casting.Text();
            //Shape shape = text;


            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width); // shape is merely a reference to text and they are the same memory object.


            //StringReader reader = new StringReader(new FileStream());

            Casting.Shape shape = new Casting.Text(); //upcasting to base class
            Casting.Text text = (Casting.Text)shape; // downcasting to derived class





        }

        /// <summary>
        /// Handles the Click event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // down casting to get button properties. This is an explicit cast

            Button button2 = sender as Button; // down casting using the As keyword
            if (button2 != null)
            {
                MessageBox.Show(button2.Height.ToString());
            }

            if (sender is Button) // another way to test if an item can be explicitly cast.
            {
                Button button3 = (Button)sender;
            }



        }
        #endregion

        #region Inheritance

        /// <summary>
        /// Designs a stack.
        /// </summary>
        private static void DesignAStack()
        {
            StackClass stack = new StackClass();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }

        #endregion

        #region Polymorphism

        /// <summary>
        /// Polies the shapes.
        /// </summary>
        private static void PolyShapes()
        {
            List<PolyShape> shapes = new List<PolyShape>();
            shapes.Add(new Circle());
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Rectangle());

            PolyCanvas canvas = new PolyCanvas();
            canvas.DrawShapes(shapes);

        }


        /// <summary>
        /// Databases the connection.
        /// Exercise 1: Design a database connection
        /// To access a database, we need to open a connection to it first and close it
        /// once our job is done. Connecting to a database depends on the type of the
        /// target database and the database management system (DBMS). For example,
        /// connecting to a SQL Server database is different from connecting to an
        /// Oracle database. But both these connections have a few things in common:
        /// •They have a connection string
        /// •They can be opened•They can be closed
        /// •They may have a timeout attribute (so if the connection could not be
        /// opened within the timeout, an exception will be thrown).
        /// Your job is to represent these commonalities in a base class called DbConnection.
        /// This class should have two properties:
        /// ConnectionString : string
        /// Timeout : TimeSpan
        /// A DbConnection will not be in a valid state if it doesn’t have a
        /// connection string. So you need to pass a connection string in the
        /// constructor of this class. Also, take into account the scenarios
        /// where null or an empty string is sent as the connection string.
        /// Make sure to throw an exception to guarantee that your class will
        /// always be in a valid state.
        /// Our DbConnection should also have two methods for opening and closing a
        /// connection. We don’t know how to open or close a connection in a
        /// DbConnection and this should be left to the classes that derive from DbConnection.
        /// These classes (eg SqlConnection or OracleConnection) will provide the actual
        /// implementation. So you need to declare these methods as abstract.
        /// Derive two classes SqlConnection and OracleConnection from DbConnection and
        /// provide a simple implementation of opening and closing connections using
        /// Console.WriteLine(). In the real-world, SQL Server provides an API for
        /// opening or closing a connection to a database. But for this exercise,
        /// we don’t need to worry about it.
        /// </summary>
        private static void DatabaseConnection()
        {
            PolyOverriding.SqlConnection sqlConnection = new PolyOverriding.SqlConnection("Connection String");
            sqlConnection.Open();
            sqlConnection.Close();

            PolyOverriding.OracleConnection oracleConnection = new PolyOverriding.OracleConnection("Connection String");
            oracleConnection.Open();
            oracleConnection.Close();

        }

        /// <summary>
        /// Databases the command.
        /// Exercise 2: Design a database command
        /// Now that we have the concept of a DbConnection, let’s work out how to represent
        /// a DbCommand. Design a class called DbCommand for executing an instruction against
        /// the database. A DbCommand cannot be in a valid state without having a connection.
        /// So in the constructor of this class, pass a DbConnection. Don’t forget to cater for the null.
        /// Each DbCommand should also have the instruction to be sent to the database. In case of SQL Server,
        /// this instruction is expressed in T-SQL language. Use a string to represent this instruction.
        /// Again, a command cannot be in a valid state without this instruction. So make sure to receive
        /// it in the constructor and cater for the null reference or an empty string. Each command should be
        /// executable. So we need to create a method called Execute(). In this method, we need a simple
        /// implementation as follows:
        /// Open the connection
        /// Run the instruction
        /// Close the connection
        /// Note that here, inside the DbCommand, we have a reference to DbConnection. Depending
        /// on the type of DbConnection sent at runtime, opening and closing a connection will be different.
        /// For example, if we initialize this DbCommand with a SqlConnection, we will open and close a
        /// connection to a Sql Server database. This is polymorphism. Interestingly, DbCommand doesn’t
        /// care about how a connection is opened or closed. It’s not the responsibility of the DbCommand.
        /// All it cares about is to send an instruction to a database. For running the instruction, simply
        /// output it to the Console. In the real-world, SQL Server (or any other DBMS) provides an API for
        /// running an instruction against the database. We don’t need to worry about it for this exercise.
        /// In the main method, initialize a DbCommand with some string as the instruction and a SqlConnection.
        /// Execute the command and see the result on the console.Then, swap the SqlConnection with an
        /// OracleConnection and see polymorphism in action
        /// </summary>
        private static void DatabaseCommand()
        {
            PolyOverriding.SqlConnection sqlConnection = new PolyOverriding.SqlConnection("Connection String");
            PolyOverriding.DbCommand sqlCommand = new PolyOverriding.DbCommand(sqlConnection,"Instructions");
            sqlCommand.Execute();

            PolyOverriding.OracleConnection oracleConnection = new PolyOverriding.OracleConnection("Connection String");
            PolyOverriding.DbCommand oracleCommand = new PolyOverriding.DbCommand(oracleConnection,"Instructions");
            oracleCommand.Execute();

        }

        #endregion

        #region Interfaces

        #region Testability

        /// <summary>
        /// Processes the order.
        /// </summary>
        private static void ProcessTheOrder()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ShippingCalculator());
            Order order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);

            // Run unit tests to test this code
        }

        #endregion

        #region Extensibility

        /// <summary>
        /// Migrates the database.
        /// </summary>
        private static void MigrateDatabase()
        {
            Extensibility.DbMigrator dbMigrator = new Extensibility.DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
            Extensibility.DbMigrator dbMigrator2 = new Extensibility.DbMigrator(new FileLogger(@"C:\Logger.txt"));
            dbMigrator2.Migrate();
        }


        #endregion

        #region Workflow Exercise

        /// <summary>
        /// Works the flow exercise.
        /// Exercise: Design a workflow engine
        /// Design a workflow engine that takes a workflow object and runs it. A workflow
        /// is a series of steps or activities. The workflow engine class should have one
        /// method called Run() that takes a workflow, and then iterates over each activity
        /// in the workflow and runs it.We want our workflows to be extensible, so we can
        /// create new activities without impacting the existing activities.
        ///
        /// Educational tip: we should represent the concept of an activity using an interface.
        /// Each activity should have a method called Execute(). The workflow engine does not care
        /// about the concrete implementation of activities. All it cares about is that these activities
        /// have a common interface: they provide a method called Execute(). The engine simply calls this
        /// method and this way it executes a series of activities in sequence.
        ///
        /// The aim of this exercise is to help you understand how you can use interfaces to design
        /// extensible applications. You change the behaviour of your application by creating new classes,
        /// rather than changing the existing classes. You’ll also see polymorphic behaviour of interfaces.
        ///
        /// Real-world use case: in a real-world application you may use a workflow in a scenario
        /// like the following:
        /// 1- Upload a video to a cloud storage.
        /// 2- Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding.
        /// 3- Send an email to the owner of the video notifying them that the video started processing.
        /// 4- Change the status of the video record in the database to “Processing”.
        ///
        /// Each of these steps can be represented by an activity. For the purpose of this exercise,
        /// do not worry about these complexities. Simply use Console.WriteLine() in each of your
        /// activity classes. Your focus should be on sending a workflow to the workflow engine and
        /// having it run the workflow and all the activities inside it. We don’t care about the actual activities
        /// </summary>
        private static void WorkFlowExercise()
        {
            Workflow workflow = new Workflow();
            workflow.Add(new VideoUploader());
            workflow.Add(new VideoEncoder());
            workflow.Add(new Notifier());
            workflow.Add(new StatusUpdator());

            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);


        }
        

        #endregion

        #endregion

        #endregion

    }
}


