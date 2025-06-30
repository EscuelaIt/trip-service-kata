using System.Collections.Generic;
using TripServiceKata.Trip;

namespace TripServiceKata.Tests;

class TripService_WhenNoFriends : TripService
{
    protected override User.User GetLoggedUser()
    {
        return new();
    }
}