using System;
using System.Collections.Generic;
using System.Text;

namespace PractiseArray
{
    public class Country
    {
        public string Name { get; set; }
        public string code { get; set; }
        public string Regin { get; set; }
        public int Population { get; set; }

        public Country(string name, string code, string regin, int population)
        {
            Name = name;
            this.code = code;
            Regin = regin;
            Population = population;
        }

        
    }
}
