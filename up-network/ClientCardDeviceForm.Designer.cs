namespace up_network
{
    partial class ClientCardDeviceForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DeviceFormName = new Label();
            DeviceFormMAC = new Label();
            DeviceFormStatus = new Label();
            DeviceFormIP = new Label();
            DeviceFormDesc = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // DeviceFormName
            // 
            DeviceFormName.AutoSize = true;
            DeviceFormName.Font = new Font("Geometria", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeviceFormName.Location = new Point(45, 223);
            DeviceFormName.Name = "DeviceFormName";
            DeviceFormName.Size = new Size(108, 24);
            DeviceFormName.TabIndex = 0;
            DeviceFormName.Text = "dev_name";
            // 
            // DeviceFormMAC
            // 
            DeviceFormMAC.AutoSize = true;
            DeviceFormMAC.Font = new Font("Geometria", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeviceFormMAC.Location = new Point(125, 275);
            DeviceFormMAC.Name = "DeviceFormMAC";
            DeviceFormMAC.Size = new Size(49, 24);
            DeviceFormMAC.TabIndex = 1;
            DeviceFormMAC.Text = "mac";
            // 
            // DeviceFormStatus
            // 
            DeviceFormStatus.AutoSize = true;
            DeviceFormStatus.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeviceFormStatus.Location = new Point(307, 227);
            DeviceFormStatus.Name = "DeviceFormStatus";
            DeviceFormStatus.Size = new Size(59, 20);
            DeviceFormStatus.TabIndex = 2;
            DeviceFormStatus.Text = "status";
            // 
            // DeviceFormIP
            // 
            DeviceFormIP.AutoSize = true;
            DeviceFormIP.Font = new Font("Geometria", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeviceFormIP.Location = new Point(125, 312);
            DeviceFormIP.Name = "DeviceFormIP";
            DeviceFormIP.Size = new Size(28, 24);
            DeviceFormIP.TabIndex = 3;
            DeviceFormIP.Text = "ip";
            // 
            // DeviceFormDesc
            // 
            DeviceFormDesc.AutoSize = true;
            DeviceFormDesc.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeviceFormDesc.Location = new Point(45, 382);
            DeviceFormDesc.Name = "DeviceFormDesc";
            DeviceFormDesc.Size = new Size(114, 24);
            DeviceFormDesc.TabIndex = 4;
            DeviceFormDesc.Text = "description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(45, 275);
            label1.Name = "label1";
            label1.Size = new Size(56, 24);
            label1.TabIndex = 5;
            label1.Text = "MAC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(45, 312);
            label2.Name = "label2";
            label2.Size = new Size(32, 24);
            label2.TabIndex = 6;
            label2.Text = "IP:";
            // 
            // ClientCardDeviceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 489);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DeviceFormDesc);
            Controls.Add(DeviceFormIP);
            Controls.Add(DeviceFormStatus);
            Controls.Add(DeviceFormMAC);
            Controls.Add(DeviceFormName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ClientCardDeviceForm";
            Text = "Информация об устройстве";
            Load += ClientCardDeviceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeviceFormName;
        private Label DeviceFormMAC;
        private Label DeviceFormStatus;
        private Label DeviceFormIP;
        private Label DeviceFormDesc;
        private Label label1;
        private Label label2;
    }
}