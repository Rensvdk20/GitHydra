namespace Infrastructure.DevOps
{
    public class DevOpsPipeline
    {
        public void Source() => Console.WriteLine("Source method called");
        public void Package() => Console.WriteLine("Package method called");
        public void Test() => Console.WriteLine("Test method called");
        public void Analyse() => Console.WriteLine("Analyse method called");
        public void Deployment() => Console.WriteLine("Deployment method called");
        public void Utility() => Console.WriteLine("Utility method called");
    }
}
