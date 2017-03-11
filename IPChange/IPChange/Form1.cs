using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;
using System.Web;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

namespace IPChange
{
    
    public partial class Form1 : Form
    {
        private string _Address;
        private string _Subnet;
        private string _Gateway;
        private string _newIPAddress;
        private string _newSubnet;
        private string _newGateway;

        public string Address
        {
            set
            {
                if(value != _newIPAddress)
                {
                    _newIPAddress = value;
                    Form1_OnIPChanged(this,EventArgs.Empty);
                                        
                }
            }
        }
        public string Sub
        {
            set
            {
                if (value != _newSubnet)
                {
                    _newSubnet = value;
                   
                }
            }
        }
        public string Gate
        {
            set
            {
                if(value != _newGateway)
                {
                    _newGateway = value;
                    
                }
            }
        }
        public string cbNic_value { set { cbNics.Text = value; } }
        public string cbProfile_value { set { cbProfiles.Text = value; } }
        NetworkConfiguration nc = new NetworkConfiguration();
        Notepad np = new Notepad();

        public event EventHandler OnIPChanged;
        public Form1()
        {
            InitializeComponent();
                  
        }
        public void Form1_OnIPChanged(object sender, EventArgs e)
        {
            tbIP1.Text = _Address;
            _Address = "";
            tbSubnet1.Text = _Subnet;
            _Subnet = "";
            tbGateway1.Text = _Gateway;
            _Gateway = "";

        }
        private void OnAddressChanged(object sender, EventArgs e)
        {
            tbIP1.Text = _Address;
            _Address = "";
        }
        private void OnSubnetChanged(EventArgs e)
        {
            tbSubnet1.Text = _Subnet;
            _Subnet = "";
        }
        private void OnGatewayChanged(EventArgs e)
        {
            tbGateway1.Text = _Gateway;
            _Gateway = "";
        }
       public void populateCb()
        {
            foreach(string s in nc.AdapterNames)
            {
                cbNics.Items.Add(s);
            }
            cbNics.Text = nc.AdapterNames[0];
        }

        private void populateAdapterInfo()
        {
            nc.GetAdapterInfo(cbNics.Text);

            if (nc.IPAddress[0] != null)
            {
                IP.Text = nc.IPAddress[0];
            }
            else
            {
                IP.Text = "";
            }
            
            if (nc.SubnetMask != null)
            {
                Subnet.Text = nc.SubnetMask[0];
            }
            else
            {
                Subnet.Text = "";
            }
            if (nc.DefaultGateway != null)
            {
                Gateway.Text = nc.DefaultGateway[0];
            }
            else
            {
                Gateway.Text = "";
            }
                        
        }

        private void DefineValues(out string IPAddress, out string Subnet, out string Gateway)
        {
            IPAddress = tbIP1.Text;
            Subnet = tbSubnet1.Text;
            Gateway = tbGateway1.Text;
        }
        private void changeAdapterInfo()
        {
            bool StaticIP;
            string address;
            string subnet;
            string gateway;
            StaticIP = (rbStatic.Checked) ? true : false;
            DefineValues(out address, out subnet, out gateway);
            nc.NewIPAddress = address;
            nc.NewSubnetMask = subnet;
            nc.NewDefaultGateway = gateway;
            nc.SetAdapterInfo(cbNics.Text, StaticIP);
            
        }
        public void VerifyValues()
        {
            
                tbIP1.Text = _newIPAddress;
                tbSubnet1.Text = _newSubnet;
                tbGateway1.Text = _newGateway;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            nc.GetAdapters();
            populateCb();
            populateAdapterInfo();
            populateProfiles();
            TextEditorEnable();
                        
        }

        private void cbNics_OnChange(object sender, EventArgs e)
        {
            populateAdapterInfo();
            populateProfiles();
            clearProfileData();

        }

