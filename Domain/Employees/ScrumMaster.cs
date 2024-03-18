using DomainServices;

namespace Domain.Employees
{
    public class ScrumMaster : IEmployee
    {
        private String name;
        private String email;

        public ScrumMaster(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
