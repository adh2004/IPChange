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
   
    public partial class Notepad : Form
    {
        
        private string _Profile;
        private string _Nic;
        private string _newAddress;

        public string Profile { get { return _Profile; } set { _Profile = value; } }
        public string Nic { get { return _Nic; } set { _Nic = value; } }
        
        AdapterText Adt = new AdapterText();
        
        public Notepad()
        {
            InitializeComponent();
            Adt.DataChanged += OnDataChanged;
                                
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            Adt.PopulateProfileValues(_Profile);
            rtbProfile.AppendText(Adt.IPAddress +"\n");
            rtbProfile.AppendText(Adt.Subnet + "\n");
            rtbProfile.AppendText(Adt.Gateway + "\n");
        }
        
        private void Notepad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Adt.IPAddress = rtbProfile.Lines[0];
            Adt.Subnet = rtbProfile.Lines[1];
            Adt.Gateway = rtbProfile.Lines[2];
           
            Adt.UpdateProfile(_Profile);
            //passBack();
        }

        private void passBack()
        {
            Form1 frm = new Form1();
            frm.Address = Adt.Split(Adt.IPAddress);
            frm.Sub = Adt.Split(Adt.Subnet);
            frm.Gate = Adt.Split(Adt.Gateway);
            frm.Show();
            
        }
        private void OnDataChanged(object source, EventArgs e)
        {
            
            Form1 frm = new Form1();
            frm.Address = Adt.Split(Adt.IPAddress);
            frm.Sub = Adt.Split(Adt.Subnet);
            frm.Gate = Adt.Split(Adt.Gateway);
            frm.cbNic_value = Nic;
            frm.cbProfile_value = Profile;
            frm.Show();
            
        }   
    }
}
