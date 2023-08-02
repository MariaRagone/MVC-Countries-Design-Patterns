using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries___DESIGN_PATTERNS_Lab
{
    internal class CountryController
    {
        public List<Country> CountryDb = new List<Country>()
        {
            new Country("USA", Country.Continent.NorthAmerica, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue),
            new Country("Peru", Country.Continent.SouthAmerica, ConsoleColor.Red, ConsoleColor.White),
            new Country("Italy", Country.Continent.Europe, ConsoleColor.Green, ConsoleColor.White, ConsoleColor.DarkYellow),
            new Country("United Kingdom", Country.Continent.Europe, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue),
            new Country("Germany", Country.Continent.Europe, ConsoleColor.Red, ConsoleColor.Black, ConsoleColor.Yellow),
            new Country("Egypt", Country.Continent.Africa, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Black),
            new Country("Japan", Country.Continent.Asia, ConsoleColor.Red, ConsoleColor.White),
            new Country("Austrialia", Country.Continent.Oceania, ConsoleColor.White, ConsoleColor.DarkBlue),

        };

        //METHOD
        public void CountryAction(Country c)//takes in the country model
        {
            CountryView country = new CountryView(c);
            country.Display();
        }

        public void WelcomeAction()
        {
            Console.WriteLine($"Hello, welcome to the country app. Please select a country from the following list:");
            int countryChoice = int.Parse(Console.ReadLine());
            Country c = CountryDb[countryChoice];

            CountryListView viewCountryList = new CountryListView(CountryDb);
            viewCountryList.Display();//displays all of the countries in the list

        }
    }
}
