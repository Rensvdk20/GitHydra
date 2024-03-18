using DomainServices;

namespace Domain.Employees
{
    public class Developer : IEmployee
    {
        private String name;
        private String email;

        public Developer(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
