using Domain;

namespace Infrastructure
{
    public class EmployeeFactory
    {
        public IEmployee CreateEmployee(String name, String email, String type)
        {
            IEmployee employee = null;

            if (type.Equals("Developer"))
            {
                employee = new Domain.Employees.Developer(name, email);
            } else if (type.Equals("ProductOwner"))
            {
                employee = new Domain.Employees.ProductOwner(name, email);
            } else if (type.Equals("ScrumMaster"))
            {
                employee = new Domain.Employees.ScrumMaster(name, email);
            }
            else if (type.Equals("Tester"))
            {
                employee = new Domain.Employees.Tester(name, email);
            } else
            {
                throw new Exception();
            }

            return employee;
        }
    }
}
