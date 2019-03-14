namespace PresentationLayer
{
    partial class ViewEmployeesForm
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
            this.listEmployees = new System.Windows.Forms.ListView();
            this.oibColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surnameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listEmployees
            // 
            this.listEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oibColumn,
            this.surnameColumn,
            this.nameColumn});
            this.listEmployees.Location = new System.Drawing.Point(12, 12);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(581, 316);
            this.listEmployees.TabIndex = 0;
            this.listEmployees.UseCompatibleStateImageBehavior = false;
            this.listEmployees.View = System.Windows.Forms.View.Details;
            // 
            // oibColumn
            // 
            this.oibColumn.Text = "OIB";
            this.oibColumn.Width = 115;
            // 
            // surnameColumn
            // 
            this.surnameColumn.Text = "Surname";
            this.surnameColumn.Width = 150;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAddEmployee_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ViewEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewEmployeesForm";
            this.Text = "View employees";
            this.Load += new System.EventHandler(this.FormViewEmployees_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listEmployees;
        private System.Windows.Forms.ColumnHeader oibColumn;
        private System.Windows.Forms.ColumnHeader surnameColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}