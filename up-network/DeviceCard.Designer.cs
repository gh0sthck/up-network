namespace up_network
{
    partial class DeviceCard
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
            DevCardName = new Label();
            DevCardDesc = new Label();
            label3 = new Label();
            label4 = new Label();
            DevCardStatus = new Label();
            DevCardMAC = new Label();
            DevCardIP = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Location = new Point(21, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 197);
            panel1.TabIndex = 0;
            panel1.Click += DeviceCard_Click;
            // 
            // DevCardName
            // 
            DevCardName.AutoSize = true;
            DevCardName.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DevCardName.Location = new Point(21, 228);
            DevCardName.Name = "DevCardName";
            DevCardName.Size = new Size(93, 20);
            DevCardName.TabIndex = 1;
            DevCardName.Text = "DeviceText";
            // 
            // DevCardDesc
            // 
            DevCardDesc.AutoSize = true;
            DevCardDesc.Font = new Font("Geometria", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DevCardDesc.Location = new Point(21, 258);
            DevCardDesc.Name = "DevCardDesc";
            DevCardDesc.Size = new Size(97, 19);
            DevCardDesc.TabIndex = 2;
            DevCardDesc.Text = "DeviceDesc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Geometria", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(21, 308);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 3;
            label3.Text = "MAC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(21, 335);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 4;
            label4.Text = "IP:";
            // 
            // DevCardStatus
            // 
            DevCardStatus.AutoSize = true;
            DevCardStatus.Font = new Font("Geometria", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DevCardStatus.Location = new Point(200, 232);
            DevCardStatus.Name = "DevCardStatus";
            DevCardStatus.Size = new Size(80, 16);
            DevCardStatus.TabIndex = 5;
            DevCardStatus.Text = "Подключен";
            // 
            // DevCardMAC
            // 
            DevCardMAC.AutoSize = true;
            DevCardMAC.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DevCardMAC.Location = new Point(85, 307);
            DevCardMAC.Name = "DevCardMAC";
            DevCardMAC.Size = new Size(212, 20);
            DevCardMAC.TabIndex = 6;
            DevCardMAC.Text = "fd01::423b:f0c0:30ed:b73e";
            // 
            // DevCardIP
            // 
            DevCardIP.AutoSize = true;
            DevCardIP.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DevCardIP.Location = new Point(85, 335);
            DevCardIP.Name = "DevCardIP";
            DevCardIP.Size = new Size(85, 20);
            DevCardIP.TabIndex = 7;
            DevCardIP.Text = "192.168.0.1";
            // 
            // DeviceCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 231, 231);
            Controls.Add(DevCardIP);
            Controls.Add(DevCardMAC);
            Controls.Add(DevCardStatus);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DevCardDesc);
            Controls.Add(DevCardName);
            Controls.Add(panel1);
            Name = "DeviceCard";
            Size = new Size(310, 380);
            Load += DeviceCard_Load;
            Click += DeviceCard_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label DevCardName;
        private Label DevCardDesc;
        private Label label3;
        private Label label4;
        private Label DevCardStatus;
        private Label DevCardMAC;
        private Label DevCardIP;
    }
}
