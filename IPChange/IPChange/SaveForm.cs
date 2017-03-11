using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPChange
{
    public partial class SaveForm : Form
    {
        private string _AdapterName;
        private string _IPAddress;
        private string _Subnet;
        private string _Gateway;
        private string _FileName;

        public string AdapterName {  set { _AdapterName = value; } }
        public string IPAddress {  set { _IPAddress = value; } }
        public string Subnet {  set { _Subnet = value; } }
        public string Gateway {  set { _Gateway = value; } }
        public string FileName { set { _FileName = value; } }

        SaveProfile sp = new SaveProfile();
        public SaveForm()
        {
            InitializeComponent();
            
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {
            sp.AdapterName = _AdapterName;
            sp.IPAddress = _IPAddress;
            sp.Subnet = _Subnet;
            sp.Gateway = _Gateway;
            sp.FileName = _FileName;
            PopulateAdapterInfo();
        }

        private void PopulateAdapterInfo()
        {
            tbAdapterName.Text = sp.AdapterName;
            tbIP.Text = sp.IPAddress;
            tbSubnet.Text = sp.Subnet;
            tbGateway.Text = sp.Gateway;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
           
            sp.CheckFileExists(tbProfileName.Text);
            this.Close();
            frm1.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Close();
            frm1.Show();
        }
    }
}
