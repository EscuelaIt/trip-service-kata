using TripServiceKata.Trip;

namespace TripServiceKata.Tests;

class TripService_WhenUserIsNotLogged : TripService
{
    protected override User.User GetLoggedUser()
    {
        return null;
    }
}