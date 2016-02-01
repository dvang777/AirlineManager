using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class A320 : Aircraft
    {
        new int capacity = 30;
        int firstClass = 10;
        int economyClass = 20;

        // Milwaukee to New Jersey 725 miles 1hr 27 mins
        // New Jersey to Washington D.C. 167 miles 36 mins
        // Washington D.C. to Orlando 761 miles 1 hr 56 mins
        // Orlando to Milwaukee  1069 miles 2hr 31 mins

    }
}
