namespace Infrastructure.DevOps
{
    public class DevOpsPipeline
    {
        public virtual void Source() => Console.WriteLine("Source method called");
        public virtual void Package() => Console.WriteLine("Package method called");
        public virtual void Test() => Console.WriteLine("Test method called");
        public virtual void Analyse() => Console.WriteLine("Analyse method called");
        public virtual void Deployment() => Console.WriteLine("Deployment method called");
        public virtual void Utility() => Console.WriteLine("Utility method called");
    }
}
