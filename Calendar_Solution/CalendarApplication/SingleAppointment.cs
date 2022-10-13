using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class SingleAppointment : ICalendarEntry
    {
        protected DateTime _Start;
        int _Length;
        string _DisplayText;
        string _SavedData;
        protected string[] data;

        public SingleAppointment()
        {
        }

        public SingleAppointment(string load)
        {
            string[] lengthData;

            data = load.Split(',');
            lengthData = data[4].Split(' ');
            _DisplayText = data[1] + "," + data[2];
            _Start = DateTime.Parse(data[3]);
            _Length = int.Parse(lengthData[1]);
        }

        public DateTime Start
        {
            get
            {
                return _Start;
            }
            set
            {
                _Start = value;
            }
        }

        public int Length
        {
            get
            {
                return _Length;
            }
            set
            {
                _Length = value;
            }
        }

        public string DisplayText
        {
            get
            {
                return _DisplayText;
            }
            set
            {
                _DisplayText = value;
            }
        }

        public string SavedData
        {
            get
            {
                return _SavedData;
            }
            set
            {
                _SavedData = value;
            }
        }

        public virtual bool OccursOnDate(DateTime date)
        {
            if (date.Date == _Start.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
