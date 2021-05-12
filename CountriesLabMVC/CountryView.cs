using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesLabMVC
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name}\n{DisplayCountry.Continent}\n{DisplayCountry.Colors}");
        }
    }
}
