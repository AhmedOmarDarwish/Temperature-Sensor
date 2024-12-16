using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class TempArgs : EventArgs
    {
        private double _temp;

        public TempArgs( double temp) { 
            _temp = temp;
        }

        public double getTemp
        {
            get { return _temp; }
        }
    }
}

