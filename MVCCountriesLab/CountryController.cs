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
            while (run)
            {
                CountryDataBase countryDataBase = new CountryDataBase();
                CountryListView countryListView = new CountryListView(countryDataBase.Countries);
                Console.WriteLine("Hello, welcome to the country app.  Please select a country from the following list: ");
                countryListView.Display();

                int selection = int.Parse(Console.ReadLine());
                CountryAction(countryDataBase.Countries[selection]);
            }
        }
    }
}
