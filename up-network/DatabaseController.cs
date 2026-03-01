using System;
using System.Collections.Generic;
using System.Text;

namespace up_network
{
    internal class DatabaseController
    {
        string connectionString;
        public DatabaseController() 
        {
            connectionString = "";
        }

        private List<Device> GetFoobarDevices()
        {
            List<Device> devices = new List<Device>();
            devices.Add(new Device("Коммутатор CISCO", "ул. Проспект Мира, к.3, д.16", true, "fd01::423b:f0c0:30ed:b73e", "10.177.4.202", vlan:"CISCO"));
            devices.Add(new Device("Коммутатор qTech", "ул. б. Переяславская,  д.16", false, "fd01::423b:f0c0:30ed:b73e", "10.176.2.200", vlan: "QT"));
            devices.Add(new Device("D-Link DGS-1008A", "ул. Космонавтов, к.4, д.12", false, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("Zyxel GS1900-24E", "ул. Проспект Мира, к.3, д.16", false, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("TP-Link TL-1P", "ул. Космонавтов, д.11", false, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("TP-Link TL-2P", "ул. Проспект Мира, к.3, д.16", true, "fd01::423b:f0c0:30ed:b73e", "10.170.2.101", vlan: "TPL"));
            devices.Add(new Device("TP-Link TL-3P", "ул. б. Переяславская,  д.16", true, "fd01::423b:f0c0:30ed:b73e", "10.170.2.101", vlan: "TPL"));
            devices.Add(new Device("TP-Link TL-4P", "ул. Космонавтов, д.11", true, "fd01::423b:f0c0:30ed:b73e", "10.170.2.101", vlan: "TPL"));
            devices.Add(new Device("Zyxel GS1920-24E", "ул. Космонавтов, д.11", false, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("Коммутатор qTech", "ул. Космонавтов, д.11", true, "fd01::423b:f0c0:30ed:b73e", "10.176.2.200", vlan: "QT"));
            devices.Add(new Device("Коммутатор qTech", "ул. б. Переяславская,  д.16", true, "fd01::423b:f0c0:30ed:b73e", "10.176.2.200", vlan: "QT"));
            devices.Add(new Device("Коммутатор CISCO", "ул. Космонавтов, д.11", false, "fd01::423b:f0c0:30ed:b73e", "10.177.4.201", vlan: "CISCO"));
            devices.Add(new Device("TP-Link TL-4P", "ул. Проспект Мира, к.3, д.16", true, "fd01::423b:f0c0:30ed:b73e", "10.170.2.101", vlan: "TPL"));
            devices.Add(new Device("D-Link DGS-1008A", "ул. б. Переяславская,  д.16", false, "fd01::423b:f0c0:30ed:b73e"));

            return devices;
        }

        private List<Client> GetFoobarClients()
        {
            var clients = new List<Client>();
            List<Device> devs = GetFoobarDevices();
            for (int i  = 0; i < devs.Count; i++)
            {
                clients.Add(
                    new Client("Test-Client-" + i.ToString(), "Company-"+i.ToString(), "#CONT-" + i.ToString(), devs[i])
                   ); 
            }

            return clients;
        }

        public List<Device> GetAllDevicesByName()
        {
            return GetFoobarDevices();
        }

        public List<Device> GetDevicesByMac()
        {
            return GetFoobarDevices();
        }

        public List<Device> GetDevicesByIP()
        {
            return GetFoobarDevices();
        }

        public List<Device> GetConnectedDevices()
        {
            return GetFoobarDevices();
        }

        public List<Device> GetDisconnectedDevices()
        {
            return GetFoobarDevices();
        }

        public List<Device> GetDevicesWithVlan(string vlan)
        {
            return GetFoobarDevices();
        }

        public List<Client> GetClientsByName()
        {
            return GetFoobarClients();
        }

        public List<Client> GetClientsByCompany(string company)
        {
            return GetFoobarClients();
        }

        public List<Client> GetClientsByContract(string contract)
        {
            return GetFoobarClients();
        }

        public List<String> GetUniqueDevicesName()
        {
            List<String> names = new List<string>();

            foreach (Device device in GetFoobarDevices())
            {
                if (!(names.Contains(device.Name)))
                {
                    names.Add(device.Name);
                }
            }
            return names;
        }

        public List<String> GetContractsName()
        {
            List<String> names = new List<string>();

            foreach (Client client in GetFoobarClients())
            {
                if (!(names.Contains(client.ContractNumber.ToString())))
                {
                    names.Add(client.ContractNumber.ToString());
                }
            }
            return names;
        }

        public List<String> GetCompaniesList()
        {

            List<String> names = new List<string>();

            foreach (Client cli in GetFoobarClients())
            {
                if (!(names.Contains(cli.Name)))
                {
                    names.Add(cli.Company);
                }
            }
            return names;
        }

        public List<String> GetVlanList()
        {
            List<String> names = new List<string>();

            foreach (Device dev in GetFoobarDevices())
            {
                if (dev.Vlan != null)
                {
                    if (!(names.Contains(dev.Vlan.ToString())))
                    {
                        names.Add(dev.Vlan.ToString());
                    }
                }
            }
            return names;
        }
    }
}
