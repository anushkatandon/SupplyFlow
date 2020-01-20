using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;

namespace SupplyFlow
{
    partial class Program
    {
        public static Organization[] AddOrganizationFromList( )
        {
            List<Organization> array = new List <Organization>();

            List<OrganizationImportance> organizationList = new List <OrganizationImportance>();

            const string path = "Organizations.txt";
            const FileMode mode =  FileMode.Open;
            const FileAccess access = FileAccess.Read;

            using FileStream file = new FileStream( path, mode, access );
            using StreamReader reader = new StreamReader( file );

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string [] fields = line.Split(",");

                Organization organize = new Organization(fields[0], double.Parse( fields[1] ), double.Parse( fields[2] ), Int32.Parse(fields[3]), double.Parse(fields[4]), double.Parse(fields[5]), double.Parse(fields[6]));

                //array.ForEach(WriteLine);

                array.Add(organize);

            }
            Organization[] toArray = array.ToArray();
            return toArray;
        }

    }
}