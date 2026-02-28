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
        List<Device> devices;

        public MainPage()
        {
            InitializeComponent();
        }



        private void MainPage_Load(object sender, EventArgs e)
        {
            MainUsername.Text = loggedUser.Login.ToString();
            devices = new List<Device>();
            devices.Add(new Device("Коммутатор CISCO", "ул. Проспект Мира, к.3, д.16", true, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("Коммутатор qTech", "ул. б. Переяславская,  д.16", true, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("D-Link DGS-1008A", "ул. Космонавтов, к.4, д.12", true, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("Zyxel GS1900-24E", "ул. Проспект Мира, к.3, д.16", true, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("TP-Link TL-SG1008P", "ул. Космонавтов, д.11", true, "fd01::423b:f0c0:30ed:b73e"));

            for (int i = 0; i < devices.Count; i++)
            {
                var card = new DeviceCard();
                card.currentDevice = devices[i];
                MainFlowLayout.Controls.Add(card);
            }
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
    }
}
