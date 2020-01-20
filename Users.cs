using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;

namespace SupplyFlow
{
    public class Organization
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Inventory { get; set; }
        public double Traffic { get; set; }
        public double RateOfDepletion { get; set; }
        public double Income { get; set; }

        public Organization( string newName, double newLatitude, double newLongitude, int newInventory, double newTraffic, double newRate, double newIncome ) {
            this.Name = newName;
            this.Latitude = newLatitude;
            this.Longitude = newLongitude;
            this.Inventory = newInventory;
            this.Traffic = newTraffic/100;
            this.RateOfDepletion = newRate;
            this.Income = newIncome/10000;
        }

        public override string ToString() {
            return $"Organization name: {Name}, latitude: {Latitude}, longitude: {Longitude}, inventory: {Inventory}, traffic: {Traffic}, area's financial average: {Income}";
        }
    }

    public class Volunteer
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Inventory { get; set; }
        public double Radius { get; set; }

        public Volunteer( string newName, double newLatitude, double newLongitude, int newInventory, double newRadius )
        {
            this.Name = newName;
            this.Latitude = newLatitude;
            this.Longitude = newLongitude;
            this.Inventory = newInventory;
            this.Radius = newRadius;
        }

        public override string ToString()
        {
            return $"Organization name {Name}, latitude: {Latitude}, longitude: {Longitude}, inventory: {Inventory}, radius: {Radius}";
        }
    }

    public class OrganizationImportance
    {
        public string Name { get; set; }
        public double Importance { get; set; }

        public OrganizationImportance( string newName, double newImportance )
        {
            this.Name = newName;
            this.Importance = newImportance;
        }

        public override string ToString()
        {
            return $"{Name} {Importance}";
        }
    }
}