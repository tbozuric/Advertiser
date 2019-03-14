namespace PresentationLayer
{
    partial class AddScheduleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxScheduleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeScheduleStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeScheduleEnd = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Schedule start time";
            // 
            // tbxScheduleName
            // 
            this.tbxScheduleName.Location = new System.Drawing.Point(208, 13);
            this.tbxScheduleName.Name = "tbxScheduleName";
            this.tbxScheduleName.Size = new System.Drawing.Size(450, 26);
            this.tbxScheduleName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Schedule stop time";
            // 
            // dateTimeScheduleStart
            // 
            this.dateTimeScheduleStart.Location = new System.Drawing.Point(208, 55);
            this.dateTimeScheduleStart.Name = "dateTimeScheduleStart";
            this.dateTimeScheduleStart.Size = new System.Drawing.Size(450, 26);
            this.dateTimeScheduleStart.TabIndex = 4;
            // 
            // dateTimeScheduleEnd
            // 
            this.dateTimeScheduleEnd.Location = new System.Drawing.Point(208, 114);
            this.dateTimeScheduleEnd.Name = "dateTimeScheduleEnd";
            this.dateTimeScheduleEnd.Size = new System.Drawing.Size(450, 26);
            this.dateTimeScheduleEnd.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAddSchedule_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 279);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimeScheduleEnd);
            this.Controls.Add(this.dateTimeScheduleStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxScheduleName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddScheduleForm";
            this.Text = "Add schedule";
            this.Load += new System.EventHandler(this.FormAddSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxScheduleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeScheduleStart;
        private System.Windows.Forms.DateTimePicker dateTimeScheduleEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}