using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class CountryController
    {
        public void CountryAction(Country c)
        {
            CountryView countryView = new CountryView(c);
            countryView.Display(); 
        }
        public void WelcomeAction()
        {
            bool run = true;
            Console.WriteLine("Hello! Welcome to the country app!");
            while (run)
            {
                Console.WriteLine("Would you like to select a country? Enter y to start or any other key twice to exit.");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    CountryDataBase countryDataBase = new CountryDataBase();
                    CountryListView countryListView = new CountryListView(countryDataBase.Countries);
                    Console.WriteLine("Please select a country from the following list: ");
                    countryListView.Display();

                    int selection = int.Parse(Console.ReadLine());
                    CountryAction(countryDataBase.Countries[selection]);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
