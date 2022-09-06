using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        Dictionary<string, List<Ride>> userRides = null;
        public RideRepository()
        {
            this.userRides = new Dictionary<string, List<Ride>>();
        }
        public void AddRide(string userId, Ride[] rides)
        {
            bool ridelist = this.userRides.ContainsKey(userId);
        }
         try{
        if(!ridelist){
            List<Ride> list = new List<Ride>();
        List.AddRange(rides);
            this.UserRides.Add(userID, list);
            }
    catch(CabInvoiceException){
        throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES,"Rides are null");
}
}
              public Ride[]GetRides(string userId)
           {
    try
    {
        return this.userRides[userId Id].ToArray();
    }
    catch (Exception)
    {
        throw new cabInvoiceException(cabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid user id");

    }

    }

}


    }
}
