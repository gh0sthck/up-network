using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            ClientCardCompany.Text = currentClient.Company.ToString();
            ClientCardName.Text = currentClient.Name.ToString();
            ClientCardContract.Text = currentClient.ContractNumber.ToString();
            ClientCardDevice.Text = currentClient.Device.Name.ToString();
        }

        private void ClientCardDevice_Click(object sender, EventArgs e)
        {
            ClientCardDeviceForm form = new ClientCardDeviceForm();
            form.device = currentClient.Device;
            form.Show();

        }
    }
}
