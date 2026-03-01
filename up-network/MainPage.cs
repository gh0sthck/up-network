using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace up_network
{
    public partial class MainPage : UserControl
    {
        public User loggedUser;
        public event Action onExit;
        public event Action onTableClick;
        public event Action onClientsClick;
        List<Device> devices;

        public MainPage()
        {
            InitializeComponent();
        }

        private void InsertDeviceList(List<Device> devices)
        {
            MainFlowLayout.Controls.Clear();
            foreach (Device device in devices)
            {
                var card = new DeviceCard();
                card.currentDevice = device;
                MainFlowLayout.Controls.Add(card);
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            MainUsername.Text = loggedUser.Login.ToString();
            devices = new List<Device>();
            devices.Add(new Device("Коммутатор CISCO", "ул. Проспект Мира, к.3, д.16", true, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("Коммутатор qTech", "ул. б. Переяславская,  д.16", false, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("D-Link DGS-1008A", "ул. Космонавтов, к.4, д.12", true, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("Zyxel GS1900-24E", "ул. Проспект Мира, к.3, д.16", true, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("TP-Link TL-1P", "ул. Космонавтов, д.11", false, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("TP-Link TL-2P", "ул. Космонавтов, д.11", false, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("TP-Link TL-3P", "ул. Космонавтов, д.11", true, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("TP-Link TL-4P", "ул. Космонавтов, д.11", false, "fd01::423b:f0c0:30ed:b73e"));

            InsertDeviceList(devices);

            MainFilterBox.Items.Add("По названию");
            MainFilterBox.Items.Add("По IP");
            MainFilterBox.Items.Add("По MAC");
            MainFilterBox.Items.Add("Подключенные");
            MainFilterBox.Items.Add("Не подключенные");
            MainFilterBox.SelectedIndex = 0;
            MainFilterBox.SelectedIndexChanged += FilterBox_Changed;

        }

        private void FilterBox_Changed(object sender, EventArgs e)
        {
            string state = MainFilterBox.SelectedIndex.ToString();
            List<Device> dv = new List<Device>();
            if (state == "3")
            {
                foreach (var device in devices)
                {
                    if (device.Status)
                    {
                        dv.Add(device); 
                    }
                }
            } else if (state == "4")
            {
                foreach (var dev in devices)
                {
                    if (!(dev.Status))
                    {
                        dv.Add(dev);
                    }
                }
            }
            else
            {
                MessageBox.Show(state);
            }
            InsertDeviceList(dv);
            
        }

        private void NavbarTableBg_MouseHover(object sender, EventArgs e)
        {
            NavbarTableBg.BackColor = Color.FromArgb(68, 155, 251);
        }

        private void NavbarClientsBg_MouseHover(object sender, EventArgs e)
        {
            NavbarClientsBg.BackColor = Color.FromArgb(68, 155, 251);
        }

        private void NavbarTableBg_MouseLeave(object sender, EventArgs e)
        {
            NavbarTableBg.BackColor = Color.FromArgb(100, 171, 251);
        }

        private void NavbarClientsBg_MouseLeave(object sender, EventArgs e)
        {
            NavbarClientsBg.BackColor = Color.FromArgb(100, 171, 251);
        }

        private void MainExitButton_Click(object sender, EventArgs e)
        {
            onExit?.Invoke();
        }

        private void NavbarTableBg_Click(object sender, EventArgs e)
        {
            onTableClick?.Invoke();
        }

        private void NavbarClientsBg_Click(Object sender, EventArgs e)
        {
            onClientsClick?.Invoke();
        }
    }
}
