using Domain.Employees;
using Domain;
using Domain.SprintState;
using Infrastructure;
using Infrastructure.ExportBehaviour;
using Thread = Domain.Thread;

namespace Portal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeFactory factory = new EmployeeFactory();
            //IEmployee testproductowner = factory.CreateEmployee("Gerard","gerard@mail.com","ProductOwner");
            ScrumMaster testscrummaster = (ScrumMaster) factory.CreateEmployee("Peter", "peter@mail.com", "ScrumMaster");
            Developer testdeveloper = (Developer) factory.CreateEmployee("Hans", "hans@gmail.com", "Developer");

            var sprint = new ReleaseSprint("test", DateTime.Now, DateTime.Now, testscrummaster, new ExportPDF());
            sprint.SetSprintState(new SprintInProgress(sprint));
            //sprint.Export();

            var backlog = sprint.GetSprintBacklog().AddBacklogItem("Login", testdeveloper);
            backlog.AddActivity("testtt", testdeveloper);
            backlog.AddThread(new Thread("Login feature"));
        }
    }
}