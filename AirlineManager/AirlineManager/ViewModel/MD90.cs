using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class MD90 : Aircraft
    {
        int firstClass;
        int economy;

        public MD90()
        {
            capacity = 30;
            firstClass = 10;
            economy = 20;
            range = 2722;
        }

        // Milwaukee to SFO 1,843 miles 3hrs 41 mins
        // SFO to Phoenix 651 miles 1hr 44 mins
        // Phoenix to Milwaukee 1460 miles 3 hrs 16 mins 
        

    }
}
