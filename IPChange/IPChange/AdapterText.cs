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
    class AdapterText 
    {
        private string _IPAddress;
        private string _Subnet;
        private string _Gateway;
        private string _FilePath = ConfigurationManager.AppSettings["Path"] + "\\";
        
        public string IPAddress { get { return _IPAddress;} set { _IPAddress = value; } }
        public string Subnet { get { return _Subnet; } set { _Subnet = value; } }
        public string Gateway { get { return _Gateway; } set { _Gateway = value; } }
        public delegate void DataChangedEventHandler(object source, EventArgs args);
        public event DataChangedEventHandler DataChanged;

        public void PopulateProfileValues(string Profile)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(_FilePath + Profile + ".xml");

            foreach (XmlElement e in doc.DocumentElement)
            {
                switch (e.Name)
                {
                    case "IPAddress":
                        _IPAddress = e.Name + ":" + e.InnerText;
                        break;
                    case "Subnet":
                        _Subnet = e.Name + ":" + e.InnerText;
                        break;
                    case "Gateway":
                        _Gateway = e.Name + ":" + e.InnerText;
                        break;
                }
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
                    
                    case "IPAddress":
                        element.InnerText = Split(_IPAddress);
                        break;
                    case "Subnet":
                        element.InnerText = Split(_Subnet);
                        break;
                    case "Gateway":
                        element.InnerText = Split(_Gateway);
                        break;
                }
            }
            xmlDoc.Save(_FilePath + profileName + ".xml");
            OnDataChanged();
        }

        public string Split(string Val)
        {
            char[] stringChar = { ':' };
            string[] newVal;

            newVal = Val.Split(stringChar);
            return newVal[1];

        }
        protected virtual void OnDataChanged()
        {
            DataChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
