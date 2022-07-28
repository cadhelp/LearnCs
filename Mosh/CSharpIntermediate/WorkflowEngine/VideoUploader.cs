namespace WorkflowEngine
{
    using System;

    public class VideoUploader : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading the video.");
        }
    }
}