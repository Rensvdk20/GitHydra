namespace Infrastructure.DevOps
{
    public class DevOpsGit
    {
        public virtual void Push() => Console.WriteLine("Push method called");
        public virtual void Pull() => Console.WriteLine("Pull method called");
        public virtual void Commit() => Console.WriteLine("Commit method called");
        public virtual void Stash() => Console.WriteLine("Stash method called");
        public virtual void Pop() => Console.WriteLine("Pop method called");
        public virtual void Checkout() => Console.WriteLine("Checkout method called");
    }
}
