using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class Boeing747 : Aircraft
    {
        new int capacity = 30;
        // first = 10 economy = 20
        new double range = 9206.4;

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
