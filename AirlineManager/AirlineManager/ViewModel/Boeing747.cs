using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class Boeing747 : Aircraft
    {
        int firstClass;
        int economyclass;

        public Boeing747()
        {
            capacity = 30;
            firstClass = 10;
            economyclass = 20;
            range = 2831;
        }

        // Milwaukee to Atlanta 671 miles 1hr 46mins
        // Atlanta to Dallas 721 miles 1hr 48mins
        // Dallas to Denver 662 miles 1hr 19mins
        // Denver to Milwaukee 777 miles 2hr 12 mins

        public string maintenance()
        {
            if (status == true)
            {
                return "Ready";
            }
            else
            {
                return "Under Maintenance";
            }
        }
    }
}
