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
        class Program
        {
                FileStream myWriter = new FileStream("Manifest.txt", FileMode.OpenOrCreate);// StreamReader opens up Values.txt, create new, sucks in data into our program
                StreamWriter sw = new StreamWriter(myWriter);
                //creates empty string called "line' variable"
                sw.WriteLine("PassengerName");
                sw.Close();

                myWriter.Close();
            }
        }
    }
