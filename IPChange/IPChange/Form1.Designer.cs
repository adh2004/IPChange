namespace IPChange
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbNics = new System.Windows.Forms.ComboBox();
            this.tbIP1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gateway = new System.Windows.Forms.TextBox();
            this.Subnet = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbDynamic = new System.Windows.Forms.RadioButton();
            this.rbStatic = new System.Windows.Forms.RadioButton();
            this.tbSubnet1 = new System.Windows.Forms.TextBox();
            this.tbGateway1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cbProfiles = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNics
            // 
            this.cbNics.FormattingEnabled = true;
            this.cbNics.Location = new System.Drawing.Point(12, 26);
            this.cbNics.Name = "cbNics";
            this.cbNics.Size = new System.Drawing.Size(327, 21);
            this.cbNics.TabIndex = 0;
            this.cbNics.SelectedValueChanged += new System.EventHandler(this.cbNics_OnChange);
            // 
            // tbIP1
            // 
            this.tbIP1.Location = new System.Drawing.Point(12, 122);
            this.tbIP1.MaxLength = 15;
            this.tbIP1.Name = "tbIP1";
            this.tbIP1.Size = new System.Drawing.Size(331, 20);
            this.tbIP1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gateway);
            this.groupBox1.Controls.Add(this.Subnet);
            this.groupBox1.Controls.Add(this.IP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 150);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adapter Info";
            // 
            // Gateway
            // 
            this.Gateway.Location = new System.Drawing.Point(101, 101);
            this.Gateway.Name = "Gateway";
            this.Gateway.ReadOnly = true;
            this.Gateway.Size = new System.Drawing.Size(96, 20);
            this.Gateway.TabIndex = 24;
            // 
            // Subnet
            // 
            this.Subnet.Location = new System.Drawing.Point(101, 67);
            this.Subnet.Name = "Subnet";
            this.Subnet.ReadOnly = true;
            this.Subnet.Size = new System.Drawing.Size(96, 20);
            this.Subnet.TabIndex = 23;
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(101, 30);
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Size = new System.Drawing.Size(96, 20);
            this.IP.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Default Gateway:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Subnet Mask:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP Address:";
            // 
            // rbDynamic
            // 
            this.rbDynamic.AutoSize = true;
            this.rbDynamic.Location = new System.Drawing.Point(12, 63);
            this.rbDynamic.Name = "rbDynamic";
            this.rbDynamic.Size = new System.Drawing.Size(120, 17);
            this.rbDynamic.TabIndex = 13;
            this.rbDynamic.TabStop = true;
            this.rbDynamic.Text = "Dynamic IP Address";
            this.rbDynamic.UseVisualStyleBackColor = true;
            this.rbDynamic.CheckedChanged += new System.EventHandler(this.rbDynamic_CheckedChanged);
            // 
            // rbStatic
            // 
            this.rbStatic.AutoSize = true;
            this.rbStatic.Location = new System.Drawing.Point(188, 63);
            this.rbStatic.Name = "rbStatic";
            this.rbStatic.Size = new System.Drawing.Size(106, 17);
            this.rbStatic.TabIndex = 14;
            this.rbStatic.TabStop = true;
            this.rbStatic.Text = "Static IP Address";
            this.rbStatic.UseVisualStyleBackColor = true;
            // 
            // tbSubnet1
            // 
            this.tbSubnet1.Location = new System.Drawing.Point(12, 183);
            this.tbSubnet1.MaxLength = 15;
            this.tbSubnet1.Name = "tbSubnet1";
            this.tbSubnet1.Size = new System.Drawing.Size(331, 20);
            this.tbSubnet1.TabIndex = 5;
            // 
            // tbGateway1
            // 
            this.tbGateway1.Location = new System.Drawing.Point(12, 247);
            this.tbGateway1.MaxLength = 15;
            this.tbGateway1.Name = "tbGateway1";
            this.tbGateway1.Size = new System.Drawing.Size(331, 20);
            this.tbGateway1.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "IP Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Subnet Mask";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "Gateway";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update Adapter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "Network Adapter";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "Save Adapter Profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 281);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Saved Profiles";
            // 
            // cbProfiles
            // 
            this.cbProfiles.FormattingEnabled = true;
            this.cbProfiles.Location = new System.Drawing.Point(15, 300);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(327, 21);
            this.cbProfiles.TabIndex = 31;
            this.cbProfiles.SelectedValueChanged += new System.EventHandler(this.cbProfiles_SelectedValueChanged);
            // 
            // button3
            // 
            this.button3.Image = global::IPChange.Properties.Resources.refresh;
            this.button3.Location = new System.Drawing.Point(345, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 35);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(256, 336);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 13);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open Text Editor";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "IPChange";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 556);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbProfiles);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbGateway1);
            this.Controls.Add(this.tbSubnet1);
            this.Controls.Add(this.rbStatic);
            this.Controls.Add(this.rbDynamic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbIP1);
            this.Controls.Add(this.cbNics);
            this.Name = "Form1";
            this.Text = "Network Configurator";
            
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            //this.Enter += new System.EventHandler(this.Form1_Enter);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNics;
        private System.Windows.Forms.TextBox tbIP1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Gateway;
        private System.Windows.Forms.TextBox Subnet;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDynamic;
        private System.Windows.Forms.RadioButton rbStatic;
        private System.Windows.Forms.TextBox tbSubnet1;
        private System.Windows.Forms.TextBox tbGateway1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbProfiles;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

