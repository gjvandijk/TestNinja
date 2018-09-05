using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    // Naming convention for TestClass: <Classname>Tests
    public class ReservationTests // Ctrl+R,R to rename (resharper)
    {
        [Test]
        // Naming convention for TestMethod: // <Testmethod>_<Scenario>_<ExpectedBehavior>()
        // Scenario: execution path
        // Behavior: returned value or exception thrown
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue() 
        {
            // Triple A convention:
            // Arrange => initialize objects
            var reservation = new Reservation(); // Ctrl+. to add reference to TestNinja project
            // Act: Call the method to be tested
            var result = reservation.CanBeCancelledBy(new User {IsAdmin = true} );
            // Assert: check the result 
//            Assert.IsTrue(result); // is same as ...
//            Assert.That(result, Is.True); // is same as ...
            Assert.That(result == true);


        }
        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            // Arrange
            var admin = new User() {IsAdmin = true};
            var reservation = new Reservation() {MadeBy = admin};
            // Act
            var result = reservation.CanBeCancelledBy(admin);
            // Assert
            Assert.That (result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation() { MadeBy = new User() };
            // Act
            var result = reservation.CanBeCancelledBy(new User {IsAdmin = false});
            // Assert
            Assert.That(result, Is.False);

        }
    }
}
