namespace PresentationLayer
{
    partial class AddAdForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxAdName = new System.Windows.Forms.TextBox();
            this.adSelect = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAddAd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // textBoxAdName
            // 
            this.textBoxAdName.Location = new System.Drawing.Point(160, 32);
            this.textBoxAdName.Name = "textBoxAdName";
            this.textBoxAdName.Size = new System.Drawing.Size(463, 26);
            this.textBoxAdName.TabIndex = 5;
            // 
            // adSelect
            // 
            this.adSelect.FileName = "openAdSelectDialog";
            this.adSelect.Multiselect = true;
            this.adSelect.Title = "Select ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Content";
            // 
            // textBoxAdContent
            // 
            this.textBoxAdContent.Location = new System.Drawing.Point(160, 96);
            this.textBoxAdContent.Name = "textBoxAdContent";
            this.textBoxAdContent.Size = new System.Drawing.Size(463, 26);
            this.textBoxAdContent.TabIndex = 9;
            // 
            // AddAdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 213);
            this.Controls.Add(this.textBoxAdContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAdName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAdForm";
            this.Text = "Add ad";
            this.Load += new System.EventHandler(this.FormViewAds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxAdName;
        private System.Windows.Forms.OpenFileDialog adSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdContent;
    }
}