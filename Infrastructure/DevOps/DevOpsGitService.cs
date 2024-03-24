using Domain;

namespace Infrastructure.DevOps
{
    public class DevOpsGitService : Domain.Interfaces.IDevOpsGitService
    {
        private readonly DevOpsAdapter _devOpsAdapter;

        public DevOpsGitService(DevOpsAdapter devOpsAdapter)
        {
            _devOpsAdapter = devOpsAdapter;
        }

        public void Push() => _devOpsAdapter.Push();
        public void Pull() => _devOpsAdapter.Pull();
        public void Commit() => _devOpsAdapter.Commit();
        public void Stash() => _devOpsAdapter.Stash();
        public void Pop() => _devOpsAdapter.Pop();
        public void Checkout() => _devOpsAdapter.Checkout();
    }
}