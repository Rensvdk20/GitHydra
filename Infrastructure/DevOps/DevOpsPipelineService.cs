using Domain;

namespace Infrastructure.DevOps
{
    public class DevOpsPipelineService : IDevOpsPipelineService
    {
        private readonly DevOpsAdapter _devOpsAdapter;

        public DevOpsPipelineService(DevOpsAdapter devOpsAdapter)
        {
            _devOpsAdapter = devOpsAdapter;
        }

        public void GetSource() => _devOpsAdapter.GetSource();
        public void GetPackage() => _devOpsAdapter.GetPackage();
        public void GetTest() => _devOpsAdapter.GetTest();
        public void GetAnalysis() => _devOpsAdapter.GetAnalysis();
        public void GetDeployment() => _devOpsAdapter.GetDeployment();
        public void GetUtility() => _devOpsAdapter.GetUtility();
    }
}
