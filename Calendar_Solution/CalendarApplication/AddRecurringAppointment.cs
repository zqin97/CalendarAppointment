using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class AddRecurringAppointment : Form
    {
        RecurringAppointment _recurringAppointment = null;

        RecurringFrequency frequency;
        DateTime start;
        int length;

        public AddRecurringAppointment()
        {
            InitializeComponent();
        }

        public RecurringAppointment RecurringAppointment
        {
            get
            {
                return _recurringAppointment;
            }
            set
            {
                _recurringAppointment = value;
            }
        }

        private void AddRecurringAppointment_Load(object sender, EventArgs e)
        {
            string[] text;
            string[] textLocation;

            comboFrequency.DataSource = Enum.GetValues(typeof(RecurringFrequency));
            comboFrequency.SelectedIndex = 0;
            comboStartTime.SelectedIndex = 0;
            comboTimeLength.SelectedIndex = 0;
            if (_recurringAppointment.DisplayText != null)
            {
                comboStartTime.SelectedIndex = Utility.ConvertTimeToRow(_recurringAppointment.Start);
                comboTimeLength.SelectedIndex = Utility.ConvertLengthToRows(_recurringAppointment.Length - 30);
                text = _recurringAppointment.DisplayText.Split(',');
                textBoxEvent.Text = text[0];
                textLocation = text[1].Split('(');
                textBoxLocation.Text = textLocation[0];
                textBoxRepeat.Text = _recurringAppointment.Count.ToString();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int repeatTime;
            string description;
            string savedData;
            bool validationSuccessful = true;

            if (textBoxEvent.TextLength == 0 || textBoxLocation.TextLength == 0 || textBoxRepeat.TextLength == 0)
            {
                validationSuccessful = false;
            }
            if (!int.TryParse(textBoxRepeat.Text, out repeatTime) && repeatTime > 999)
            {
                validationSuccessful = false;
            }
            if (validationSuccessful)
            {
                description = textBoxEvent.Text + ", " + textBoxLocation.Text + " (Recurring " + comboFrequency.Text + ")";
                savedData = "R, " + description + ", " + start + ", " + length + " minutes, " + repeatTime + " times";
                _recurringAppointment.Start = start;
                _recurringAppointment.Length = length;
                _recurringAppointment.DisplayText = description;
                _recurringAppointment.SavedData = savedData;
                _recurringAppointment.Frequency = frequency;
                _recurringAppointment.Count = repeatTime;
                DialogResult = DialogResult.OK;
            }
        }

        public void GetDateFromMainForm(string date)
        {
            labelDateMessage.Text = date;
        }

        private void comboStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            start = Utility.ConvertRowToDateTime(_recurringAppointment.Start, comboStartTime.SelectedIndex);
        }

        private void comboTimeLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            length = Utility.ConvertRowsToLength(comboTimeLength.SelectedIndex + 1);
        }

        private void comboFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            frequency = (RecurringFrequency)comboFrequency.SelectedIndex;
        }
    }
}
