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
            IEmployee testdeveloper = factory.CreateEmployee("Hans", "hans@mail.com","Developer");
            IEmployee testproductowner = factory.CreateEmployee("Gerard","gerard@mail.com","ProductOwner");

            Console.WriteLine(testdeveloper);
            Console.WriteLine(testproductowner);

            var sprint = new ReleaseSprint("test", DateTime.Now, DateTime.Now, new ScrumMaster(), new ExportPDF());
            sprint.Export();
        }
    }
}