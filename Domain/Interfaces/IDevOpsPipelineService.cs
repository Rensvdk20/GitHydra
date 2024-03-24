namespace Domain
{
    public interface IDevOpsPipelineService
    {
        void GetSource();
        void GetPackage();
        void GetTest();
        void GetAnalysis();
        void GetDeployment();
        void GetUtility();
        bool RunPipeline();
    }
}
