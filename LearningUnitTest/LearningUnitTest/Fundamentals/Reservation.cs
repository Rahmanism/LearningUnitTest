using System;
using System.Collections.Generic;
using System.Text;

namespace LearningUnitTest.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            return ( user.IsAdmin || MadeBy == user );
        }
    }
}
