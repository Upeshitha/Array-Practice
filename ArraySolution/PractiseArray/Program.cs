using System;

namespace PractiseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"E:\User\Desktop\Arrays\Countries Population.csv";

            CSVReader reader = new CSVReader(filepath);
            Country[] countries = reader.ReadFirstCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
