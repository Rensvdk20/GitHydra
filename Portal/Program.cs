using Domain.Employees;
using Domain;
using DomainServices;
using Infrastructure;
using Infrastructure.ExportBehaviour;

namespace Portal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeFactory factory = new EmployeeFactory();
            IEmployee testdeveloper = factory.CreateEmployee("Developer");
            IEmployee testproductowner = factory.CreateEmployee("ProductOwner");

            Console.WriteLine(testdeveloper);

            var sprint = new ReleaseSprint("test", DateTime.Now, DateTime.Now, new ScrumMaster(), new ExportPDF());
            sprint.Export();
        }
    }
}