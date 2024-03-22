namespace Domain
{
    public interface IBacklogItemContext
    {
        IBacklogItemState GetState();
        void SetState(IBacklogItemState state);

    }
}
