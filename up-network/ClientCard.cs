using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace up_network
{
    public partial class ClientCard : UserControl
    {

        public Client currentClient;

        public ClientCard()
        {
            InitializeComponent();
        }

        private void ClientCard_Load(object sender, EventArgs e)
        {
            ClientCardCompany.Text = currentClient.Company.ToString();
            ClientCardName.Text = currentClient.Name.ToString();
            ClientCardContract.Text = currentClient.ContractNumber.ToString();
            ClientCardDevice.Text = currentClient.Device.Name.ToString();
        }
    }
}
