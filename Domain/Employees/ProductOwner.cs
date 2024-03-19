using DomainServices;

namespace Domain.Employees
{
    public class ProductOwner : IEmployee
    {
        private String name;
        private String email;

        public ProductOwner(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
