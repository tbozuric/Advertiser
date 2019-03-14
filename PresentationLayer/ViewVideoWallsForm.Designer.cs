namespace PresentationLayer
{
    partial class ViewVideoWallsForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.listVideoWalls = new System.Windows.Forms.ListView();
            this.locationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.widthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heightColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAddVideoWall_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // listVideoWalls
            // 
            this.listVideoWalls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.locationColumn,
            this.widthColumn,
            this.heightColumn,
            this.statusColumn});
            this.listVideoWalls.Location = new System.Drawing.Point(12, 12);
            this.listVideoWalls.Name = "listVideoWalls";
            this.listVideoWalls.Size = new System.Drawing.Size(642, 358);
            this.listVideoWalls.TabIndex = 2;
            this.listVideoWalls.UseCompatibleStateImageBehavior = false;
            this.listVideoWalls.View = System.Windows.Forms.View.Details;
            // 
            // locationColumn
            // 
            this.locationColumn.Text = "Location";
            this.locationColumn.Width = 236;
            // 
            // widthColumn
            // 
            this.widthColumn.Text = "Width";
            this.widthColumn.Width = 114;
            // 
            // heightColumn
            // 
            this.heightColumn.Text = "Height";
            this.heightColumn.Width = 110;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            this.statusColumn.Width = 171;
            // 
            // ViewVideoWallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 456);
            this.Controls.Add(this.listVideoWalls);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewVideoWallsForm";
            this.Text = "View video walls";
            this.Load += new System.EventHandler(this.FormViewVideoWalls_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listVideoWalls;
        private System.Windows.Forms.ColumnHeader locationColumn;
        private System.Windows.Forms.ColumnHeader widthColumn;
        private System.Windows.Forms.ColumnHeader heightColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
    }
}