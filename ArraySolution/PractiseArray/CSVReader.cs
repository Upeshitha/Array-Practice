using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PractiseArray
{
    class CSVReader
    {
        private string csvFilePath;

        public CSVReader(string csvFilePath)
        {
            this.csvFilePath = csvFilePath;
        }

        public Country[] ReadFirstCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];

            using (StreamReader sr = new StreamReader(csvFilePath))
            {
                //read header line
                sr.ReadLine();

                for (int i = 0; i < nCountries; i++)
                {
                    string csvLine = sr.ReadLine();
                    countries[i] = ReadCountryFromCSV(csvLine);
                }
            }


            return countries;
        }

        
        public Country ReadCountryFromCSV(string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ','});

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }

    }
}
