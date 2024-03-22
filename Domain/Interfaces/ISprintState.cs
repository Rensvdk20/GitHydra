namespace Domain
{
    public interface ISprintState
    {
        void StartSprint();
        void CancelSprint();
        void FinishSprint();
        void Change(string name, DateTime? startDate, DateTime? endDate);
    }
}
