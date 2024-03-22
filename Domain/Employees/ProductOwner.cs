namespace Domain.Employees
{
    public class ProductOwner : IEmployee
    {
        public String name { get; }
        public String email { get; }

        public ProductOwner(String name, String email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
