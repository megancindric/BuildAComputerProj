using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAComputer
{
    class RAM
    {
        //Random-access memory.  Device's short-term memory.  Temporarily stores (remembers) everything that runs on your PC, like all services in Windows, web browser, games, etc.

        //member variables
        public double totalGigabytes;
        public string brand;
        //constructor
        public RAM(double totalGigabytes, string brand)
        {
            this.totalGigabytes = totalGigabytes;
            this.brand = brand;
        }

        //member methods
    }
}
