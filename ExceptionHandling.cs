using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    
    
        class NameSizeException : Exception
        {
            public string message;
            public NameSizeException(String message)
            {
                this.message = message;
            }

        }

        class PriceException : Exception
        {
            public string message;
            public PriceException(String message)
            {
                this.message = message;
            }
        }
    
}
