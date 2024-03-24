using Domain;

namespace Infrastructure.DevOps
{
    public class DevOpsService : IDevOpsService
    {
        private readonly DevOpsAdapter _devOpsAdapter;

        public DevOpsService(DevOpsAdapter devOpsAdapter)
        {
            _devOpsAdapter = devOpsAdapter;
        }

        public void GetSource() => _devOpsAdapter.GetSource();
        public void GetPackage() => _devOpsAdapter.GetPackage();
        public void GetTest() => _devOpsAdapter.GetTest();
        public void GetAnalysis() => _devOpsAdapter.GetAnalysis();
        public void GetDeployment() => _devOpsAdapter.GetDeployment();
        public void GetUtility() => _devOpsAdapter.GetUtility();
        public void Push() => _devOpsAdapter.Push();
        public void Pull() => _devOpsAdapter.Pull();
        public void Commit() => _devOpsAdapter.Commit();
        public void Stash() => _devOpsAdapter.Stash();
        public void Pop() => _devOpsAdapter.Pop();
        public void Checkout() => _devOpsAdapter.Checkout();
    }
}
