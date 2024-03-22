using Domain;
using Domain.BacklogItemState;
using Domain.Employees;
using Xunit;

namespace GitHydra.Tests
{
    public class BacklogItemTest
    {
        [Fact]
        public void BacklogItem_CreatedWithDeveloper_HasCorrectDeveloper()
        {
            // Arrange
            var developer = new Developer("John", "john@example.com");
            var backlogItem = new BacklogItem(developer);

            // Assert
            Assert.Equal(developer, backlogItem.GetDeveloper());
        }

        [Fact]
        public void BacklogItem_AddActivity_ActivityAddedSuccessfully()
        {
            // Arrange
            var backlogItem = new BacklogItem(new Developer("John", "john@example.com"));
            var activity = new Activity(new Developer("Alice", "alice@example.com"));

            // Act
            backlogItem.AddActivity(activity);

            // Assert
            Assert.Contains(activity, backlogItem.GetActivities());
        }

        [Fact]
        public void BacklogItem_AddThread_ThreadAddedSuccessfully()
        {
            // Arrange
            var backlogItem = new BacklogItem(new Developer("John", "john@example.com"));
            var thread = new Domain.Thread("Discussion thread", true);

            // Act
            backlogItem.AddThread(thread);

            // Assert
            Assert.Contains(thread, backlogItem.GetAllThreads());
        }

        [Fact]
        public void BacklogItem_SetDeveloper_DeveloperChangedSuccessfully()
        {
            // Arrange
            var backlogItem = new BacklogItem(new Developer("John", "john@example.com"));
            var newDeveloper = new Developer("Alice", "alice@example.com");

            // Act
            backlogItem.SetDeveloper(newDeveloper);

            // Assert
            Assert.Equal(newDeveloper, backlogItem.GetDeveloper());
        }

        [Fact]
        public void BacklogItem_SprintInProgress_BacklogItemLockedAndActivitiesLocked()
        {
            // Arrange
            var backlogItem = new BacklogItem(new Developer("John", "john@example.com"));
            backlogItem.AddActivity(new Activity(new Developer("Alice", "alice@example.com")));

            // Act
            backlogItem.SprintInProgress();

            // Assert
            Assert.True(backlogItem.GetBacklogItemLocked());
            foreach (var activity in backlogItem.GetActivities())
            {
                Assert.True(activity.GetActivityLocked());
            }
        }

        [Fact]
        public void BacklogItem_SetState_StateChangedSuccessfully()
        {
            // Arrange
            var backlogItem = new BacklogItem(new Developer("John", "john@example.com"));
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
            var backlogItem = new BacklogItem(new Developer("John", "john@example.com"));
            var newState = new BacklogItemTodo(backlogItem); // Start in Todo state
            backlogItem.SetState(newState);

            // Act
            backlogItem.MoveToDoing();

            // Assert
            Assert.IsType<BacklogItemDoing>(backlogItem.GetState());
        }

    }
}
