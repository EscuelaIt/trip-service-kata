using System;
using Xunit;
using FluentAssertions;
using TripServiceKata.Trip;

namespace TripServiceKata.Tests
{
    /*
     * Creemos que devuelve lista vacía si no es amigo.
     * asdlfasdlk
     * ajskldfjalskd
     */
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
        
        [Fact]
        public void GetTripsByUser_ShouldReturnEmptyList_WhenUserIsNotFriend()
        {
            // Arrange
            var sut = new TripService_WhenNoFriends();
        
            // Act
            var result = sut.GetTripsByUser(new());
        
            // Assert
            result.Should().BeEmpty();
        }
    }
}
