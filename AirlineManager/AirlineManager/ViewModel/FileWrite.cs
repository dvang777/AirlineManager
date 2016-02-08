using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FileWrite
    {
        public void writeFlightA320(string one)
        {
            File.AppendAllText(@"..\..\manifestA320.txt", one + Environment.NewLine);
        }
        public void writeFlightBoeing(string one)
        {
            File.AppendAllText(@"..\..\manifestBoeing.txt", one + Environment.NewLine);
        }
        public void writeFlightMD90(string one)
        {
            File.AppendAllText(@"..\..\manifestMD90.txt", one + Environment.NewLine);
        }
    }
}
