using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
            Console.WriteLine();
        }
        public void WelcomeAction()
        {
            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine($"Hello, welcome to the country app. Please select a country from the following list:");

                CountryListView viewCountryList = new CountryListView(CountryDb);
                viewCountryList.Display();//displays all of the countries in the list

                int countryChoice = 0;
                while (int.TryParse(Console.ReadLine(), out countryChoice) == false || countryChoice < 0 || countryChoice > CountryDb.Count-1)//adding the -1 doesn't seem to do anything

                // only runs infinately if the user types something that fails
                {
                    Console.WriteLine("Invalid response. Try again"); //error message

                }
                Country c = CountryDb[countryChoice];
                CountryAction(c);

                bool keepGoing = true;
                while (keepGoing)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    //the application should prompt the user to continue and continue only if the user agrees to
                    Console.WriteLine("Would you like to learn about another country? y/n");
                    string end = Console.ReadLine().ToLower().Trim();
                    if (end == "n")
                    {
                        //use a break when there is a valid input
                        Console.WriteLine("Bye!");
                        keepGoing = false;
                        runProgram = false;
                        break;
                    }
                    else if (end == "y")
                    {
                        runProgram = true;
                        //use a break when there is a valid input
                        break;
                    }
                    else
                    {
                        //do not use a break when there is no valid input
                        Console.WriteLine("That is not a valid response.");
                    }
                }



            }
        }

    }
}
