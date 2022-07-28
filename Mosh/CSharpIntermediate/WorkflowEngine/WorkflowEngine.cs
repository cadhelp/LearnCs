namespace WorkflowEngine
{
    using System;
    using System.Data.SqlClient;

    public class WorkflowEngine 
    {
        public void Run(IWorkflow workflow)
        {
            foreach (IActivity activity in workflow.GetActivities())
            {
                try
                {
                    activity.Execute();
                }
                catch (Exception exception)
                {
                    //Log the error
                    // Terminate and persist the state of the workflow
                    //throw
                    
                }
            }
        }
    }
}