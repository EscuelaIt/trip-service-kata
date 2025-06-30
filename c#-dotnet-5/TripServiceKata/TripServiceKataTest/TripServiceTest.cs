using System;
using Xunit;
using FluentAssertions;

namespace TripServiceKata.Tests
{
    public class TripServiceTest
    {
        [Fact]
        public void UserNotLoggedIn_ShouldRaise_AfterRefactoring()
        {
            // Arrange
            var sut = new TripService_WhenUserIsNotLogged();
        
            // Act
            Action act = () => sut.GetTripsByUser(new());
        
            // Assert
            act.Should().Throw<Exception.UserNotLoggedInException>();
        }
    }
}
