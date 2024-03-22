namespace Domain
{
    public interface ISprint : ISprintContext
    {
        String ToString();
        void Export();
        void Change(string name, DateTime? startDate, DateTime? endDate);
        SprintBacklog getBacklog();
    }
}
