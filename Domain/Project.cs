using Domain.Employees;

namespace Domain
{
    public class Project
    {
        private ProductOwner productOwner;
        private Backlog backlog;

        public Project(ProductOwner productOwner, Backlog backlog)
        {
            this.productOwner = productOwner;
            this.backlog = backlog;
        }
    }
}
