using Domain.Employees;

namespace Domain
{
    public class Project
    {
        private string name;
        private ProductOwner productOwner;
        private Backlog backlog;
        private List<ISprint> sprints = new();
        private List<Tester> testers = new();

        public Project(string name, ProductOwner productOwner)
        {
            this.name = name;
            this.productOwner = productOwner;
            this.backlog = new Backlog();
        }

        public ProductOwner GetProductOwner()
        {
            return this.productOwner;
        }

        public List<Tester> GetTesters()
        {
            return this.testers;
        }

        public void AddSprint(ISprint sprint)
        {
            this.sprints.Add(sprint);
            sprint.SetProject(this);
        }

        public void AddTester(Tester tester)
        {
            testers.Add(tester);
        }
    }
}
