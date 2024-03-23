using Domain;
using Domain.Employees;

namespace GitHydra.Tests
{
    public class ActivityTest
    {
        [Fact]
        public void LockActivity_ActivityLocked()
        {
            // Arrange
            var developer = new Developer("Alice", "alice@example.com");
            var activity = new Activity(developer);

            // Act
            activity.LockActivity();

            // Assert
            Assert.True(activity.GetActivityLocked());
        }

        [Fact]
        public void SetDeveloper_ActivityNotLocked_DeveloperSetSuccessfully()
        {
            // Arrange
            var developer = new Developer("Alice", "alice@example.com");
            var activity = new Activity(developer);
            var newDeveloper = new Developer("Bob", "bob@example.com");

            // Act
            activity.SetDeveloper(newDeveloper);

            // Assert
            Assert.Equal(newDeveloper, activity.GetDeveloper());
        }

        [Fact]
        public void SetDeveloper_ActivityLocked_DeveloperNotSet()
        {
            // Arrange
            var developer = new Developer("Alice", "alice@example.com");
            var activity = new Activity(developer);
            var newDeveloper = new Developer("Bob", "bob@example.com");
            activity.LockActivity(); // Lock the activity

            // Act
            activity.SetDeveloper(newDeveloper);

            // Assert
            Assert.Equal(developer, activity.GetDeveloper());
        }
    }
}
