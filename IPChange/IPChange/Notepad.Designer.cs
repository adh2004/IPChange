namespace IPChange
{
    partial class Notepad
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
            this.rtbProfile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbProfile
            // 
            this.rtbProfile.Location = new System.Drawing.Point(0, 0);
            this.rtbProfile.Name = "rtbProfile";
            this.rtbProfile.Size = new System.Drawing.Size(359, 261);
            this.rtbProfile.TabIndex = 0;
            this.rtbProfile.Text = "";
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.rtbProfile);
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notepad_FormClosed);
            this.Load += new System.EventHandler(this.Notepad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbProfile;
    }
}