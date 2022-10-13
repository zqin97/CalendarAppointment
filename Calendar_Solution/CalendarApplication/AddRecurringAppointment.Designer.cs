namespace Calendar
{
    partial class AddRecurringAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labalSubject = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDateMessage = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.comboStartTime = new System.Windows.Forms.ComboBox();
            this.labelLengthTime = new System.Windows.Forms.Label();
            this.comboTimeLength = new System.Windows.Forms.ComboBox();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.comboFrequency = new System.Windows.Forms.ComboBox();
            this.labelRepeatTime = new System.Windows.Forms.Label();
            this.textBoxRepeat = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labalSubject
            // 
            this.labalSubject.AutoSize = true;
            this.labalSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labalSubject.Location = new System.Drawing.Point(32, 31);
            this.labalSubject.Name = "labalSubject";
            this.labalSubject.Size = new System.Drawing.Size(61, 18);
            this.labalSubject.TabIndex = 0;
            this.labalSubject.Text = "Subject:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(32, 78);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(69, 18);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Location:";
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Location = new System.Drawing.Point(118, 31);
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(740, 22);
            this.textBoxEvent.TabIndex = 2;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(118, 78);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(740, 22);
            this.textBoxLocation.TabIndex = 3;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(32, 136);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(43, 18);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date:";
            // 
            // labelDateMessage
            // 
            this.labelDateMessage.AutoSize = true;
            this.labelDateMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateMessage.Location = new System.Drawing.Point(131, 136);
            this.labelDateMessage.Name = "labelDateMessage";
            this.labelDateMessage.Size = new System.Drawing.Size(0, 18);
            this.labelDateMessage.TabIndex = 5;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.Location = new System.Drawing.Point(434, 139);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(76, 18);
            this.labelStartTime.TabIndex = 6;
            this.labelStartTime.Text = "StartTime:";
            // 
            // comboStartTime
            // 
            this.comboStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStartTime.FormattingEnabled = true;
            this.comboStartTime.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.comboStartTime.Location = new System.Drawing.Point(526, 136);
            this.comboStartTime.Name = "comboStartTime";
            this.comboStartTime.Size = new System.Drawing.Size(121, 26);
            this.comboStartTime.TabIndex = 7;
            this.comboStartTime.SelectedIndexChanged += new System.EventHandler(this.comboStartTime_SelectedIndexChanged);
            // 
            // labelLengthTime
            // 
            this.labelLengthTime.AutoSize = true;
            this.labelLengthTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLengthTime.Location = new System.Drawing.Point(657, 139);
            this.labelLengthTime.Name = "labelLengthTime";
            this.labelLengthTime.Size = new System.Drawing.Size(56, 18);
            this.labelLengthTime.TabIndex = 8;
            this.labelLengthTime.Text = "Length:";
            // 
            // comboTimeLength
            // 
            this.comboTimeLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTimeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTimeLength.FormattingEnabled = true;
            this.comboTimeLength.Items.AddRange(new object[] {
            "30 minutes",
            "60 minutes",
            "90 minutes",
            "120 minutes",
            "150 minutes",
            "180 minutes",
            "210 minutes",
            "240 minutes",
            "270 minutes",
            "300 minutes",
            "330 minutes",
            "360 minutes",
            "390 minutes",
            "420 minutes",
            "450 minutes",
            "480 minutes",
            "510 minutes",
            "540 minutes",
            "570 minutes",
            "600 minutes",
            "630 minutes",
            "660 minutes",
            "690 minutes",
            "720 minutes",
            "750 minutes",
            "780 minutes",
            "810 minutes",
            "840 minutes",
            "870 minutes",
            "900 minutes",
            "930 minutes",
            "960 minutes",
            "990 minutes",
            "1020 minutes",
            "1050 minutes",
            "1080 minutes",
            "1110 minutes",
            "1140 minutes",
            "1170 minutes",
            "1200 minutes",
            "1230 minutes",
            "1260 minutes",
            "1290 minutes",
            "1320 minutes",
            "1350 minutes",
            "1380 minutes",
            "1410 minutes",
            "1440 minutes"});
            this.comboTimeLength.Location = new System.Drawing.Point(728, 136);
            this.comboTimeLength.Name = "comboTimeLength";
            this.comboTimeLength.Size = new System.Drawing.Size(121, 26);
            this.comboTimeLength.TabIndex = 9;
            this.comboTimeLength.SelectedIndexChanged += new System.EventHandler(this.comboTimeLength_SelectedIndexChanged);
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrequency.Location = new System.Drawing.Point(32, 190);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(81, 18);
            this.labelFrequency.TabIndex = 10;
            this.labelFrequency.Text = "Frequency:";
            // 
            // comboFrequency
            // 
            this.comboFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFrequency.FormattingEnabled = true;
            this.comboFrequency.Location = new System.Drawing.Point(134, 187);
            this.comboFrequency.Name = "comboFrequency";
            this.comboFrequency.Size = new System.Drawing.Size(121, 26);
            this.comboFrequency.TabIndex = 11;
            this.comboFrequency.SelectedIndexChanged += new System.EventHandler(this.comboFrequency_SelectedIndexChanged);
            // 
            // labelRepeatTime
            // 
            this.labelRepeatTime.AutoSize = true;
            this.labelRepeatTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeatTime.Location = new System.Drawing.Point(434, 187);
            this.labelRepeatTime.Name = "labelRepeatTime";
            this.labelRepeatTime.Size = new System.Drawing.Size(123, 18);
            this.labelRepeatTime.TabIndex = 12;
            this.labelRepeatTime.Text = "How many times:";
            // 
            // textBoxRepeat
            // 
            this.textBoxRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepeat.Location = new System.Drawing.Point(580, 187);
            this.textBoxRepeat.Name = "textBoxRepeat";
            this.textBoxRepeat.Size = new System.Drawing.Size(67, 24);
            this.textBoxRepeat.TabIndex = 13;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(789, 363);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 30);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(678, 363);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 30);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddRecurringAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 405);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxRepeat);
            this.Controls.Add(this.labelRepeatTime);
            this.Controls.Add(this.comboFrequency);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.comboTimeLength);
            this.Controls.Add(this.labelLengthTime);
            this.Controls.Add(this.comboStartTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelDateMessage);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxEvent);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labalSubject);
            this.Name = "AddRecurringAppointment";
            this.Text = "RecurringAppointment";
            this.Load += new System.EventHandler(this.AddRecurringAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labalSubject;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDateMessage;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.ComboBox comboStartTime;
        private System.Windows.Forms.Label labelLengthTime;
        private System.Windows.Forms.ComboBox comboTimeLength;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.ComboBox comboFrequency;
        private System.Windows.Forms.Label labelRepeatTime;
        private System.Windows.Forms.TextBox textBoxRepeat;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}