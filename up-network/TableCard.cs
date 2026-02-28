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
    public partial class TableCard : UserControl
    {
        public Device currentDeivce;

        public TableCard()
        {
            InitializeComponent();
        }

        private void TableCard_Load(object sender, EventArgs e)
        {
            int radius = 19;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(TableCardStatus.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(TableCardStatus.Width - radius, TableCardStatus.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, TableCardStatus.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            TableCardStatus.Region = new Region(path);

            TableCardMAC.Text = currentDeivce.Mac;
            TableCardIP.Text = currentDeivce.Ip;
            TableCardVLAN.Text = currentDeivce.Vlan;
            if (currentDeivce.Status)
            {
                TableCardStatus.BackColor = Color.Green;
            }
            else
            {
                TableCardStatus.BackColor = Color.Red;
            }
        }
    }
}
