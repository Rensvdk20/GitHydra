namespace Domain
{
    public interface ISprintContext
    {
        ISprintState GetState();
        void SetSprintState(ISprintState state);
        void SetName(string name);
        void SetStartDate(DateTime startDate);
        void SetEndDate(DateTime endDate);
        void NotifySubscribers(string message, string employee);
        string ToString();
        string GetReviewSummary();
    }
}
