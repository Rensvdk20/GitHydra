namespace Domain
{
    public interface IAvansDevOps
    {
        void GetSource();
        void GetPackage();
        void GetTest();
        void GetAnalysis();
        void GetDeployment();
        void GetUtility();
    }
}
