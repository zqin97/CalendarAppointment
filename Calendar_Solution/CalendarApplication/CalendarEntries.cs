using System;
using System.IO;
using System.Collections.Generic;

namespace Calendar
{
    public class CalendarEntries : List<ICalendarEntry>
     {
        public bool Load(string calendarEntriesFile)
        {
            bool status = true;
            string appointmentDetails;
            string[] appointmentType;
            StreamReader loadAppointment = null;

            try
            {
                loadAppointment = new StreamReader(calendarEntriesFile);
                appointmentDetails = loadAppointment.ReadLine();
                while (appointmentDetails != null)
                {
                    appointmentType = appointmentDetails.Split(',');
                    if (appointmentType[0] == "A")
                    {
                        this.Add(new SingleAppointment(appointmentDetails));
                    }
                    else if (appointmentType[0] == "R")
                    {
                        this.Add(new RecurringAppointment(appointmentDetails));
                    }
                    appointmentDetails = loadAppointment.ReadLine();
                }
            }
            catch
            {
                status = false;
            }
            finally
            {
                if (loadAppointment != null)
                {
                    status = true;
                    loadAppointment.Close();
                }
            }
            return status;
        }

        public bool Save(string calendarEntriesFile)
        {
            bool status = true;
            StreamWriter saveAppoinment = null;

            try
            {
                saveAppoinment = new StreamWriter(calendarEntriesFile, false);
                foreach (ICalendarEntry calendarEntry in this)
                {
                    saveAppoinment.WriteLine(calendarEntry.SavedData);
                }
            }
            catch 
            {
                status = false;
            }
            finally
            {
                if (saveAppoinment != null)
                {
                    status = true;
                    saveAppoinment.Close();
                }
            }
            return status;
        }

        // Iterate through the collection, returning the calendar entries that
        // occur on the specified date

        public IEnumerable<ICalendarEntry> GetCalendarEntriesOnDate(DateTime date)
        {
            for (int i = 0; i < this.Count; i++ )
            {
                if (this[i].OccursOnDate(date))
                {
                    yield return this[i];                
                }
            }
        }
    }
}