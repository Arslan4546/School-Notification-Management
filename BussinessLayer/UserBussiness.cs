using DataLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class UserBussiness
    {

        public static UserClass GetUserVerifiedBusiness(UserClass user)
        {
            return UserDB.GetUserVerifiedDB(user);

        }
    }
}
