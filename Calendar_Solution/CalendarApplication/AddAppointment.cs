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
    public partial class AddAppointment : Form
    {
        SingleAppointment _singleAppointment = null;

        DateTime start;
        int length;

        public AddAppointment()
        {
            InitializeComponent();
        }

        public SingleAppointment SingleAppointment
        {
            get
            {
                return _singleAppointment;
            }
            set
            {
                _singleAppointment = value;
            }
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            string[] text;

            comboStartTime.SelectedIndex = 0;
            comboTimeLength.SelectedIndex = 0;
            if (_singleAppointment.DisplayText!= null)
            {
                comboStartTime.SelectedIndex = Utility.ConvertTimeToRow(_singleAppointment.Start);
                comboTimeLength.SelectedIndex = Utility.ConvertLengthToRows(_singleAppointment.Length - 30);
                text = _singleAppointment.DisplayText.Split(',');
                textBoxEvent.Text = text[0];
                textBoxLocation.Text = text[1];
            }
        }

        private void comboStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            start = Utility.ConvertRowToDateTime(_singleAppointment.Start, comboStartTime.SelectedIndex);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void comboTimeLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            length = Utility.ConvertRowsToLength(comboTimeLength.SelectedIndex + 1);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string description;
            string savedData;
            bool validationSuccesful = true;

            if (textBoxEvent.TextLength == 0 || textBoxLocation.TextLength == 0)
            {
                validationSuccesful = false;
            }
            if (validationSuccesful)
            {
                description = textBoxEvent.Text + ", " + textBoxLocation.Text;
                savedData = "A, " + description + ", " + start + ", " + length + " minutes";
                _singleAppointment.Start = start;
                _singleAppointment.Length = length;
                _singleAppointment.DisplayText = description;
                _singleAppointment.SavedData = savedData;
                DialogResult = DialogResult.OK;
            }
        }

        public void GetDateFromMainForm(string date)
        {
            labelDateMessage.Text = date;
        }
    }
}
