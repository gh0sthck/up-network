namespace up_network
{
    partial class TableCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            TableCardMAC = new Label();
            TableCardIP = new Label();
            TableCardStatus = new Panel();
            TableCardVLAN = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(16, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 2);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(16, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 2);
            panel2.TabIndex = 1;
            // 
            // TableCardMAC
            // 
            TableCardMAC.AutoSize = true;
            TableCardMAC.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TableCardMAC.Location = new Point(16, 48);
            TableCardMAC.Name = "TableCardMAC";
            TableCardMAC.Size = new Size(240, 24);
            TableCardMAC.TabIndex = 2;
            TableCardMAC.Text = "fe80::b1e0:f544:abf3:e318";
            TableCardMAC.Click += TableCardMAC_Click;
            // 
            // TableCardIP
            // 
            TableCardIP.AutoSize = true;
            TableCardIP.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TableCardIP.Location = new Point(754, 48);
            TableCardIP.Name = "TableCardIP";
            TableCardIP.Size = new Size(157, 24);
            TableCardIP.TabIndex = 3;
            TableCardIP.Text = "255.255.255.255";
            // 
            // TableCardStatus
            // 
            TableCardStatus.Location = new Point(931, 52);
            TableCardStatus.Name = "TableCardStatus";
            TableCardStatus.Size = new Size(20, 20);
            TableCardStatus.TabIndex = 4;
            // 
            // TableCardVLAN
            // 
            TableCardVLAN.AutoSize = true;
            TableCardVLAN.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TableCardVLAN.Location = new Point(582, 48);
            TableCardVLAN.Name = "TableCardVLAN";
            TableCardVLAN.Size = new Size(106, 24);
            TableCardVLAN.TabIndex = 5;
            TableCardVLAN.Text = "ANYVLAN";
            // 
            // TableCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableCardVLAN);
            Controls.Add(TableCardStatus);
            Controls.Add(TableCardIP);
            Controls.Add(TableCardMAC);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TableCard";
            Size = new Size(971, 120);
            Load += TableCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label TableCardMAC;
        private Label TableCardIP;
        private Panel TableCardStatus;
        private Label TableCardVLAN;
    }
}
