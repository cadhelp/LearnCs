namespace WorkflowEngine
{
    using System.Collections.Generic;

    public interface IWorkflow
    {
        void Add(IActivity iActivity);
        void Remove(IActivity activity);

        IEnumerable<IActivity> GetActivities();
    }
}