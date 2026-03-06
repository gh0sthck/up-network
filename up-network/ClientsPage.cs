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
        DatabaseController db;

        public ClientsPage()
        {
            db = new DatabaseController();
            InitializeComponent();
        }

        private void InsertClientsList(List<Client> clients)
        {
            ClientFlowLayout.Controls.Clear();
            foreach (Client client in clients)
            {
                var card = new ClientCard();
                card.currentClient = client;
                ClientFlowLayout.Controls.Add(card);
            }
        }

        private void ClientsDeviceFilter_Changed(object sender, EventArgs e)
        {
            int state = ClientsDeviceFilter.SelectedIndex;
            if (state == 0)
            {
                InsertClientsList(db.GetClientsByName());
                return;
            }
            InsertClientsList(db.GetClientsByDevice(ClientsDeviceFilter.Items[state].ToString()));
        }

        private void ClientsNameFilter_Changed(object sender, EventArgs e)
        {
            int state = ClientsNameFilter.SelectedIndex;
            if (state == 0) 
            {
                InsertClientsList(db.GetClientsByName());
                return;
            }
            InsertClientsList(db.GetClientsByCompany(ClientsNameFilter.Items[state].ToString()));
        }

        private void ClientsContractFilter_Changed(object sender, EventArgs e)
        {
            int state = ClientsContractFilter.SelectedIndex;
            if (state == 0)
            {
                InsertClientsList(db.GetClientsByName());
                return;
            }
            InsertClientsList(db.GetClientsByContract(ClientsContractFilter.Items[state].ToString()));
        }

        private void ClientsPage_Load(object sender, EventArgs e)
        {
            MainUsername.Text = loggedUser.Login.ToString();
            MainRoleText.Text = loggedUser.Role;

            ClientsDeviceFilter.Items.Add("Все устройтсва");
            foreach (string val in db.GetUniqueDevicesName())
            {
                ClientsDeviceFilter.Items.Add(val);
            }
            ClientsDeviceFilter.SelectedIndex = 0;
            ClientsDeviceFilter.SelectedIndexChanged += ClientsDeviceFilter_Changed;

            ClientsNameFilter.Items.Add("Все компании");
            foreach (string val in db.GetCompaniesList())
            {
                ClientsNameFilter.Items.Add(val);
            }
            ClientsNameFilter.SelectedIndex = 0;
            ClientsNameFilter.SelectedIndexChanged += ClientsNameFilter_Changed;

            ClientsContractFilter.Items.Add("Все контракты");
            foreach (string val in db.GetContractsName())
            {
                ClientsContractFilter.Items.Add(val);
            }
            ClientsContractFilter.SelectedIndex = 0;
            ClientsContractFilter.SelectedIndexChanged += ClientsContractFilter_Changed;

            InsertClientsList(db.GetClientsByName());

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
