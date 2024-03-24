using Domain;
using Domain.Interfaces;

namespace Infrastructure.DevOps
{
    public class DevOpsAdapter : IDevOpsPipelineService, IDevOpsGitService
    {
        private readonly DevOpsPipeline _pipeline;
        private readonly DevOpsGit _git;

        public DevOpsAdapter(DevOpsPipeline pipeline, DevOpsGit git)
        {
            _pipeline = pipeline;
            _git = git;
        }

        public void GetSource() => _pipeline.Source();
        public void GetPackage() => _pipeline.Package();
        public void GetTest() => _pipeline.Test();
        public void GetAnalysis() => _pipeline.Analyse();
        public void GetDeployment() => _pipeline.Deployment();
        public void GetUtility() => _pipeline.Utility();

        public bool RunPipeline()
        {
            return false;
        }

        public void Push() => _git.Push();
        public void Pull() => _git.Pull();
        public void Commit() => _git.Commit();
        public void Stash() => _git.Stash();
        public void Branch() => _git.Branch();
        public void Checkout() => _git.Checkout();
    }
}
