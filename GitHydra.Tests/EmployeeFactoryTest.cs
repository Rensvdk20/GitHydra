using Infrastructure;
using Domain.Employees;
using Domain;

namespace GitHydra.Tests
{
    public class EmployeeFactoryTest
    {
        private readonly EmployeeFactory _employeeFactory;

        public EmployeeFactoryTest()
        {
            _employeeFactory = new EmployeeFactory();
        }

        [Fact]
        public void CreateEmployee_DeveloperType_ReturnsDeveloperInstance()
        {
            // Arrange
            string name = "John Doe";
            string email = "john.doe@example.com";
            string type = "Developer";

            // Act
            IEmployee employee = _employeeFactory.CreateEmployee(name, email, type);

            // Assert
            Assert.NotNull(employee);
            Assert.IsType<Developer>(employee);
            Assert.Equal(name, employee.name);
            Assert.Equal(email, employee.email);
        }

        [Fact]
        public void CreateEmployee_ProductOwnerType_ReturnsProductOwnerInstance()
        {
            // Arrange
            string name = "Jane Smith";
            string email = "jane.smith@example.com";
            string type = "ProductOwner";

            // Act
            IEmployee employee = _employeeFactory.CreateEmployee(name, email, type);

            // Assert
            Assert.NotNull(employee);
            Assert.IsType<ProductOwner>(employee);
            Assert.Equal(name, employee.name);
            Assert.Equal(email, employee.email);
        }

        [Fact]
        public void CreateEmployee_ScrumMasterType_ReturnsScrumMasterInstance()
        {
            // Arrange
            string name = "Alice Wonderland";
            string email = "alice.wonderland@example.com";
            string type = "ScrumMaster";

            // Act
            IEmployee employee = _employeeFactory.CreateEmployee(name, email, type);

            // Assert
            Assert.NotNull(employee);
            Assert.IsType<ScrumMaster>(employee);
            Assert.Equal(name, employee.name);
            Assert.Equal(email, employee.email);
        }

        [Fact]
        public void CreateEmployee_TesterType_ReturnsTesterInstance()
        {
            // Arrange
            string name = "Bob Builder";
            string email = "bob.builder@example.com";
            string type = "Tester";

            // Act
            IEmployee employee = _employeeFactory.CreateEmployee(name, email, type);

            // Assert
            Assert.NotNull(employee);
            Assert.IsType<Tester>(employee);
            Assert.Equal(name, employee.name);
            Assert.Equal(email, employee.email);
        }

        [Fact]
        public void CreateEmployee_UnknownType_ThrowsException()
        {
            // Arrange
            string name = "Unknown";
            string email = "unknown@example.com";
            string type = "UnknownType";

            // Act & Assert
            Assert.Throws<Exception>(() => _employeeFactory.CreateEmployee(name, email, type));
        }
    }
}
