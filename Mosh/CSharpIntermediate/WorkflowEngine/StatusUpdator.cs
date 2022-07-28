namespace WorkflowEngine
{
    using System;

    public class StatusUpdator : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Updating the status of the video.");
        }
    }
}