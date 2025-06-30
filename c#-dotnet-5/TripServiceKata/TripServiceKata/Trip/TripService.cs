using System.Collections.Generic;
using System.Linq;
using TripServiceKata.Exception;
using TripServiceKata.User;

namespace TripServiceKata.Trip
{
    public class TripService
    {
        public List<Trip> GetTripsByUser(User.User user)
        {
            List<Trip> tripList = new List<Trip>();
            User.User loggedUser = GetLoggedUser();
            if (loggedUser == null)
                throw new UserNotLoggedInException();

            bool isFriend = user.GetFriends().Contains(loggedUser);
            if (isFriend)
            {
                tripList = TripDAO.FindTripsByUser(user);
            }
            return tripList;
        }

        protected virtual User.User GetLoggedUser()
        {
            return UserSession.GetInstance().GetLoggedUser();
        }
    }
}
