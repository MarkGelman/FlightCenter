using System;
using System.Collections.Generic;
using System.Text;

namespace FlightCenter.POCO
{
    class Country
    {
        long Id { get; set; }
        string Name { get; set; }
        public Country()
        {

        }

        public Country(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
