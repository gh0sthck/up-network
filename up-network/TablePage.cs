using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace up_network
{
    public partial class TablePage : UserControl
    {
        public User loggedUser;
        public event Action onExit;
        public event Action onMainClick;
        List<Device> devices = new List<Device>();

        public TablePage()
        {
            InitializeComponent();
            
            //MainUsername.Text = loggedUser.Login.ToString();
        }
        private void NavbarMainBg_MouseHover(object sender, EventArgs e)
        {
            NavbarMainBg.BackColor = Color.FromArgb(68, 155, 251);
        }

        private void NavbarMainBg_MouseLeave(object sender, EventArgs e)
        {
            NavbarMainBg.BackColor = Color.FromArgb(100, 171, 251);
        }

        private void NavbarClientsBg_MouseHover(object sender, EventArgs e)
        {
            NavbarClientsBg.BackColor = Color.FromArgb(68, 155, 251);
        }

        private void NavbarClientsBg_MouseLeave(object sender, EventArgs e)
        {
            NavbarClientsBg.BackColor = Color.FromArgb(100, 171, 251);
        }

        private void MainExitButton_Click(object sender, EventArgs e)
        {
            onExit?.Invoke();
        }

        private void NavbarMainBg_Click(object sender, EventArgs e)
        {
            onMainClick?.Invoke();
        }

        private void TablePage_Load(object sender, EventArgs e)
        {

            devices.Add(new Device("Коммутатор CISCO", "ул. Проспект Мира, к.3, д.16", true, "fd01::423b:f0c0:30ed:b73e", "192.168.0.1"));
            devices.Add(new Device("Коммутатор qTech", "ул. б. Переяславская,  д.16", true, "fd01::423b:f0c0:30ed:b73e", "10.177.4.123"));
            devices.Add(new Device("D-Link DGS-1008A", "ул. Космонавтов, к.4, д.12", true, "fd01::423b:f0c0:30ed:b73e", "10.177.4.111"));
            devices.Add(new Device("Zyxel GS1900-24E", "ул. Проспект Мира, к.3, д.16", true, "fd01::423b:f0c0:30ed:b73e"));
            devices.Add(new Device("TP-Link TL-SG1008P", "ул. Космонавтов, д.11", true, "fd01::423b:f0c0:30ed:b73e"));

            for (int i = 0; i < devices.Count; i++)
            {
                TableCard card = new TableCard();
                card.currentDeivce = devices[i];
                TableFlowLayout.Controls.Add(card);
            }
        }
    }
}
