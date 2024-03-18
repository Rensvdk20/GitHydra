using DomainServices;
using Infrastructure;

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
        }
    }
}