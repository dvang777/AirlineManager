using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class A320 : Aircraft
    {
        int firstClass;
        int economyClass;

        public A320()
        {
            capacity = 30;
            firstClass = 10;
            economyClass = 20;
            range = 3954;
        }

    }
}
