using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class RecurringAppointment : SingleAppointment
    {
        RecurringFrequency _Frequency;
        int _Count;

        public RecurringAppointment()
        {
        }

        public RecurringAppointment(string load) : base(load)
        {
            string[] frequencyData;
            string[] frequency;
            string[] count;
            
            frequencyData = data[2].Split(' ');
            frequency = frequencyData[frequencyData.Length - 1].Split(')');
            count = data[5].Split(' ');
            _Frequency = (RecurringFrequency)Enum.Parse(typeof(RecurringFrequency), frequency[0]);
            _Count = int.Parse(count[1]);
        }

        public RecurringFrequency Frequency
        {
            get
            {
                return _Frequency;
            }
            set
            {
                _Frequency = value;
            }
        }

        public int Count
        {
            get
            {
                return _Count;
            }
            set
            {
                _Count = value;
            }
        }

        public override bool OccursOnDate(DateTime date)
        {
            int x = 0;
            List<DateTime> DateList = new List<DateTime>();
            DateTime testDay;

            switch (Frequency)
            {
                case RecurringFrequency.Daily:
                    for (x = 0; x <= _Count; x++)
                    {
                        testDay = _Start.AddDays(x);
                        DateList.Add(testDay);
                    }
                    break;

                case RecurringFrequency.Weekly:
                    for (x = 0; x <= _Count; x++)
                    {
                        testDay = _Start.AddDays(x * 7);
                        DateList.Add(testDay);
                    }
                    break;

                case RecurringFrequency.Fortnightly:
                    for (x = 0; x <= _Count; x++)
                    {
                        testDay = _Start.AddDays(x * 14);
                        DateList.Add(testDay);
                    }
                    break;

                case RecurringFrequency.Monthly:
                    for (x = 0; x <= _Count; x++)
                    {
                        testDay = _Start.AddMonths(x);
                        DateList.Add(testDay);
                    }
                    break;

                case RecurringFrequency.Yearly:
                    for (x = 0; x <= _Count; x++)
                    {
                        testDay = _Start.AddYears(x);
                        DateList.Add(testDay);
                    }
                    break;

                default:
                    break;
            }
            foreach (DateTime day in DateList)
            {
                if (day.Date == date.Date)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
