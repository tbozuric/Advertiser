namespace PresentationLayer
{
    partial class AddServiceForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimeServiceStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeServiceEnd = new System.Windows.Forms.DateTimePicker();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxVideoWall = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxFailureType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add new service record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAddService_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // dateTimeServiceStart
            // 
            this.dateTimeServiceStart.Location = new System.Drawing.Point(125, 17);
            this.dateTimeServiceStart.Name = "dateTimeServiceStart";
            this.dateTimeServiceStart.Size = new System.Drawing.Size(376, 26);
            this.dateTimeServiceStart.TabIndex = 3;
            // 
            // dateTimeServiceEnd
            // 
            this.dateTimeServiceEnd.Location = new System.Drawing.Point(125, 65);
            this.dateTimeServiceEnd.Name = "dateTimeServiceEnd";
            this.dateTimeServiceEnd.Size = new System.Drawing.Size(376, 26);
            this.dateTimeServiceEnd.TabIndex = 4;
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(125, 175);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(376, 28);
            this.cbxEmployee.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "End time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Video wall";
            // 
            // cbxVideoWall
            // 
            this.cbxVideoWall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVideoWall.FormattingEnabled = true;
            this.cbxVideoWall.Location = new System.Drawing.Point(125, 120);
            this.cbxVideoWall.Name = "cbxVideoWall";
            this.cbxVideoWall.Size = new System.Drawing.Size(376, 28);
            this.cbxVideoWall.TabIndex = 10;
            this.cbxVideoWall.SelectedIndexChanged += new System.EventHandler(this.CbxVideoWall_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Failure type";
            // 
            // cbxFailureType
            // 
            this.cbxFailureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFailureType.FormattingEnabled = true;
            this.cbxFailureType.Location = new System.Drawing.Point(129, 234);
            this.cbxFailureType.Name = "cbxFailureType";
            this.cbxFailureType.Size = new System.Drawing.Size(372, 28);
            this.cbxFailureType.TabIndex = 12;
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 451);
            this.Controls.Add(this.cbxFailureType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxVideoWall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEmployee);
            this.Controls.Add(this.dateTimeServiceEnd);
            this.Controls.Add(this.dateTimeServiceStart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServiceForm";
            this.Text = "Add service";
            this.Load += new System.EventHandler(this.FormAddService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimeServiceStart;
        private System.Windows.Forms.DateTimePicker dateTimeServiceEnd;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxVideoWall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxFailureType;
    }
}