namespace WorkflowEngine
{
    using System;
    using System.Runtime.InteropServices;

    public class VideoEncoder : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Encoding the video.");
        }
    }
}