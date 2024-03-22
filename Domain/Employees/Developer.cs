namespace Domain.Employees
{
    public class Developer : IEmployee
    {
        public String name { get; }
        public String email { get; }

        public Developer(String name, String email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
