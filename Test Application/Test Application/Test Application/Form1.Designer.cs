namespace Test_Application
{
    partial class frmMain
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
            this.comboBoxWebsite = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxWebsite
            // 
            this.comboBoxWebsite.FormattingEnabled = true;
            this.comboBoxWebsite.Location = new System.Drawing.Point(49, 25);
            this.comboBoxWebsite.Name = "comboBoxWebsite";
            this.comboBoxWebsite.Size = new System.Drawing.Size(152, 21);
            this.comboBoxWebsite.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.comboBoxWebsite);
            this.Name = "frmMain";
            this.Text = "GIT Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWebsite;
    }
}

