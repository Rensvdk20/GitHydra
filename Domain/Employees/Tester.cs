using DomainServices;

namespace Domain.Employees
{
    public class Tester : IEmployee
    {
        public String name { get; }
        public String email { get; }

        public Tester(String name, String email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
