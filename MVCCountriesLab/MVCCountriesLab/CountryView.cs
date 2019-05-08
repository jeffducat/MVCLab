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

            foreach (string color in DisplayCountry.Colors)
            {
                PrintInColor(color);
            }
        }

        public static void PrintInColor(string message)
        {
            switch (message)
            {
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    break;
                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    break;
                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    break;
                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    break;
                case "Black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    break;
                case "Orange":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    break;
                case "Gold":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
    }
}

