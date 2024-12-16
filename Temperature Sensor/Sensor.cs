using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Sensor
    {
		private Broker _broker;
		public Sensor(Broker broker) { 
		_broker = broker;
		}
		private double _currentTemp;

		public double ChangeTemp
        {
			get { return _currentTemp; }
			set { _currentTemp = value;
				_broker.Publish("TemperatureChanged",new TempArgs(value));
			}
		}



	}
}
