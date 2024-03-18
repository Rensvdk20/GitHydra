using Domain;
using DomainServices;

namespace Infrastructure
{
    public class EmployeeFactory
    {
        public IEmployee CreateEmployee(String type)
        {
            IEmployee employee = null;

            if (type.Equals("Developer"))
            {
                employee = new Domain.Employees.Developer();
            } else if (type.Equals("ProductOwner"))
            {
                employee = new Domain.Employees.ProductOwner();
            } else if (type.Equals("ScrumMaster"))
            {
                employee = new Domain.Employees.ScrumMaster();
            }
            else if (type.Equals("Tester"))
            {
                employee = new Domain.Employees.Tester();
            } else
            {
                throw new Exception();
            }

            return employee;
        }
    }
}
