using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace IPChange
{
    class SaveProfile
    {
        private string _AdapterName;
        private string _IPAddress;
        private string _Subnet;
        private string _Gateway;
        private FolderBrowserDialog _fbd = new FolderBrowserDialog();
        private string _FilePath = ConfigurationManager.AppSettings["Path"] + "\\";  //"C:\\NetworkProfiles\\";
        private string _FileName;

        public string AdapterName { get { return _AdapterName; } set { _AdapterName = value; } }
        public string IPAddress { get { return _IPAddress; } set { _IPAddress = value; } }
        public string Subnet { get { return _Subnet; } set { _Subnet = value; } }
        public string Gateway { get { return _Gateway; } set { _Gateway = value; } }
        public string FileName { get { return _FileName; } set { _FileName = value; } }
        public SaveProfile() { }
        public SaveProfile(string AdapterName, string IPAddress, string Subnet, string Gateway)
        {
            _AdapterName = AdapterName;
            _IPAddress = IPAddress;
            _Subnet = Subnet;
            _Gateway = Gateway;
            _FileName = FileName;
        }

        public void SaveNewProfile(string profileName)
        {
            char[] stringChar = { ' ' };
            string[] newFilename;
            string newFile = "";

            newFilename = profileName.Split(stringChar);

            foreach (string s in newFilename)
            {
                newFile = newFile + s;
            }

            using (XmlWriter XmlProfileWriter = XmlWriter.Create(_FilePath + profileName + ".xml"))
            {
                XmlProfileWriter.WriteStartDocument();
                XmlProfileWriter.WriteStartElement(newFile);

                XmlProfileWriter.WriteElementString("AdapterName", _AdapterName);
                XmlProfileWriter.WriteElementString("IPAddress", _IPAddress);
                XmlProfileWriter.WriteElementString("Subnet", _Subnet);
                XmlProfileWriter.WriteElementString("Gateway", _Gateway);

                XmlProfileWriter.WriteEndElement();
                XmlProfileWriter.WriteEndDocument();

            }
                     
        }
        public void UpdateProfile(string profileName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_FilePath + profileName + ".xml");
           
            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                switch (element.Name)
                {
                    case "AdapterName":
                        if (element.InnerText != _AdapterName)
                        {
                            element.InnerText = _AdapterName;
                        }
                        break;
                    case "IPAddress":
                        if (element.InnerText != _IPAddress)
                        {
                            element.InnerText = _IPAddress;
                        }
                        break;
                    case "Subnet":
                        if (element.InnerText != _Subnet)
                        {
                            element.InnerText = _Subnet;
                        }
                        break;
                    case "Gateway":
                        if (element.InnerText != _Gateway)
                        {
                            element.Value = _Gateway;
                        }
                        break;
                }
            }
            xmlDoc.Save(_FilePath + profileName + ".xml");
        }

        public void CheckFileExists(string fileName)
        {
            CheckForFilePath();
            //if (!Directory.Exists(_FilePath))
            //{
            //    Directory.CreateDirectory(_FilePath);
            //}

           
            if (File.Exists(_FilePath + fileName + ".xml"))
            {
                var resultVal = MessageBox.Show("Overwrite existing file?", "File Already Exists", MessageBoxButtons.YesNo);
                
                if(resultVal == DialogResult.Yes)
                {
                    UpdateProfile(fileName);
                }
                else
                {
                    SaveNewProfile(fileName);
                }
            }
            else
            {
                SaveNewProfile(fileName);
            }
        }

        public void CheckForFilePath()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            DialogResult result;  
            
            if(config.AppSettings.Settings["Path"].Value == "")
            {
                result = _fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _FilePath = _fbd.SelectedPath + "\\";
                    config.AppSettings.Settings["Path"].Value = _FilePath;
                    config.Save(ConfigurationSaveMode.Modified);
                }
                
            }
           
        }
        
    }
}
