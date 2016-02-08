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
        public void writeFlightA320(string a)
        {
            File.AppendAllText(@"..\..\manifestA320.txt", a + Environment.NewLine);
        }
        public void writeFlightBoeing(string b)
        {
            File.AppendAllText(@"..\..\manifestBoeing.txt", b + Environment.NewLine);
        }
        public void writeFlightMD90(string m)
        {
            File.AppendAllText(@"..\..\manifestMD90.txt", m + Environment.NewLine);
        }
    }
}
