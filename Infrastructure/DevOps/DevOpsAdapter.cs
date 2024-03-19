using DomainServices;

namespace Infrastructure.DevOps
{
    public class DevOpsAdapter : IAvansDevOps
    {
        private readonly DevOpsPipeline _pipeline;

        public DevOpsAdapter(DevOpsPipeline pipeline)
        {
            _pipeline = pipeline;
        }

        public void GetSource() => _pipeline.Source();
        public void GetPackage() => _pipeline.Package();
        public void GetTest() => _pipeline.Test();
        public void GetAnalysis() => _pipeline.Analyse();
        public void GetDeployment() => _pipeline.Deployment();
        public void GetUtility() => _pipeline.Utility();
    }
}
