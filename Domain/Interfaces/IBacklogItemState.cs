namespace Domain
{
    public interface IBacklogItemState
    {
        void MoveToDoing();
        void MoveToReadyForTesting();
        void MoveToTesting();
        void MoveToTested();
        void MoveToDone();
    }
}
