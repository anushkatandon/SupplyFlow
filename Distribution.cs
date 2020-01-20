using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;

namespace SupplyFlow
{
    partial class Program
    {
        static double Haversine(double lat1, double lon1, double lat2, double lon2) 
        { 
            // distance between latitudes and longitudes 
            double dLat = (Math.PI / 180) * (lat2 - lat1); 
            double dLon = (Math.PI / 180) * (lon2 - lon1); 
        
            // convert to radians 
            lat1 = (Math.PI / 180) * (lat1); 
            lat2 = (Math.PI / 180) * (lat2); 
        
            // apply formulae 
            double a = Math.Pow(Math.Sin(dLat / 2), 2) +  
                    Math.Pow(Math.Sin(dLon / 2), 2) *  
                    Math.Cos(lat1) * Math.Cos(lat2); 
            double rad = 6371; 
            double c = 2 * Math.Asin(Math.Sqrt(a)); 
            return rad * c; 
        } 

        public static void ReturnAmounts( OrganizationImportance[] sortedImportance, double sum, int donations ) 
        {
            foreach( OrganizationImportance i in sortedImportance ) 
            {
                WriteLine( $"{i.Name} should be given {(int)(donations*i.Importance/sum)} items.");
            }
        }
        public static void Distribute( Volunteer period )
        {
            Organization[] array = AddOrganizationFromList();

            List<OrganizationImportance> organizationList = new List<OrganizationImportance>();

            for( int i =0; i < array.Length; i++ )
            {
                if( Haversine( array[i].Latitude, array[i].Longitude, period.Latitude, period.Longitude) < period.Radius )
                {
                    OrganizationImportance newOrganization = new OrganizationImportance( array[ i ].Name, Importance( array[ i ] ) );
                    organizationList.Add( newOrganization );
                    //WriteLine( newOrganization);
                }
            }

            OrganizationImportance[] sortedImportance = organizationList.ToArray(); 
            InsertionSort( sortedImportance );

            double importanceSum = 0;
            foreach( OrganizationImportance x in sortedImportance ) 
            {
                //WriteLine( x );
                importanceSum += x.Importance;
            }

            ReturnAmounts( sortedImportance, importanceSum, period.Inventory );
        }
        

    }
}