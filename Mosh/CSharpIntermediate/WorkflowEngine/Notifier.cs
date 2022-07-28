namespace WorkflowEngine
{
    using System;

    public class Notifier : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notify user the processing has started.");
        }
    }
}