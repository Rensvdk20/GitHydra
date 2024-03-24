namespace Domain
{
    public interface IDevOpsService
    {
        void GetSource();
        void GetPackage();
        void GetTest();
        void GetAnalysis();
        void GetDeployment();
        void GetUtility();
        void Push();
        void Pull();
        void Commit();
        void Stash();
        void Pop();
        void Checkout();
    }
}
