using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class CountryDataBase
    {
        public List<Country> Countries = new List<Country>();

        public CountryDataBase()
        {
            List<string> usaColors = new List<string>{ "Red", "White", "Blue" };
            Countries.Add(new Country("USA", "North America", usaColors));

            List<string> colombiaColors = new List<string> { "Yellow", "Blue", "Red" };
            Countries.Add(new Country("Colombia", "South America", colombiaColors));

            List<string> englandColors = new List<string> { "Red", "White" };
            Countries.Add(new Country("England", "Europe", englandColors));

            List<string> walesColors = new List<string> { "Red", "White", "Green" };
            Countries.Add(new Country("Wales", "Europe", walesColors));

            List<string> scotlandColors = new List<string> { "Blue", "White" };
            Countries.Add(new Country("Scotland", "Europe", scotlandColors));

            List<string> hongKongColors = new List<string> { "Red", "White" };
            Countries.Add(new Country("Hong Kong", "Asia", hongKongColors));

            List<string> thailandColors = new List<string> { "Blue", "Red", "White" };
            Countries.Add(new Country("Thailand", "Asia", thailandColors));

            List<string> cambodiaColors = new List<string> { "Red", "Blue" };
            Countries.Add(new Country("Cambodia", "Asia", cambodiaColors));

            List<string> irelandColors = new List<string> { "Green", "Blue", "White", "Orange" };
            Countries.Add(new Country("Ireland", "Europe", irelandColors));

            List<string> canadaColors = new List<string> { "Red", "White" };
            Countries.Add(new Country("Canada", "North America", canadaColors));

            List<string> spainColors = new List<string> { "Red", "Gold" };
            Countries.Add(new Country("Spain", "Europe", spainColors));

            List<string> portugalColors = new List<string> { "Green", "Red" };
            Countries.Add(new Country("Portugal", "Europe", portugalColors));

            List<string> moroccoColors = new List<string> { "Red", "Green" };
            Countries.Add(new Country("Morocco", "Africa", moroccoColors));

            List<string> norwayColors = new List<string> { "Red", "Blue", "White" };
            Countries.Add(new Country("Norway", "Europe", norwayColors));

            List<string> northernIrelandColors = new List<string> { "Red", "White" };
            Countries.Add(new Country("Northen Ireland", "Europe", northernIrelandColors));

            List<string> franceColors = new List<string> { "Blue", "White", "Red" };
            Countries.Add(new Country("France", "Europe", franceColors));

            List<string> belgiumColors = new List<string> { "Red", "Black", "Yellow" };
            Countries.Add(new Country("Belgium", "Europe", belgiumColors));

            List<string> netherlandsColors = new List<string> { "Orange", "Red", "White", "Blue" };
            Countries.Add(new Country("Netherlands", "Europe", netherlandsColors));

            List<string> germanyColors = new List<string> { "Black", "Red", "Gold" };
            Countries.Add(new Country("Germany", "Europe", germanyColors));

            List<string> mexicoColors = new List<string> { "Green", "White", "Red" };
            Countries.Add(new Country("Mexico", "Europe", mexicoColors));
        }        
    }
}
