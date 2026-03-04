using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace up_network
{
    internal class DatabaseController
    {
        private readonly string connectionString;
        private SQLiteConnection connection;
        private SQLiteCommand command;
        
        public DatabaseController() 
        {
            //MessageBox.Show(Environment.CurrentDirectory);
            connectionString = $"Data Source = " + Environment.CurrentDirectory + @"\data.db; Version = 3;";
            
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
            List<Device> devs = new List<Device>();

            using (connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                command = new SQLiteCommand();
                command.CommandText = @"SELECT id, name, description, status, mac, ip, lan_ports, wan_ports, console_ports, vlan, image FROM devices ORDER BY name ASC;";
                command.Connection = connection;

                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Device d = new Device(
                        name: reader["name"].ToString(),
                        description: reader["description"].ToString(),
                        status: Boolean.Parse(reader["status"].ToString()),
                        mac: reader["mac"].ToString(),
                        ip: reader["ip"]?.ToString(),
                        lanPorts: int.Parse(reader["lan_ports"].ToString()),
                        wanPorts: int.Parse(reader["wan_ports"].ToString()),
                        consolePorts: int.Parse(reader["console_ports"].ToString()),
                        vlan: reader["vlan"].ToString(), 
                        image: reader["image"].ToString()
                    );
                    if (reader["ip"].ToString() == "")
                    {
                        d.Ip = null;
                    }
                    if (reader["vlan"].ToString() == "")
                    {
                        d.Vlan = null;
                    }

                    devs.Add(d);
                }

            }

            return devs;
        }

        public List<Device> GetDevicesByMac()
        {
            List<Device> devs = new List<Device>();

            using (connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                command = new SQLiteCommand();
                command.CommandText = @"SELECT id, name, description, status, mac, ip, lan_ports, wan_ports, console_ports, vlan, image FROM devices ORDER BY mac ASC;";
                command.Connection = connection;

                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Device d = new Device(
                        name: reader["name"].ToString(),
                        description: reader["description"].ToString(),
                        status: Boolean.Parse(reader["status"].ToString()),
                        mac: reader["mac"].ToString(),
                        ip: reader["ip"]?.ToString(),
                        lanPorts: int.Parse(reader["lan_ports"].ToString()),
                        wanPorts: int.Parse(reader["wan_ports"].ToString()),
                        consolePorts: int.Parse(reader["console_ports"].ToString()),
                        vlan: reader["vlan"].ToString(),
                        image: reader["image"].ToString()
                    );
                    if (reader["ip"].ToString() == "")
                    {
                        d.Ip = null;
                    }
                    if (reader["vlan"].ToString() == "")
                    {
                        d.Vlan = null;
                    }

                    devs.Add(d);
                }

            }

            return devs;
        }

        public List<Device> GetDevicesByIP()
        {
            List<Device> devs = new List<Device>();

            using (connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                command = new SQLiteCommand();
                command.CommandText = @"SELECT id, name, description, status, mac, ip, lan_ports, wan_ports, console_ports, vlan, image FROM devices ORDER BY ip ASC;";
                command.Connection = connection;

                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Device d = new Device(
                        name: reader["name"].ToString(),
                        description: reader["description"].ToString(),
                        status: Boolean.Parse(reader["status"].ToString()),
                        mac: reader["mac"].ToString(),
                        ip: reader["ip"]?.ToString(),
                        lanPorts: int.Parse(reader["lan_ports"].ToString()),
                        wanPorts: int.Parse(reader["wan_ports"].ToString()),
                        consolePorts: int.Parse(reader["console_ports"].ToString()),
                        vlan: reader["vlan"].ToString(),
                        image: reader["image"].ToString()
                    );
                    if (reader["ip"].ToString() == "")
                    {
                        d.Ip = null;
                    }
                    if (reader["vlan"].ToString() == "")
                    {
                        d.Vlan = null;
                    }

                    devs.Add(d);
                }

            }

            return devs;
        }

        public List<Device> GetStatusDevices(bool status = true)
        {
            List<Device> devs = new List<Device>();

            using (connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                command = new SQLiteCommand();
                command.CommandText = @$"SELECT id, name, description, status, mac, ip, lan_ports, wan_ports, console_ports, vlan, image FROM devices WHERE status = {status} ORDER BY name ASC;";
                command.Connection = connection;

                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Device d = new Device(
                        name: reader["name"].ToString(),
                        description: reader["description"].ToString(),
                        status: Boolean.Parse(reader["status"].ToString()),
                        mac: reader["mac"].ToString(),
                        ip: reader["ip"]?.ToString(),
                        lanPorts: int.Parse(reader["lan_ports"].ToString()),
                        wanPorts: int.Parse(reader["wan_ports"].ToString()),
                        consolePorts: int.Parse(reader["console_ports"].ToString()),
                        vlan: reader["vlan"].ToString(), 
                        image: reader["image"].ToString()
                    );
                    if (reader["ip"].ToString() == "")
                    {
                        d.Ip = null;
                    }
                    if (reader["vlan"].ToString() == "")
                    {
                        d.Vlan = null;
                    }

                    devs.Add(d);
                }

            }

            return devs;
        }

        public List<Device> GetDevicesWithVlan(string vlan = "")
        {
            List<Device> devs = new List<Device>();

            using (connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                command = new SQLiteCommand();
                command.CommandText = @$"SELECT id, name, description, status, mac, ip, lan_ports, wan_ports, console_ports, vlan, image FROM devices WHERE vlan = '{vlan}' ORDER BY name ASC;";
                command.Connection = connection;

                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Device d = new Device(
                        name: reader["name"].ToString(),
                        description: reader["description"].ToString(),
                        status: Boolean.Parse(reader["status"].ToString()),
                        mac: reader["mac"].ToString(),
                        ip: reader["ip"]?.ToString(),
                        lanPorts: int.Parse(reader["lan_ports"].ToString()),
                        wanPorts: int.Parse(reader["wan_ports"].ToString()),
                        consolePorts: int.Parse(reader["console_ports"].ToString()),
                        vlan: reader["vlan"].ToString(),
                        image: reader["image"].ToString()
                    );
                    if (reader["ip"].ToString() == "")
                    {
                        d.Ip = null;
                    }
                    if (reader["vlan"].ToString() == "")
                    {
                        d.Vlan = null;
                    }

                    devs.Add(d);
                }

            }

            return devs;
        }

        public List<Client> GetClientsByName(string cliName = "")
        {
            //List<Client> clients = new List<Client>();

            //using (connection = new SQLiteConnection(connectionString))
            //{
            //    connection.Open();
            //    command = new SQLiteCommand();
            //    command.CommandText = @$"SELECT id, name, description, status, mac, ip, lan_ports, wan_ports, console_ports, vlan, image FROM clients WHERE name = {cliName} ORDER BY name ASC;";
            //    command.Connection = connection;

            //    var reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {

            //        Device d = new Device(
            //            name: reader["name"].ToString(),
            //            description: reader["description"].ToString(),
            //            status: Boolean.Parse(reader["status"].ToString()),
            //            mac: reader["mac"].ToString(),
            //            ip: reader["ip"]?.ToString(),
            //            lanPorts: int.Parse(reader["lan_ports"].ToString()),
            //            wanPorts: int.Parse(reader["wan_ports"].ToString()),
            //            consolePorts: int.Parse(reader["console_ports"].ToString()),
            //            vlan: reader["vlan"].ToString(), // reader.GetString(9)
            //            image: reader["image"].ToString()
            //        );
            //        if (reader["ip"].ToString() == "")
            //        {
            //            d.Ip = null;
            //        }
            //        if (reader["vlan"].ToString() == "")
            //        {
            //            d.Vlan = null;
            //        }

            //        clients.Add(d);
            //    }

            //}

            //return clients;

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

            foreach (Device dev in GetAllDevicesByName())
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
