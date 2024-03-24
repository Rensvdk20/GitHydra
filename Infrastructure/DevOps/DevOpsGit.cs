namespace Infrastructure.DevOps
{
    public class DevOpsGit
    {
        public virtual void Push() => Console.WriteLine("Git Push method called");
        public virtual void Pull() => Console.WriteLine("Git Pull method called");
        public virtual void Commit() => Console.WriteLine("Git Commit method called");
        public virtual void Stash() => Console.WriteLine("Git Stash method called");
        public virtual void Branch() => Console.WriteLine("Git Branch method called");
        public virtual void Checkout() => Console.WriteLine("Git Checkout method called");
    }
}
