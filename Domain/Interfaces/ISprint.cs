using Domain.Employees;
using Domain.Interfaces;

namespace Domain
{
    public interface ISprint : ISprintContext
    {
        string ToString();
        void Export();
        void Change(string name, DateTime? startDate, DateTime? endDate);
        SprintBacklog GetSprintBacklog();

        void Subscribe(ISubscriber subscriber);
        ScrumMaster GetScrumMaster();

        void NotifySubscribers(string message, string employee);
        void SetProject(Project project);
        Project GetProject();
    }
}
