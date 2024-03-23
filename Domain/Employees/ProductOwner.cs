namespace Domain.Employees
{
    public class ProductOwner : IEmployee
    {
        public string name { get; }
        public string email { get; }

        public ProductOwner(string name, string email)
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
