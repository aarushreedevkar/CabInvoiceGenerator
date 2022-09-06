using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException : Exception
    
    {
     public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            INVALID_RIDES,
            INVALID_USER_ID
        }
        ExceptionType type;
        private CabInvoiceException cabInvoiceException;
        private object exceptionType;
        private object iNVALID_RIDE_TYPE;
        private string v;

        public CabInvoiceException(ExceptionType type,string Message):base(Message)
        {
            this.type = type;
        }

        public CabInvoiceException(CabInvoiceException cabInvoiceException, object exceptionType, object iNVALID_RIDE_TYPE, string v)
        {
            this.cabInvoiceException = cabInvoiceException;
            this.exceptionType = exceptionType;
            this.iNVALID_RIDE_TYPE = iNVALID_RIDE_TYPE;
            this.v = v;
        }
    }
}
