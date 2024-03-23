using Domain.Employees;
using Domain;
using Infrastructure;
using Infrastructure.ExportBehaviour;

namespace Portal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeFactory factory = new EmployeeFactory();
            //IEmployee testdeveloper = factory.CreateEmployee("Hans", "hans@mail.com","Developer");
            //IEmployee testproductowner = factory.CreateEmployee("Gerard","gerard@mail.com","ProductOwner");
            ScrumMaster testscrummaster = (ScrumMaster) factory.CreateEmployee("Peter", "peter@mail.com", "ScrumMaster");
            Developer testdeveloper = (Developer) factory.CreateEmployee("Hans", "hans@gmail.com", "Developer");

            //Console.WriteLine(testdeveloper);
            //Console.WriteLine(testproductowner);

            var sprint = new ReleaseSprint("test", DateTime.Now, DateTime.Now, testscrummaster, new ExportPDF());
            //sprint.Export();

            sprint.getSprintBacklog().AddBacklogItem("Login", testdeveloper);
            //Console.WriteLine(sprint.getSprintBacklog().GetBacklogItems()[0].GetState());
        }
    }
}