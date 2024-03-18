using DomainServices;

namespace Domain.Employees
{
    public class Tester : IEmployee
    {
        private String name;
        private String email;

        public Tester(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
