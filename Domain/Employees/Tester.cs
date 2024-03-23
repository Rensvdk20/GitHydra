namespace Domain.Employees
{
    public class Tester : IEmployee
    {
        public string name { get; }
        public string email { get; }

        public Tester(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
