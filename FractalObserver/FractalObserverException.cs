// programmed by Adrian Magdina in 2012
// in this file is the implementation of custom exception for this application
using System;
using System.Collections.Generic;
using System.Text;

namespace FractalObserverApplication
{
    // exception class, for exceptions thrown directly from code of this application
    [Serializable()]
    public class FractalObserverException : Exception
    {
        public FractalObserverException()
            : base()
        {
        }
        public FractalObserverException(string message)
            : base(message)
        {
        }
        public FractalObserverException(string message, Exception inner)
            : base(message, inner)
        {
        }
 
        protected FractalObserverException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}
