namespace DomainServices
{
    public interface ISprint : ISprintContext
    {
        String ToString();
        void Export();
        void Change(string name, DateTime? startDate, DateTime? endDate);
        void StartSprint();
        void CancelSprint();
        void FinishSprint();
        void SetName(string name);
        void SetStartDate(DateTime startDate);
        void SetEndDate(DateTime endDate);
    }
}