        private void clearProfileData()
        {
            cbProfiles.Text = "";

            foreach(TextBox t in this.Controls.OfType<TextBox>())
            {
                if (t.Name.Contains("tbIP"))
                {
                    ((TextBox)t).Text = "";
                }
                if (t.Name.Contains("tbSubnet"))
                {
                    ((TextBox)t).Text = "";
                }
                if (t.Name.Contains("tbGateway"))
                {
                    ((TextBox)t).Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeAdapterInfo();
            Thread.Sleep(1000);
            populateAdapterInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string AdapterName = cbNics.Text;
            string IPAddress, Subnet, Gateway;
            bool addressCheck, subnetCheck, gatewayCheck;
            Dictionary<string,bool> checkValues = new Dictionary<string, bool>();
            DefineValues(out IPAddress, out Subnet, out Gateway);

            addressCheck = ValidateValues(IPAddress, "address");
            checkValues.Add("address",addressCheck);
            subnetCheck = ValidateValues(Subnet, "subnet");
            checkValues.Add("subnet",subnetCheck);
            gatewayCheck = ValidateValues(Gateway, "gateway");
            checkValues.Add("gateway",gatewayCheck);

            if (addressCheck == true && subnetCheck == true && gatewayCheck == true)
            {
                Form1 frm1 = new Form1();
                SaveForm frm2 = new SaveForm();
                frm2.AdapterName = AdapterName;
                frm2.IPAddress = IPAddress;
                frm2.Subnet = Subnet;
                frm2.Gateway = Gateway;  
                this.Hide();
                frm2.Show();
            }
            else
            {
                foreach (KeyValuePair<string,bool> pair in checkValues)
                {
                    switch (pair.Key)
                    {
                        case "address":
                            if (pair.Value == false) { MessageBox.Show("Incorrect " + pair.Key + " format."); }
                            break;
                        case "subnet":
                            if (pair.Value == false) { MessageBox.Show("Incorrect " + pair.Key + " format."); }                                                    
                            break;
                        case "gateway":
                            if (pair.Value == false) { MessageBox.Show("Incorrect " + pair.Key + " format."); }
                            break;
                    }
                }                
            }
        }
        private bool ValidateValues(string pattern, string type)
        {
            bool valueCheck = false;
            string matchPattern = @"^([0-9]{1,3})\.([0-9]{1,3})\.([0-9]{1,3})\.([0-9]{1,3})$";
            Regex r = new Regex(matchPattern);
            Match match = r.Match(pattern);
            switch (type)
            {
                case "address":
                    valueCheck = match.Success == true ? true : false;
                    break;
                case "subnet":
                    valueCheck = match.Success == true ? true : false;
                    break;
                case "gateway":
                    if (match.Success == true || pattern == "")
                    {
                        valueCheck = true;
                    }
                    else
                    {
                        valueCheck = false;
                    }
                    break;
            }
            return valueCheck;
        }
        private void populateProfiles()
        {
            cbProfiles.Items.Clear();
            nc.ProfileList.Clear();
            nc.PopulateProfileList(cbNics.Text);
            
            foreach(string s in nc.ProfileList)
            {
                cbProfiles.Items.Add(s);
            }
            
        }
        private void populateComboBoxes()
        {
            Form1 frm = new Form1();

            foreach (TextBox c in this.Controls.OfType<TextBox>())
            {
                if (c.Name.Contains("tbIP"))
                {
                    ((TextBox)c).Text = nc.FileIP;
                }

                if (c.Name.Contains("tbSubnet"))
                {
                    ((TextBox)c).Text = nc.FileSubnet;
                }
                if (c.Name.Contains("tbGateway"))
                {
                    ((TextBox)c).Text = nc.FileGateway;
                }
            }
        }

        private void cbProfiles_SelectedValueChanged(object sender, EventArgs e)
        {
            nc.PopulateProfileValues(cbProfiles.Text);
            populateComboBoxes();
            rbStatic.Checked = true;
            TextEditorEnable();
        }

        private void rbDynamic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDynamic.Checked == true)
            {
                clearProfileData();
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Notepad frmNote = new Notepad();
            frmNote.Profile = cbProfiles.Text;
            frmNote.Nic = cbNics.Text;
            frmNote.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //nc.GetAdapters();
            //populateCb();
            nc.GetAdapterProfiles();
            populateAdapterInfo();
            populateProfiles();
            clearProfileData();
            TextEditorEnable();
        }

        private void TextEditorEnable()
        {
            if ((cbProfiles.Text != "") && (tbIP1.Text != ""))
            {
                linkLabel1.Enabled = true;
            }
            else
            {
                linkLabel1.Enabled = false;
            }
        }

        //private void Form1_Enter(object sender, EventArgs e)
        //{
        //    nc.GetAdapters();
        //    populateCb();
        //    populateAdapterInfo();
        //    populateProfiles();
        //    TextEditorEnable();

        //}

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
