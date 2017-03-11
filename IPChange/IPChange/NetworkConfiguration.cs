using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net.NetworkInformation;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
namespace IPChange
{
    //Class provides methods to retrieve saved network profiles, retrieve current network adapter info, 
    class NetworkConfiguration
    {
        private NetworkInterface[] _NetworkAdapters = NetworkInterface.GetAllNetworkInterfaces();
        private List<string> _AdapterNames = new List<string>();
        private string [] _IPAddress;
        private string [] _DefaultGateway;
        private string [] _SubnetMask;
        private string _newIPAddress;
        private string _newDefaultGateway;
        private string _newSubnetMask;
        private string _fileIP;
        private string _fileSubnet;
        private string _fileGateway;
        private string _FilePath = ConfigurationManager.AppSettings["Path"] + "\\";
        private FolderBrowserDialog _fbd = new FolderBrowserDialog();
        private List<string> _profileList = new List<string>();
        private Dictionary<string, string> _adapterProfiles = new Dictionary<string, string>();

        public NetworkConfiguration() {
            if (_FilePath !=  "\\")
            {
                GetAdapterProfiles();
            }
               
        }

        public string [] IPAddress { get { return _IPAddress; } }
        public List<string> AdapterNames { get { return _AdapterNames; } }
        public string [] DefaultGateway { get { return _DefaultGateway; } }
        public string [] SubnetMask { get { return _SubnetMask; } }
        public string NewIPAddress { get { return _newIPAddress; } set { _newIPAddress = value; } }
        public string NewSubnetMask { get { return _newSubnetMask; } set { _newSubnetMask = value; } }
        public string NewDefaultGateway { get { return _newDefaultGateway; } set { _newDefaultGateway = value; } }
        public NetworkInterface[] NetworkAdapters { get { return _NetworkAdapters; } }
        public string FileIP { get { return _fileIP; } }
        public string FileSubnet { get { return _fileSubnet; } }
        public string FileGateway { get { return _fileGateway; } }
       
        public List<string> ProfileList { get { return _profileList; } }
        public Dictionary<string, string> AdapterProfiles { get { return _adapterProfiles; } }
        
        //Defines management class and management object collection
        private static void DefineObjects(out ManagementClass mc,out ManagementObjectCollection moc)
        {
            mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            moc = mc.GetInstances();
        }

        //Populates Combobox with all available network adapters
        public void GetAdapters()
        {
            ManagementClass mc;
            ManagementObjectCollection moc;
            DefineObjects(out mc, out moc);

            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"] == true)
                {
                    _AdapterNames.Add(Convert.ToString(mo["Description"]));
                }
            }
        }

        //Gets the current IP Address, Subnet & Gateway for the selected network adapter
        public void GetAdapterInfo(string adapterName)
        {

            ManagementClass mc;
            ManagementObjectCollection moc;
            DefineObjects(out mc, out moc);

            foreach (ManagementObject mo in moc)
            {
                if (((bool)mo["IPEnabled"] == true) && (string)mo["Description"] == adapterName)
                {
                    _IPAddress = (string [])mo["IPAddress"];
                    _DefaultGateway = (string [])mo["DefaultIPGateway"];
                    _SubnetMask = (string [])mo["IPSubnet"];
                    
                }
            }
        }

