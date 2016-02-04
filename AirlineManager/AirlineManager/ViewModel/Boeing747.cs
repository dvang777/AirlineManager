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
            firstClass = 9;
            economyclass = 21;
            range = 2831;
        }

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
