using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Display
    {    
        //4.Create Method with the same Signature with Event
        public void DisplayTemp(object? obj, TempArgs args)
        {
            Console.WriteLine($"The temperature now set to : {args.getTemp}");
        }
    }
}
