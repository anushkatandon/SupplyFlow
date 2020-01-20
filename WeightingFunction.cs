using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;

namespace SupplyFlow
{
    partial class Program
    {
        static double A ( double rateOfDepletion, int initialValue )
        {
            double x =  (0 - initialValue)/rateOfDepletion;
            return x;
        }

        static double Importance( Organization currentOrg )
        {
            double x = A( currentOrg.RateOfDepletion, currentOrg.Inventory);
            double y = currentOrg.Traffic;
            double z = currentOrg.Income;
            // Higher the number, the higher the importance
            double importance = 60 * (1/x) + .3 * y + 10 * (1/z);
            return importance;
        } 

    }
}