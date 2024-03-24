using Domain.Employees;
using Domain.Interfaces;
using System.Text.RegularExpressions;

namespace Domain
{
    public class Project
    {
        private string name;
        private ProductOwner productOwner;
        private Backlog backlog;
        private List<ISprint> sprints = new();
        private List<Tester> testers = new();
        private IDevOpsGitService devOpsGitService;

        public Project(string name, ProductOwner productOwner, IDevOpsGitService devOpsGitService)
        {
            this.name = name;
            this.productOwner = productOwner;
            this.backlog = new Backlog();
            this.devOpsGitService = devOpsGitService;
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

        public List<ISprint> GetSprints()
        {
            return this.sprints;
        }

        public void AddTester(Tester tester)
        {
            testers.Add(tester);
        }

        public IDevOpsGitService GetDevOpsGitService()
        {
            return devOpsGitService;
        }
    }
}
