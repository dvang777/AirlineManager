using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FileRead
    {
            public void readFlightA320()
            {

                using (StreamReader read = new StreamReader(@"..\..\manifestA320.txt"))
                {
                    read.ReadToEnd();
                    read.Close();
                    read.Dispose();
                }
            }
        public void readFlightBoeing()
        {

            using (StreamReader read = new StreamReader(@"..\..\manifestBoeing.txt"))
            {
                read.ReadToEnd();
                read.Close();
                read.Dispose();
            }
        }
        public void readFlightMD90()
        {

            using (StreamReader read = new StreamReader(@"..\..\manifestMD90.txt"))
            {
                read.ReadToEnd();
                read.Close();
                read.Dispose();
            }
        }
    }
}
