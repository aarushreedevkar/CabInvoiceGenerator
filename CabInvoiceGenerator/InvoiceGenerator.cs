using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        RideType rideType;
        private RideRepository rideRepository;
        private double MINIMUM_COST_PER_KM;
        private int COST_PER_TIME;
        private double MINIMUM_FARE;

        public InvoiceGenerator(RideType rideType)
        {
            this.rideType = rideType;
            this.rideRepository = new RideRepository();
            try
            {
                if (rideType.Equals(RideType.NORMAL))
                {
                    this.MINIMUM_COST_PER_KM = 5;
                    this.COST_PER_TIME = 1;
                    this.MINIMUM_FARE = 5;
                }
                else if (rideType.Equals(RideType.NORMAL))
                {
                    this.MINIMUM_COST_PER_KM = 15;
                    this.COST_PER_TIME = 2;
                    this.MINIMUM_FARE = 20;
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE_TYPE, "Invalid Ride");
            }
        }
        public double Calculate(double distance, int time)
        {
            double totalFare = 0;
            try
            {
                totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_TIME; }



            }catch(CabInvoiceException)
            {
            if(rideType.Equals(null))
            {
            throw new CabInvoiceException(CabInvoiceExceptio.ExceptionType.INVALID_DISTANCE,"Invalid Distance");
    }
    if(time <= 0)
        {

        throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_TIME,"Invalid Time");
}
return Math.Max(totalFare, MINIMUM_FARE);
}
  public InvoiceSummary calculateFareRide[] ride)
    {
    double totalFare = 0;
    try
    {
        foreach (Ride ride in ride)
        {
            totalFare += this.calculatefare(ride.distance, ride.time);
        }
    }
    catch (cabInvoiceException)
    {
        if (rideType.Equals(null))
        {
            throw new cabInvoiceException(cabInvoiceException.ExceptionType)}
    }
    return new Invoicesummary(rides.length, totalFare);
}





        



           
            
            }
    }
}
