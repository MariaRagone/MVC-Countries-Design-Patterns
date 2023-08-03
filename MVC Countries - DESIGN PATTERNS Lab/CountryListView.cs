using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries___DESIGN_PATTERNS_Lab
{
    internal class CountryListView
    {
        //CONSTRUCTOR

        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> _countries)
        {
            Countries = _countries;
        }


        //METHODS

        public void Display()

        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i}. {Countries[i].Name}");
            }
                {

            }
        }


    }
}
