using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace up_network
{
    internal class DatabaseController
    {
        private readonly string connectionString;
        
        public DatabaseController() 
        {
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

        public Device GetDeviceFromReader(SQLiteDataReader reader)
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
            return d;
        }

        public List<Device> GetAllDevicesByName()
        {
            List<Device> devs = new List<Device>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.CommandText = @"SELECT id, name, description, status, mac, ip, lan_ports, wan_ports, console_ports, vlan, image FROM devices ORDER BY name ASC;";
                command.Connection = connection;

                using (command)
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            devs.Add(GetDeviceFromReader(reader));
                        }
                    }
                }
            }

            return devs;
        }

        public List<Device> GetDevicesByMac()
        {
            List<Device> devs = new List<Device>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.CommandText = @"SELECT id, name, description, status, mac, ip, lan_ports, wan_ports, console_ports, vlan, image FROM devices ORDER BY mac ASC;";
                command.Connection = connection;

                using (command)
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            devs.Add(GetDeviceFromReader(reader));
                        }
                    }
                }
            }

            return devs;
        }

        public List<Device> GetDevicesByIP()
        {
            List<Device> devs = new List<Device>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.CommandText = @"SELECT id, name, description, status, mac, ip, lan_ports, wan_ports, console_ports, vlan, image FROM devices ORDER BY ip ASC;";
                command.Connection = connection;

                using (command)
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            devs.Add(GetDeviceFromReader(reader));
                        }
                    }
                }
            }

            return devs;
        }

        public List<Device> GetStatusDevices(bool status = true)
        {
            List<Device> devs = new List<Device>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.CommandText = @$"SELECT id, name, description, status, mac, ip, lan_ports, wan_ports, console_ports, vlan, image FROM devices WHERE status = {status} ORDER BY name ASC;";
                command.Connection = connection;

                using (command)
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            devs.Add(GetDeviceFromReader(reader));
                        }
                    }
                }
            }

            return devs;
        }

        public List<Device> GetDevicesWithVlan(string vlan = "")
        {
            List<Device> devs = new List<Device>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.CommandText = @$"SELECT id, name, description, status, mac, ip, lan_ports, wan_ports, console_ports, vlan, image FROM devices WHERE vlan = '{vlan}' ORDER BY name ASC;";
                command.Connection = connection;

                using (command)
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            devs.Add(GetDeviceFromReader(reader));
                        }
                    }

                }
            }
            return devs;
        }

        public List<Client> GetClientsByName()
        {
            List<Client> clients = new List<Client>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.CommandText = @$"SELECT clients.name as cliName, companies.name, clients.contract, devices.name, devices.description, devices.status, devices.mac, devices.ip, devices.lan_ports, devices.wan_ports, devices.console_ports, devices.vlan, devices.image FROM clients  INNER JOIN  devices ON clients.device_id = devices.id  INNER JOIN companies ON clients.company_id = companies.id;";
                command.Connection = connection;

                using (command)
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client c = new Client(
                                name: reader["cliName"].ToString(),
                                company: reader["name"].ToString(),
                                contractNumber: reader["contract"].ToString(),
                                dev: GetDeviceFromReader(reader)
                            );
                            clients.Add(c);
                        }
                    }
                }
            }

            return clients;
        }

        public List<Client> GetClientsByCompany(string company)
        {
            List<Client> clients = new List<Client>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.CommandText = @$"SELECT clients.name as cliName, companies.name, clients.contract, devices.name, devices.description, devices.status, devices.mac, devices.ip, devices.lan_ports, devices.wan_ports, devices.console_ports, devices.vlan, devices.image FROM clients  INNER JOIN  devices ON clients.device_id = devices.id  INNER JOIN companies ON clients.company_id = companies.id WHERE companies.name = '{company}';";
                command.Connection = connection;

                using (command)
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client c = new Client(
                                name: reader["cliName"].ToString(),
                                company: reader["name"].ToString(),
                                contractNumber: reader["contract"].ToString(),
                                dev: GetDeviceFromReader(reader)
                            );
                            clients.Add(c);
                        }
                    }
                }
            }

            return clients;
        }

        public List<Client> GetClientsByContract(string contract)
        {
            List<Client> clients = new List<Client>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.CommandText = @$"SELECT clients.name as cliName, companies.name, clients.contract, devices.name, devices.description, devices.status, devices.mac, devices.ip, devices.lan_ports, devices.wan_ports, devices.console_ports, devices.vlan, devices.image FROM clients  INNER JOIN  devices ON clients.device_id = devices.id  INNER JOIN companies ON clients.company_id = companies.id WHERE contract = '{contract}';";
                command.Connection = connection;

                using (command)
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client c = new Client(
                                name: reader["cliName"].ToString(),
                                company: reader["name"].ToString(),
                                contractNumber: reader["contract"].ToString(),
                                dev: GetDeviceFromReader(reader)
                            );
                            clients.Add(c);
                        }
                    }
                }
            }

            return clients;
        }

        public List<Client> GetClientsByDevice(string devName)
        {
            List<Client> clients = new List<Client>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.CommandText = @$"SELECT clients.name as cliName, companies.name, clients.contract, devices.name, devices.description, devices.status, devices.mac, devices.ip, devices.lan_ports, devices.wan_ports, devices.console_ports, devices.vlan, devices.image FROM clients  INNER JOIN  devices ON clients.device_id = devices.id  INNER JOIN companies ON clients.company_id = companies.id  WHERE devices.name = '{devName}';";
                command.Connection = connection;

                using (command)
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client c = new Client(
                                name: reader["cliName"].ToString(),
                                company: reader["name"].ToString(),
                                contractNumber: reader["contract"].ToString(),
                                dev: GetDeviceFromReader(reader)
                            );
                            clients.Add(c);
                        }
                    }
                }
            }

            return clients;
        }

        public List<String> GetUniqueDevicesName()
        {
            List<String> names = new List<string>();

            foreach (Device device in GetAllDevicesByName())
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

            foreach (Client client in GetClientsByName())
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

            foreach (Client cli in GetClientsByName())
            {
                if (!(names.Contains(cli.Company)))
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

        public User? GetUserByName(string username)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = $@"SELECT login, password, user_roles.name as roleName FROM users INNER JOIN user_roles ON user_roles.id = users.id WHERE users.login = '{username}'";

                using (command)
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(
                                u_login: reader["login"].ToString(),
                                u_passwd: reader["password"].ToString(),
                                role: reader["roleName"].ToString()
                            );
                            return user;
                        }
                    }
                }
                return null;
            }
        }

        public Device? InsertDevice(Device dev)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = @$"INSERT INTO devices (name, description, status, mac, ip, vlan, lan_ports, wan_ports, console_ports, image) VALUES (@name, @desc, 0, @mac, @ip, @vlan, @lan, @wan, @console, @image)"; ;

                using (command)
                {
                    command.Parameters.AddWithValue("@name", dev.Name);
                    command.Parameters.AddWithValue("@desc", dev.Description);
                    command.Parameters.AddWithValue("@mac", dev.Mac);
                    command.Parameters.AddWithValue("@ip", dev.Ip);
                    command.Parameters.AddWithValue("@vlan", dev.Vlan);
                    command.Parameters.AddWithValue("@lan", dev.LanPorts);
                    command.Parameters.AddWithValue("@wan", dev.WanPorts);
                    command.Parameters.AddWithValue("@console", dev.ConsolePorts);
                    command.Parameters.AddWithValue("@image", dev.Image);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return dev;
                    }
                    return null;
                }
            }
        }

        public Device? UpdateDevice(Device dev, string oldMac)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = $@"UPDATE devices SET name = @name, description = @desc, status = @status, mac = @mac, ip = @ip, vlan = @vlan, lan_ports = @lan, wan_ports = @wan, console_ports = @console, image = @image WHERE mac = @oldmac;";

                using (command)
                {
                    command.Parameters.AddWithValue("oldmac", oldMac);
                    command.Parameters.AddWithValue("name", dev.Name);
                    command.Parameters.AddWithValue("desc", dev.Description);
                    command.Parameters.AddWithValue("status", dev.Status);
                    command.Parameters.AddWithValue("mac", dev.Mac);
                    command.Parameters.AddWithValue("ip", dev.Ip);
                    command.Parameters.AddWithValue("vlan", dev.Vlan);
                    command.Parameters.AddWithValue("lan", dev.LanPorts);
                    command.Parameters.AddWithValue("wan", dev.WanPorts);
                    command.Parameters.AddWithValue("console", dev.ConsolePorts);
                    command.Parameters.AddWithValue("image", dev.Image);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return dev;
                    }
                    return null;
                }
            }
        }
    }
}
