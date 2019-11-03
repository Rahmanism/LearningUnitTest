using LearningUnitTest.Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearningUnitTest.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true } );

            // Assert
            Assert.IsTrue( result );
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            var user = new User();
            reservation.MadeBy = user;

            // Act
            var result = reservation.CanBeCancelledBy( user );

            // Assert
            Assert.IsTrue( result );
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy( new User() );

            // Assert
            Assert.IsFalse( result );
        }
    }
}
