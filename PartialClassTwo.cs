using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassAndMethod
{
     partial class PartialClass
    {
        // Partial method implemented
        partial void PartialMethod()
        {
            Console.WriteLine("Partial PartialMethod  Invoked");
        }
    }

}
