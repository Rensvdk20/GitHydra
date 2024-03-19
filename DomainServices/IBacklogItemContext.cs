namespace DomainServices
{
    public interface IBacklogItemContext
    {
        IBacklogItemState GetState();
        void SetState(IBacklogItemState state);

    }
}
