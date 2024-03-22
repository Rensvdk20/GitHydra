namespace Domain.Employees
{
    public class ScrumMaster : IEmployee
    {
        public String name { get; }
        public String email { get; }

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
