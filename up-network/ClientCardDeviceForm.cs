using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace up_network
{
    public partial class ClientCardDeviceForm : Form
    {
        public Device device;

        public ClientCardDeviceForm()
        {
            InitializeComponent();
        }

        private void ClientCardDeviceForm_Load(object sender, EventArgs e)
        {
            DeviceFormName.Text = device.Name.ToString();
            DeviceFormMAC.Text = device.Mac.ToString();
            DeviceFormIP.Text = device.Ip?.ToString();
            DeviceFormDesc.Text = device.Description.ToString();

            DeviceFormPicture.Image = Image.FromFile("default.png");
            if (device.Image != "" && File.Exists(device.Image))
            {
                DeviceFormPicture.Image = Image.FromFile(device.Image);
            }

            DeviceFormPorts.Text = $"{device.LanPorts}/{device.WanPorts}/{device.ConsolePorts}";

            if (device.Status)
            {
                DeviceFormStatus.Text = "Подключено";
                DeviceFormStatus.ForeColor = Color.Green;
            } else
            {
                DeviceFormStatus.Text = "Не подключено";
                DeviceFormStatus.ForeColor = Color.Red;
            }
        }
    }
}
