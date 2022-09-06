using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public  class InvoiceSummary
    {
        private int numberofRides;
        private double totalfare;
        private double averagefare;

        public InvoiceSummary(int numberofRides, double totalfare, double averagefare)
        {
            this.numberofRides = numberofRides;
            this.totalfare = totalfare;
            this.averagefare = this.totalfare/this.numberofRides;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(InvoiceSummary)) return false;
            InvoiceSummary inputObject = (InvoiceSummary)obj;
            return this.numberofRides == inputObject.numberofRides && this.totalfare == inputObject.totalfare && this.averagefare == inputObject.averagefare;
        }
        public override int GetHashCode()
        {
            return this.numberofRides.GetHashCode();
        }
    }

    }

