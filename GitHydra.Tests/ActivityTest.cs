using Domain;
using Domain.Employees;
using Moq;

namespace GitHydra.Tests
{
    public class ActivityTest
    {
        [Fact]
        public void SetDeveloper_DeveloperChangedSuccessfully()
        {
            // Arrange
            var developer = new Developer("John", "john@example.com");
            var newDeveloper = new Developer("Alice", "alice@example.com");

            // Mock de BacklogItem met de juiste parameters voor de constructor
            var backlogItemMock = new Mock<BacklogItem>("Task", developer);

            // Geef aan Moq door hoe de constructor moet worden aangeroepen
            backlogItemMock.Setup(b => b.IsChangeable()).Returns(true);

            // Creëer de activiteit met de mock van de BacklogItem
            var activity = new Activity("Task", developer, backlogItemMock.Object);

            // Act
            activity.SetDeveloper(newDeveloper);

            // Assert
            Assert.Equal(newDeveloper, activity.GetDeveloper());
        }

        [Fact]
        public void SetDeveloper_DeveloperNotChangedIfBacklogItemNotChangeable()
        {
            // Arrange
            var developer = new Developer("John", "john@example.com");
            var newDeveloper = new Developer("Alice", "alice@example.com");

            // Mock de BacklogItem met de juiste parameters voor de constructor
            var backlogItemMock = new Mock<BacklogItem>("Task", developer);

            // Geef aan Moq door hoe de constructor moet worden aangeroepen
            backlogItemMock.Setup(b => b.IsChangeable()).Returns(false);

            // Creëer de activiteit met de mock van de BacklogItem
            var activity = new Activity("Task", developer, backlogItemMock.Object);

            // Act
            activity.SetDeveloper(newDeveloper);

            // Assert
            Assert.Equal(developer, activity.GetDeveloper());
        }
    }
}
