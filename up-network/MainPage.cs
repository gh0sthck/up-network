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
        DatabaseController db;

        public MainPage()
        {
            db = new DatabaseController();
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

            InsertDeviceList(db.GetAllDevicesByName());

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
            // return db.GetSmthDevice();
            string state = MainFilterBox.SelectedIndex.ToString();
            List<Device> dv = new List<Device>();
            if (state == "3")
            {
                foreach (var device in db.GetAllDevicesByName())
                {
                    if (device.Status)
                    {
                        dv.Add(device); 
                    }
                }
            } else if (state == "4")
            {
                foreach (var dev in db.GetAllDevicesByName())
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
