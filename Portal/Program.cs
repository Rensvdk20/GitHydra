using Domain.Employees;
using Domain;
using Domain.BacklogItemState;
using Domain.SprintState;
using Infrastructure;
using Infrastructure.ExportBehaviour;
using Infrastructure.Listeners;
using Thread = Domain.Thread;

namespace Portal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EmployeeFactory factory = new EmployeeFactory();
            ////IEmployee testproductowner = factory.CreateEmployee("Gerard","gerard@mail.com","ProductOwner");
            //ScrumMaster testscrummaster = (ScrumMaster) factory.CreateEmployee("Peter", "peter@mail.com", "ScrumMaster");
            //Developer testdeveloper = (Developer) factory.CreateEmployee("Hans", "hans@gmail.com", "Developer");

            //var sprint = new ReleaseSprint("test", DateTime.Now, DateTime.Now, testscrummaster, new ExportPDF());
            //sprint.SetSprintState(new SprintInProgress(sprint));
            ////sprint.Export();

            //var backlog = sprint.GetSprintBacklog().AddBacklogItem("Login", testdeveloper);
            //backlog.AddActivity("testtt", testdeveloper);
            //backlog.AddThread(new Thread("Login feature"));

            EmployeeFactory factory = new EmployeeFactory();
            ScrumMaster testscrummaster = (ScrumMaster) factory.CreateEmployee("Peter", "peter@mail.com", "ScrumMaster");
            var sprint = new ReleaseSprint("test", DateTime.Now, DateTime.Now, testscrummaster, new ExportPDF());

            sprint.Subscribe(new EmailSubscriber());
            //sprint.Subscribe(new SlackSubscriber());
            //sprint.NotifySubscribers("testt", "scrum master");

            BacklogItem backlogitem = sprint.GetSprintBacklog().AddBacklogItem("Login feature", new Developer("Hans", "Hans@gmail.com"));
            //backlogitem.SetDeveloper(new Developer("Gert", "Gert@gmail.com"));

            Project project = new Project("Call-a-Car", new ProductOwner("Henk", "henk@gmail.com"));
            project.AddSprint(sprint);

            //sprint.SetSprintState(new SprintCancelled(sprint));
            //sprint.GetState().StartSprint();
            //sprint.GetState().FinishSprint();

            project.AddTester(new Tester("tester1", "tester1@gmail.com"));
            project.AddTester(new Tester("tester2", "tester2@gmail.com"));

            //backlogitem.GetState().MoveToDoing();
            //backlogitem.GetState().MoveToReadyForTesting();

            backlogitem.AddActivity("test", new Developer("Max", "max@gmail.com"));
            backlogitem.SetState(new BacklogItemDoing(backlogitem));
            backlogitem.SetState(new BacklogItemReadyForTesting(backlogitem));
            backlogitem.SetState(new BacklogItemReadyForTesting(backlogitem));
            backlogitem.SetState(new BacklogItemTested(backlogitem));
            backlogitem.GetActivities()[0].SetDone(true);
            backlogitem.SetState(new BacklogItemDone(backlogitem));
        }
    }
}