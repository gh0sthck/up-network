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

            List<Client> list = new List<Client>();
            Device d1 = new Device("test dev.1", "kakoyto-addr", true, "jfkdjkj");
            Device d2 = new Device("test dev.2", "kakoyto-addr2", true, "jfdsfdsfskdjkj");
            Device d3 = new Device("test dev.3", "kakoyto-addr3", true, "jfkddsfdsfjkj");
            Device d4 = new Device("test dev.4", "kakoyto-addr4", false, "fdsf");
            Device d5 = new Device("test dev.5", "kakoyto-addr5", false, "jfkdjkfdsfdsj");

            list.Add(new Client("Andrey Joans", "Rostelecom", "#90u8", d1));
            list.Add(new Client("Peter Pedegru", "MTC", "#90u8", d1));
            list.Add(new Client("Vol De Mort", "Rostelecom", "#90uz8", d2));
            list.Add(new Client("Harry Potter", "ФЛ", "#90u12", d3));
            list.Add(new Client("Rick Decart", "Rostelecom", "#94u8", d4));

            foreach (Client cli in list)
            {
                ClientCard card = new ClientCard();
                card.currentClient = cli;
                ClientFlowLayout.Controls.Add(card);
            }

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
