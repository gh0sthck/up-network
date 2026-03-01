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
        public event Action onClientsClick;
        DatabaseController db;

        public TablePage()
        {
            db = new DatabaseController();
            InitializeComponent();
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

        private void NavbarClientsBg_Click(Object sender, EventArgs e)
        {
            onClientsClick?.Invoke();
        }

        private void InsertDeviceList(List<Device> devices)
        {
            TableFlowLayout.Controls.Clear();
            foreach (Device device in devices)
            {
                var card = new TableCard();
                card.currentDevice = device;
                TableFlowLayout.Controls.Add(card);
            }
        }

        private void TablePage_Load(object sender, EventArgs e)
        {
            MainUsername.Text = loggedUser.Login.ToString();

            foreach (string val in db.GetVlanList())
            {
                TableVlanFilter.Items.Add(val);
            }
            TableVlanFilter.SelectedIndex = 0;


            InsertDeviceList(db.GetAllDevicesByName());
        }
    }
}
