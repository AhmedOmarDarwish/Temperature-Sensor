using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Broker
    {
        //Create Dictionary to hold Subjects & subscribers
        private Dictionary<string, List<Action<TempArgs>>> _SubscriberList = new();
        /*
         * TempChanged -> (Alarm, Display)
         * */
        public void Subscribe(string subject, Action<TempArgs> action)
        {
            //adding the action (Handler) to subscribersList
            if (!_SubscriberList.ContainsKey(subject))
            {
                _SubscriberList[subject] = new List<Action<TempArgs>>();
            }
                _SubscriberList[subject].Add(action);
            
        }

        public void Publish(string subject, TempArgs message) {

            if (_SubscriberList.ContainsKey(subject))
            {
            List<Action<TempArgs>> subscribersToSubjects = _SubscriberList[subject];

            foreach (var subscriber in subscribersToSubjects) {
                subscriber.Invoke(message);
            }
            }

        }

    }
}
