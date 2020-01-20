using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;

namespace SupplyFlow
{
    partial class Program
    {      
        static void Main()
        {
            Volunteer period = new Volunteer( "Period", 43.8561, -79.3370, 500, 50 );

            Distribute( period );
        }
    }
}
