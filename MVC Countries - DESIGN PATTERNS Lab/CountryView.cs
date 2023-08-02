using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries___DESIGN_PATTERNS_Lab
{
    internal class CountryView
    {

        //PROPERTY
        public Country DisplayCountry { get; set; }//can do any data type as a property, or
                                                   //define your own data type as property

        //CONSTRUCTOR

        public CountryView(Country _country)
        {
            DisplayCountry = _country;
        }



        //METHODS
        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}, Continent {DisplayCountry.CountryContinent}, Colors {DisplayCountry.Colors}");

            foreach (ConsoleColor c in DisplayCountry.Colors)
            {
                Console.ForegroundColor = c;
                Console.Write(c + " ");
            }
        }
    }
}