        //Update the IP Address, Subnet and Gateway from the information populated in text boxes for each heading
        public void SetAdapterInfo(string adapterName, bool StaticIP)
        {
            ManagementClass mc;
            ManagementObjectCollection moc;
            DefineObjects(out mc, out moc);

            foreach (ManagementObject mo in moc)
            {
                if (((bool)mo["IPEnabled"] == true) && (string)mo["Description"] == adapterName)
                {
                    if (StaticIP)
                    {
                        try
                        {
                            var NewAdapterInfo = mo.GetMethodParameters("EnableStatic");
                            
                            var returnValue = mo.InvokeMethod("EnableStatic", new object[] { new string[] { NewIPAddress },  new string[] { NewSubnetMask } });
                            

                            var NewAdapterGateway = mo.GetMethodParameters("SetGateways");
                            NewAdapterGateway["DefaultIPGateway"] = new string[] { NewDefaultGateway };
                            NewAdapterGateway["GatewayCostMetric"] = new int[] { 1 };
                            mo.InvokeMethod("SetGateways", NewAdapterGateway, null);
                            
                        }
                        
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.ToString());
                        }
                    
                    }
                    else
                    {
                           
                        var returnValue = mo.InvokeMethod("EnableDHCP", null, null);
                        
                    }
                    
                }
            }

        }

        //Load saved adapter profiles from the C:\NetworkProfiles directory and populate dictionary with profile name as key and adapter name as value
        public void GetAdapterProfiles()
        {
            string[] fileNames = Directory.GetFiles(_FilePath);
            string elementName = "AdapterName";
            string fileName;
            XmlDocument doc = new XmlDocument();

            if (!Directory.Exists(_FilePath))
            {
                Directory.CreateDirectory(_FilePath);
            }

            foreach (string s in fileNames)
            {
                fileName = Path.GetFileNameWithoutExtension(s);
                try
                {
                    doc.Load(s);
                    foreach (XmlElement e in doc.DocumentElement)
                    {
                        if (e.Name == elementName)
                        {
                            if (_adapterProfiles.ContainsKey(fileName) == false)
                            {
                                _adapterProfiles.Add(fileName, e.InnerText);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        //Search dictionary for pair all entries with supplied adapterName 
       public void PopulateProfileList(string adapterName)
        {
            if (_FilePath != "\\")
            {
                if (_adapterProfiles.Count < 1)
                {
                    GetAdapterProfiles();
                }
                _profileList.Clear();
                foreach (KeyValuePair<string, string> pair in _adapterProfiles)
                {
                    if (pair.Value == adapterName)
                    {
                        _profileList.Add(pair.Key);
                    }
                }
            }
            
        }

        //Function used to create xml node name for each profile based off of file name.  Xml does not accept spaces in node name.  Function takes file name and removes spaces
        public string SplitString(string sVal)
        {
            char[] stringChar = { ' ' };
            string[] newFilename;
            string newFile = "";
            newFilename = sVal.Split(stringChar);
            foreach(string s in newFilename)
            {
                newFile = newFile + s;
            }
            return newFile;
        }
        public string[] Split(string Val)
        {
            char[] stringChar = { '.' };
            string[] newVal;

            newVal = Val.Split(stringChar);
            return newVal;

        }

        //Gets the values of Ip Address, Subnet & Gateway from selected profile and stores in arrays
        public void PopulateProfileValues(string Profile)
        {
            XmlDocument doc = new XmlDocument();
          
            doc.Load(_FilePath + Profile + ".xml");

            foreach(XmlElement e in doc.DocumentElement)
            {
                switch (e.Name)
                {                    
                    case "IPAddress":
                        _fileIP = e.InnerText;
                        break;
                    case "Subnet":
                        _fileSubnet = e.InnerText;
                        break;
                    case "Gateway":
                        _fileGateway = e.InnerText;
                        break;
                }
            }


        }

        //Associate profile values with appropriate text boxes
        //public string GetProfileValues(string boxName, int boxNum)
        //{
        //    string retStr ="";

        //    switch (boxName)
        //    {
        //        case "tbIP":
        //            retStr = _fileIP[boxNum - 1];
        //            return retStr;
        //        case "tbSubnet":
        //            retStr = _fileSubnet[boxNum - 1];
        //            return retStr;
                   
        //        case "tbGateway":
        //            retStr = _fileGateway[boxNum - 1];
        //            return retStr;
        //        default:
        //            return retStr;
                   
        //    }
        //}
        public void CheckProfileSavePath()
        {
            DialogResult result;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (_FilePath == "")
            {
                result = _fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _FilePath = _fbd.SelectedPath;
                    config.AppSettings.Settings["Path"].Value = _FilePath;
                    config.Save(ConfigurationSaveMode.Modified);
                }

            }
        }
        


    }
        
       
    }

    

