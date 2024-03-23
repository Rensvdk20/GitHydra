namespace Domain
{
    public interface IBacklogItemContext
    {
        IBacklogItemState GetState();
        void SetState(IBacklogItemState state);
        SprintBacklog GetSprintBacklog();
        string ToString();

    }
}
