using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace up_network
{
    public partial class AddDevForm : Form
    {
        DatabaseController db;

        public AddDevForm()
        {
            db = new DatabaseController();
            InitializeComponent();
        }

        private void AddDevForm_Load(object sender, EventArgs e)
        {

        }

        private void EditFormBtn_Click(object sender, EventArgs e)
        {
            string name = EditFormName.Text.ToString();
            string description = EditFormDescription.Text.ToString();
            string mac = EditFormMAC.Text.ToString();
            string? ip = EditFormIP.Text.ToString();
            string image = EditFormImage.Text.ToString();
            string? vlan = EditFormVlan.Text.ToString();

            if (vlan == "") { vlan = null; }
            if (ip == "") { ip = null; }

            int lan = int.Parse(EditFormLan.Value.ToString());
            int wan = int.Parse(EditFormWan.Value.ToString());
            int console = int.Parse(EditFormConsole.Value.ToString());

            Device insertDev = new Device(
                name: name,
                description: description,
                status: false,
                mac: mac,
                ip: ip,
                lanPorts: lan,
                wanPorts: wan,
                consolePorts: console,
                image: image
            );

            Device? r = db.InsertDevice(insertDev);
            if (r != null)
            {
                MessageBox.Show($"Устройство {r.Name} добавлено!");
            }
            this.Close();
            
        }
    }
}
