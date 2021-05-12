using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesLabMVC
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; }

        public void CountryAction (Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            clv.Display();
            int input = int.Parse(Console.ReadLine());
            CountryAction(CountryDb[input]);
        }
    }
}
