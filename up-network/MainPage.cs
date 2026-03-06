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
                card?.onClick += () => 
                {
                    if (loggedUser.Role == "Администратор")
                    {
                        Card_Click(device);
                    }
                };
                MainFlowLayout.Controls.Add(card);
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            MainUsername.Text = loggedUser.Login.ToString();
            MainRoleText.Text = loggedUser.Role;

            if (loggedUser.Role == "Администратор")
            {
                MainAddBtn.Visible = true;
            }
            if (loggedUser.Role == "Менеджер" || loggedUser.Role == "Администратор")
            {
                label5.Visible = true;
                MainFilterBox.Visible = true;
            }

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
            string state = MainFilterBox.SelectedIndex.ToString();

            switch (state)
            {
                case "0": InsertDeviceList(db.GetAllDevicesByName()); break;
                case "1": InsertDeviceList(db.GetDevicesByIP()); break;
                case "2": InsertDeviceList(db.GetDevicesByMac()); break;
                case "3": InsertDeviceList(db.GetStatusDevices()); break;
                case "4": InsertDeviceList(db.GetStatusDevices(false)); break;
            }

        }
        private void Card_Click(Device dev)
        {
            UpdateDevForm form = new UpdateDevForm(dev);
            form.Show();
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

        private void MainAddBtn_Click(object sender, EventArgs e)
        {
            AddDevForm form = new AddDevForm();
            form.Show();
        }
    }
}
