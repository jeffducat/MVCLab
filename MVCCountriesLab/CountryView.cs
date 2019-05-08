using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }

        public void Display()
        {
            Console.WriteLine(DisplayCountry.Name);
            Console.WriteLine(DisplayCountry.Continent);

            foreach(string color in DisplayCountry.Colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
