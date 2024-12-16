using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Alarm
    {
		private double _alarmValue;

        public Alarm( double alarm)
        {
            AlarmValue = alarm;
        }

        public double AlarmValue
        {
			get { return _alarmValue; }
			set { _alarmValue = value; }
		}

		public void FireAlarm(object? obj, TempArgs args)
		{
			if (args.getTemp > AlarmValue)
			{
                Console.WriteLine($"Take Care, The Temp Value {args.getTemp} is Grater than {AlarmValue}");
			}
		}
	}
}
