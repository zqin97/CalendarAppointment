namespace Calendar
{
    partial class AddAppointment
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
            this.subjectLabel = new System.Windows.Forms.Label();
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.labelDateMessage = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.comboStartTime = new System.Windows.Forms.ComboBox();
            this.labelTimeLength = new System.Windows.Forms.Label();
            this.comboTimeLength = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(32, 26);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(61, 18);
            this.subjectLabel.TabIndex = 0;
            this.subjectLabel.Text = "Subject:";
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEvent.Location = new System.Drawing.Point(120, 26);
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(660, 24);
            this.textBoxEvent.TabIndex = 1;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(32, 80);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(69, 18);
            this.locationLabel.TabIndex = 2;
            this.locationLabel.Text = "Location:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.Location = new System.Drawing.Point(120, 80);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(660, 24);
            this.textBoxLocation.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(35, 130);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(43, 18);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date:";
            // 
            // labelDateMessage
            // 
            this.labelDateMessage.AutoSize = true;
            this.labelDateMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateMessage.Location = new System.Drawing.Point(130, 130);
            this.labelDateMessage.Name = "labelDateMessage";
            this.labelDateMessage.Size = new System.Drawing.Size(0, 18);
            this.labelDateMessage.TabIndex = 5;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.Location = new System.Drawing.Point(358, 130);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(80, 18);
            this.labelStartTime.TabIndex = 6;
            this.labelStartTime.Text = "Start Time:";
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
            this.comboStartTime.Location = new System.Drawing.Point(444, 130);
            this.comboStartTime.Name = "comboStartTime";
            this.comboStartTime.Size = new System.Drawing.Size(121, 26);
            this.comboStartTime.TabIndex = 7;
            this.comboStartTime.SelectedIndexChanged += new System.EventHandler(this.comboStartTime_SelectedIndexChanged);
            // 
            // labelTimeLength
            // 
            this.labelTimeLength.AutoSize = true;
            this.labelTimeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeLength.Location = new System.Drawing.Point(591, 130);
            this.labelTimeLength.Name = "labelTimeLength";
            this.labelTimeLength.Size = new System.Drawing.Size(56, 18);
            this.labelTimeLength.TabIndex = 8;
            this.labelTimeLength.Text = "Length:";
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
            this.comboTimeLength.Location = new System.Drawing.Point(653, 129);
            this.comboTimeLength.Name = "comboTimeLength";
            this.comboTimeLength.Size = new System.Drawing.Size(121, 26);
            this.comboTimeLength.TabIndex = 9;
            this.comboTimeLength.SelectedIndexChanged += new System.EventHandler(this.comboTimeLength_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(734, 333);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 30);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(608, 332);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(97, 31);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 375);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboTimeLength);
            this.Controls.Add(this.labelTimeLength);
            this.Controls.Add(this.comboStartTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelDateMessage);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.textBoxEvent);
            this.Controls.Add(this.subjectLabel);
            this.Name = "AddAppointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label labelDateMessage;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.ComboBox comboStartTime;
        private System.Windows.Forms.Label labelTimeLength;
        private System.Windows.Forms.ComboBox comboTimeLength;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}