using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Sensor
    {
		//1.Declare Event
		public event EventHandler<TempArgs> SensorChanged;
		private double _currentTemp;

		public double ChangeTemp
        {
			get { return _currentTemp; }
			set { _currentTemp = value;
                //2.Invoke Event and send value
                SensorChanged.Invoke(this,new TempArgs(value));
			}
		}



	}
}
