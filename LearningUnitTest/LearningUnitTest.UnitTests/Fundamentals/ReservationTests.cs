using LearningUnitTest.Fundamentals;
using NUnit.Framework;

namespace LearningUnitTest.UnitTests.Fundamentals
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true } );

            // Assert
            //Assert.IsTrue( result );
            Assert.That( result, Is.True );
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
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

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
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
