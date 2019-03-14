﻿namespace PresentationLayer
{
    partial class AddAdToScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdToScheduleForm));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxAd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeStartBroadcast = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEndBroadcast = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // cbxAd
            // 
            this.cbxAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAd.FormattingEnabled = true;
            this.cbxAd.Location = new System.Drawing.Point(77, 36);
            this.cbxAd.Name = "cbxAd";
            this.cbxAd.Size = new System.Drawing.Size(498, 28);
            this.cbxAd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start broadcasting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "End of broadcast";
            // 
            // dateTimeStartBroadcast
            // 
            this.dateTimeStartBroadcast.Location = new System.Drawing.Point(165, 91);
            this.dateTimeStartBroadcast.Name = "dateTimeStartBroadcast";
            this.dateTimeStartBroadcast.Size = new System.Drawing.Size(410, 26);
            this.dateTimeStartBroadcast.TabIndex = 10;
            // 
            // dateTimeEndBroadcast
            // 
            this.dateTimeEndBroadcast.Location = new System.Drawing.Point(162, 143);
            this.dateTimeEndBroadcast.Name = "dateTimeEndBroadcast";
            this.dateTimeEndBroadcast.Size = new System.Drawing.Size(413, 26);
            this.dateTimeEndBroadcast.TabIndex = 11;
            // 
            // AddAdToScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 333);
            this.Controls.Add(this.dateTimeEndBroadcast);
            this.Controls.Add(this.dateTimeStartBroadcast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxAd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAdToScheduleForm";
            this.Text = "Add ad to video wall";
            this.Load += new System.EventHandler(this.FormAddAdToSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeStartBroadcast;
        private System.Windows.Forms.DateTimePicker dateTimeEndBroadcast;
    }
}