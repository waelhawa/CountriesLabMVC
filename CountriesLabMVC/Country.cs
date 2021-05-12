﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesLabMVC
{
    class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }

        public Country(string name, string continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }
    }
}
