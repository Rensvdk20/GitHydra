using DomainServices;

namespace Domain.Employees
{
    public class ScrumMaster : IEmployee
    {
        private String name;
        private String email;

        public ScrumMaster(String name, String email)
        {
            this.name = name;
            this.email = email;
        }

        public void CompleteSprint(String sprintName)
        {

        }
    }
}
