﻿using System.Collections.Generic;
using System.Linq;
using TripServiceKata.Exception;
using TripServiceKata.User;

namespace TripServiceKata.Trip
{
    public class TripService
    {
        public List<Trip> GetTripsByUser(User.User user)
        {
            var tripList = new List<Trip>();
            var loggedUser = GetLoggedUser();
            if (loggedUser == null)
                throw new UserNotLoggedInException();

            var isFriend = user.GetFriends().Contains(loggedUser);
            if (isFriend)
            {
                tripList = FindTripsByUser(user);
            }
            return tripList;
        }

        protected virtual List<Trip> FindTripsByUser(User.User user)
        {
            return TripDAO.FindTripsByUser(user);
        }

        protected virtual User.User GetLoggedUser()
        {
            return UserSession.GetInstance().GetLoggedUser();
        }
    }
}
