namespace Domain.Employees
{
    public class Developer : IEmployee
    {
        public string name { get; }
        public string email { get; }

        public Developer(string name, string email)
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
