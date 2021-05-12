using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesLabMVC
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }

        public void Display ()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{Countries[i].Name} is at {i}");
            }
        }
    }
}
