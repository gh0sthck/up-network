using System;
using System.Collections.Generic;
using System.Text;

namespace up_network
{
    public class Device
    {
        String name;
        String description;
        bool status;
        String mac;
        String? ip;

        int lanPorts;
        int wanPorts;
        int consolePorts;

        String image;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String? Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        public String Mac
        {
            get { return mac; }
            set { mac = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public Device(string name, string description, bool status, string mac, string? ip = null, int lanPorts = 1, int wanPorts = 1, int consolePorts = 1, string image = "")
        {
            this.name = name;
            this.description = description;
            this.status = status;
            this.mac = mac;
            this.ip = ip;
            this.lanPorts = lanPorts;
            this.wanPorts = wanPorts;
            this.consolePorts = consolePorts;
            this.image = image;
        }
    }
}
