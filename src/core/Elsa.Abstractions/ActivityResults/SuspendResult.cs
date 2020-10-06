using Elsa.Services.Models;

namespace Elsa.ActivityResults
{
    public class SuspendResult : ActivityExecutionResult
    {
        protected override void Execute(ActivityExecutionContext activityExecutionContext)
        {
            activityExecutionContext.WorkflowExecutionContext.BlockingActivities.Add(activityExecutionContext.Activity);
            activityExecutionContext.WorkflowExecutionContext.Suspend();
        }
    }
}