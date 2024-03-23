namespace Domain.Employees
{
    public class ScrumMaster : IEmployee
    {
        public string name { get; }
        public string email { get; }

        public ScrumMaster(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public override string ToString()
        {
            return this.name;
        }

        public void CompleteSprint(String sprintName)
        {

        }
    }
}
