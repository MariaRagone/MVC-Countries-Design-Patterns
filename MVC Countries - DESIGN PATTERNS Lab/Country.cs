using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries___DESIGN_PATTERNS_Lab
{

    //THIS IS THE MODEL
    internal class Country
    {
        public enum Continent //hard set so that ppl can't brake your code
        {
            NorthAmerica,
            Europe,
            Africa,
            Asia,
            SouthAmerica,
            Antartica,
            Oceania

        }
        public string Name { get; set; }
        public Continent CountryContinent { get; set; }

        public List<ConsoleColor> Colors { get; set; }

        //CONSTRUCTOR
        public Country(string _name, Continent _continent, params ConsoleColor[] _colors)
        {
            Name = _name;
            CountryContinent = _continent;
            Colors = _colors.ToList();
        }
    }
}
