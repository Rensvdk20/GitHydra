using Domain;
using Domain.BacklogItemState;
using Domain.Employees;
using Moq;

namespace GitHydra.Tests
{
    public class BacklogItemTest
    {
        [Fact]
        public void BacklogItem_CreatedWithDeveloper_HasCorrectDeveloper()
        {
            // Arrange
            var developer = new Developer("John", "john@example.com");
            var backlogItem = new BacklogItem("Task", developer);

            // Assert
            Assert.Equal(developer, backlogItem.GetDeveloper());
        }

        [Fact]
        public void BacklogItem_AddActivity_ActivityAddedSuccessfully()
        {
            // Arrange
            var backlogItem = new BacklogItem("Task", new Developer("John", "john@example.com"));

            // Act
            backlogItem.AddActivity("Activity", new Developer("Alice", "alice@example.com"));

            // Assert
            Assert.Contains(backlogItem.GetActivities()[0], backlogItem.GetActivities());
        }

        [Fact]
        public void BacklogItem_AddThread_ThreadAddedSuccessfully()
        {
            // Arrange
            var backlogItem = new BacklogItem("Task", new Developer("John", "john@example.com"));
            var thread = new Domain.Thread("Discussion thread", backlogItem);

            // Act
            backlogItem.AddThread(thread);

            // Assert
            Assert.Contains(thread, backlogItem.GetAllThreads());
        }

        [Fact]
        public void BacklogItem_SetDeveloper_DeveloperChangedSuccessfully()
        {
            // Arrange
            var backlogItem = new BacklogItem("Task", new Developer("John", "john@example.com"));
            var newDeveloper = new Developer("Alice", "alice@example.com");

            // Act
            backlogItem.SetDeveloper(newDeveloper);

            // Assert
            Assert.Equal(newDeveloper, backlogItem.GetDeveloper());
        }

        [Fact]
        public void BacklogItem_SetState_StateChangedSuccessfully()
        {
            // Arrange
            var backlogItem = new BacklogItem("Task", new Developer("John", "john@example.com"));
            var newState = new BacklogItemDoing(backlogItem);

            // Act
            backlogItem.SetState(newState);

            // Assert
            Assert.Equal(newState, backlogItem.GetState());
        }

        [Fact]
        public void BacklogItem_MoveToDoing_StateChangesToDoingSuccessfully()
        {
            // Arrange
            var backlogItem = new BacklogItem("Task", new Developer("John", "john@example.com"));
            var newState = new BacklogItemTodo(backlogItem); // Start in Todo state
            backlogItem.SetState(newState);

            // Act
            backlogItem.MoveToDoing();

            // Assert
            Assert.IsType<BacklogItemDoing>(backlogItem.GetState());
        }

        [Fact]
        public void BacklogItem_CreatedWithDeveloperAndSprintBacklog_HasCorrectDeveloperAndSprintBacklog()
        {
            // Arrange
            var developer = new Developer("John", "john@example.com");
            var sprintBacklog = new SprintBacklog(Mock.Of<ISprint>());

            // Act
            var backlogItem = new BacklogItem("Task", developer, sprintBacklog);

            // Assert
            Assert.Equal(developer, backlogItem.GetDeveloper());
            Assert.Equal(sprintBacklog, backlogItem.GetSprintBacklog());
        }

        [Fact]
        public void BacklogItem_CreatedWithDeveloperAndSprintBacklog_DefaultsCorrectly()
        {
            // Arrange
            var developer = new Developer("John", "john@example.com");
            var sprintBacklog = new SprintBacklog(Mock.Of<ISprint>());

            // Act
            var backlogItem = new BacklogItem("Task", developer, sprintBacklog);

            // Assert
            Assert.Empty(backlogItem.GetActivities());
            Assert.Empty(backlogItem.GetAllThreads());
            Assert.IsType<BacklogItemTodo>(backlogItem.GetState());
        }
    }
}