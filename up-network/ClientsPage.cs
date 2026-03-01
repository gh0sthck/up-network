using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace up_network
{
    public partial class ClientsPage : UserControl
    {
        public event Action onExit;
        public event Action onMainClick;
        public event Action onTableClick;
        public User loggedUser;

        public ClientsPage()
        {
            InitializeComponent();
        }

        private void ClientsPage_Load(object sender, EventArgs e)
        {
            MainUsername.Text = loggedUser.Login.ToString();
        }
        private void NavbarTableBg_MouseHover(object sender, EventArgs e)
        {
            NavbarTableBg.BackColor = Color.FromArgb(68, 155, 251);
        }

        private void NavbarTableBg_MouseLeave(object sender, EventArgs e)
        {
            NavbarTableBg.BackColor = Color.FromArgb(100, 171, 251);
        }

        private void NavbarDevicesBg_MouseHover(object sender, EventArgs e)
        {
            NavbarDevicesBg.BackColor = Color.FromArgb(68, 155, 251);
        }

        private void NavbarDevicesBg_MouseLeave(object sender, EventArgs e)
        {
            NavbarDevicesBg.BackColor = Color.FromArgb(100, 171, 251);
        }

        private void NavbarMainBg_Click(object sender, EventArgs e)
        {
            onMainClick?.Invoke();
        }

        private void NavbarTableBg_Click(Object sender, EventArgs e)
        {
            onTableClick?.Invoke();
        }

        private void MainExitButton_Click(object sender, EventArgs e)
        {
            onExit?.Invoke();
        }

    }
}
