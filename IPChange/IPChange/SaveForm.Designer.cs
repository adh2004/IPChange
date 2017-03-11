namespace IPChange
{
    partial class SaveForm
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
            this.tbProfileName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdapterName = new System.Windows.Forms.TextBox();
            this.tbGateway = new System.Windows.Forms.TextBox();
            this.tbSubnet = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProfileName
            // 
            this.tbProfileName.Location = new System.Drawing.Point(12, 39);
            this.tbProfileName.MaxLength = 50;
            this.tbProfileName.Name = "tbProfileName";
            this.tbProfileName.Size = new System.Drawing.Size(259, 20);
            this.tbProfileName.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "Enter Name for Profile";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAdapterName);
            this.groupBox1.Controls.Add(this.tbGateway);
            this.groupBox1.Controls.Add(this.tbSubnet);
            this.groupBox1.Controls.Add(this.tbIP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 180);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adapter Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Adapter Name:";
            // 
            // tbAdapterName
            // 
            this.tbAdapterName.Location = new System.Drawing.Point(101, 33);
            this.tbAdapterName.Name = "tbAdapterName";
            this.tbAdapterName.ReadOnly = true;
            this.tbAdapterName.Size = new System.Drawing.Size(153, 20);
            this.tbAdapterName.TabIndex = 25;
            // 
            // tbGateway
            // 
            this.tbGateway.Location = new System.Drawing.Point(101, 143);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.ReadOnly = true;
            this.tbGateway.Size = new System.Drawing.Size(96, 20);
            this.tbGateway.TabIndex = 24;
            // 
            // tbSubnet
            // 
            this.tbSubnet.Location = new System.Drawing.Point(101, 109);
            this.tbSubnet.Name = "tbSubnet";
            this.tbSubnet.ReadOnly = true;
            this.tbSubnet.Size = new System.Drawing.Size(96, 20);
            this.tbSubnet.TabIndex = 23;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(101, 72);
            this.tbIP.Name = "tbIP";
            this.tbIP.ReadOnly = true;
            this.tbIP.Size = new System.Drawing.Size(96, 20);
            this.tbIP.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Default Gateway:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Subnet Mask:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP Address:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(105, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 305);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbProfileName);
            this.Name = "SaveForm";
            this.Text = "SaveForm";
            this.Load += new System.EventHandler(this.SaveForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProfileName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdapterName;
        private System.Windows.Forms.TextBox tbGateway;
        private System.Windows.Forms.TextBox tbSubnet;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}