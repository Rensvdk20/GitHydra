namespace Domain.Interfaces
{
    public interface IDevOpsGitService
    {
        void Push();
        void Pull();
        void Commit();
        void Stash();
        void Branch();
        void Checkout();
    }
}
