using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace up_network
{
    public partial class UpdateDevForm : Form
    {
        public Device editingDevice;
        DatabaseController db;

        public UpdateDevForm(Device editingDevice)
        {
            InitializeComponent();
            this.editingDevice = editingDevice;
            db = new DatabaseController();
        }

        private void UpdateDevForm_Load(object sender, EventArgs e)
        {
            EditFormName.Text = editingDevice.Name;
            EditFormDescription.Text = editingDevice.Description;
            EditFormMAC.Text = editingDevice.Mac;
            EditFormIP.Text = editingDevice.Ip;
            EditFormVlan.Text = editingDevice.Vlan;
            EditFormImage.Text = editingDevice.Image;
            EditFormLan.Value = editingDevice.LanPorts;
            EditFormWan.Value = editingDevice.WanPorts;
            EditFormConsole.Value = editingDevice.ConsolePorts;

            if (editingDevice.Status)
            {
                EditFormConnected.Checked = true;
            }
            else
            {
                EditFormConnected.Checked = false;
            }
        }

        private void EditFormBtn_Click(object sender, EventArgs e)
        {
            string name = EditFormName.Text.ToString();
            string description = EditFormDescription.Text.ToString();
            string mac = EditFormMAC.Text.ToString();
            string? ip = EditFormIP.Text.ToString();
            string image = EditFormImage.Text.ToString();
            string? vlan = EditFormVlan.Text.ToString();

            bool status = EditFormConnected.Checked;

            if (vlan == "") { vlan = null; }
            if (ip == "") { ip = null; }

            int lan = int.Parse(EditFormLan.Value.ToString());
            int wan = int.Parse(EditFormWan.Value.ToString());
            int console = int.Parse(EditFormConsole.Value.ToString());

            Device insertDev = new Device(
                name: name,
                description: description,
                status: status,
                mac: mac,
                vlan: vlan,
                ip: ip,
                lanPorts: lan,
                wanPorts: wan,
                consolePorts: console,
                image: image
            );

            Device? r = db.UpdateDevice(insertDev, editingDevice.Mac);
            if (r != null)
            {
                MessageBox.Show($"Устройство {r.Name} изменено!");
            }
            this.Close();
        }
    }
}
