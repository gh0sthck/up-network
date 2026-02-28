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
    public partial class DeviceCard : UserControl
    {
        public Device currentDevice;

        public DeviceCard()
        {
            InitializeComponent();
        }

        private void DeviceCard_Load(object sender, EventArgs e)
        {
            int radius = 30;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);


            DevCardName.Text = currentDevice.Name;
            DevCardDesc.Text = currentDevice.Description;
            DevCardMAC.Text = currentDevice.Mac;

            if (currentDevice.Status)
            {
                DevCardStatus.Text = "Подключено";
                DevCardStatus.ForeColor = Color.Green;
            }
            else
            {
                DevCardStatus.Text = "Не подключено";
                DevCardStatus.ForeColor = Color.Red;
            }
        }
    }
}
