using System;
using System.Collections.Generic;
using System.Text;

namespace up_network
{
    public class Client
    {
        string name;
        string company;
        string contractNumber;
        Device device;

        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string ContractNumber
        {
            get { return contractNumber; }
            set { contractNumber = value; }
        }

        public Device Device
        {
            get { return device; }
            set { device = value; }
        }

        public Client(string name, string company, string contractNumber, Device dev)
        {
            this.name = name;
            this.company = company;
            this.contractNumber = contractNumber;
            this.device = dev;
        }
    }
}
