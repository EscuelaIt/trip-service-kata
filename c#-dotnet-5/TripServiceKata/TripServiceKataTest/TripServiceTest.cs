using System;
using Xunit;
using FluentAssertions;
using TripServiceKata.Trip;

namespace TripServiceKata.Tests
{
    public class TripServiceTest
    {
        // Step 1: the easiest test is the one from the not logged in user
        [Fact]
        public void UserNotLoggedIn_ShouldRaise()
        {
            // Arrange
            var tripService = new TripServiceKata.Trip.TripService();

            // Act
            Action act = () => tripService.GetTripsByUser(new User.User());

            // Assert
            act.Should().Throw<TripServiceKata.Exception.UserNotLoggedInException>();
        }
    }
}
