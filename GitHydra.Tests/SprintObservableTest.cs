using Domain.Employees;
using Domain.Interfaces;
using Domain.Observer;
using Domain;
using Moq;
using Infrastructure.ExportBehaviour;

namespace GitHydra.Tests
{
    public class SprintObservableTest
    {
        [Fact]
        public void Subscribe_SubscriberAddedSuccessfully()
        {
            // Arrange
            var sprintMock = new Mock<ISprint>();
            var observable = new SprintObservable(sprintMock.Object);
            var subscriberMock = new Mock<ISubscriber>();

            // Act
            observable.Subscribe(subscriberMock.Object);

            // Assert
            Assert.Contains(subscriberMock.Object, observable.GetSubscribers());
        }

        [Fact]
        public void Unsubscribe_SubscriberRemovedSuccessfully()
        {
            // Arrange
            var sprintMock = new Mock<ISprint>();
            var observable = new SprintObservable(sprintMock.Object);
            var subscriberMock = new Mock<ISubscriber>();
            observable.Subscribe(subscriberMock.Object);

            // Act
            observable.Unsubscribe(subscriberMock.Object);

            // Assert
            Assert.DoesNotContain(subscriberMock.Object, observable.GetSubscribers());
        }

        [Fact]
        public void NotifySubscribers_MessageSentSuccessfully()
        {
            // Arrange
            var sprintMock = new Mock<ISprint>();
            var observable = new SprintObservable(sprintMock.Object);
            var subscriberMock = new Mock<ISubscriber>();
            observable.Subscribe(subscriberMock.Object);

            // Voeg een ontwikkelaar toe aan een backlogitem
            var developer = new Developer("John", "john@example.com");
            var backlogItem = new BacklogItem("Task", developer);
            sprintMock.Setup(s => s.GetSprintBacklog()).Returns(new SprintBacklog(new ProductSprint("Sprint", DateTime.Now, DateTime.Now.AddDays(7), new ScrumMaster("Master", "master@example.com"), new ExportPNG())));

            sprintMock.Object.GetSprintBacklog().AddBacklogItem("Task", developer);

            var message = "Test message";

            // Act
            observable.NotifySubscribers(message, "developers");

            // Assert
            subscriberMock.Verify(subscriber => subscriber.Notify(message, It.IsAny<Developer>()), Times.Once);
        }
    }
}