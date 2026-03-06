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
            DeviceFormPicture = new PictureBox();
            label3 = new Label();
            DeviceFormPorts = new Label();
            ((System.ComponentModel.ISupportInitialize)DeviceFormPicture).BeginInit();
            SuspendLayout();
            // 
            // DeviceFormName
            // 
            DeviceFormName.AutoSize = true;
            DeviceFormName.Font = new Font("Geometria", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeviceFormName.Location = new Point(45, 241);
            DeviceFormName.Name = "DeviceFormName";
            DeviceFormName.Size = new Size(108, 24);
            DeviceFormName.TabIndex = 0;
            DeviceFormName.Text = "dev_name";
            // 
            // DeviceFormMAC
            // 
            DeviceFormMAC.AutoSize = true;
            DeviceFormMAC.Font = new Font("Geometria", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeviceFormMAC.Location = new Point(125, 293);
            DeviceFormMAC.Name = "DeviceFormMAC";
            DeviceFormMAC.Size = new Size(49, 24);
            DeviceFormMAC.TabIndex = 1;
            DeviceFormMAC.Text = "mac";
            // 
            // DeviceFormStatus
            // 
            DeviceFormStatus.AutoSize = true;
            DeviceFormStatus.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeviceFormStatus.Location = new Point(307, 245);
            DeviceFormStatus.Name = "DeviceFormStatus";
            DeviceFormStatus.Size = new Size(59, 20);
            DeviceFormStatus.TabIndex = 2;
            DeviceFormStatus.Text = "status";
            // 
            // DeviceFormIP
            // 
            DeviceFormIP.AutoSize = true;
            DeviceFormIP.Font = new Font("Geometria", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeviceFormIP.Location = new Point(125, 330);
            DeviceFormIP.Name = "DeviceFormIP";
            DeviceFormIP.Size = new Size(28, 24);
            DeviceFormIP.TabIndex = 3;
            DeviceFormIP.Text = "ip";
            // 
            // DeviceFormDesc
            // 
            DeviceFormDesc.AutoSize = true;
            DeviceFormDesc.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeviceFormDesc.Location = new Point(45, 400);
            DeviceFormDesc.Name = "DeviceFormDesc";
            DeviceFormDesc.Size = new Size(114, 24);
            DeviceFormDesc.TabIndex = 4;
            DeviceFormDesc.Text = "description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(45, 293);
            label1.Name = "label1";
            label1.Size = new Size(56, 24);
            label1.TabIndex = 5;
            label1.Text = "MAC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(45, 330);
            label2.Name = "label2";
            label2.Size = new Size(32, 24);
            label2.TabIndex = 6;
            label2.Text = "IP:";
            // 
            // DeviceFormPicture
            // 
            DeviceFormPicture.Location = new Point(45, 28);
            DeviceFormPicture.Name = "DeviceFormPicture";
            DeviceFormPicture.Size = new Size(337, 192);
            DeviceFormPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            DeviceFormPicture.TabIndex = 7;
            DeviceFormPicture.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(45, 494);
            label3.Name = "label3";
            label3.Size = new Size(185, 24);
            label3.TabIndex = 8;
            label3.Text = "Lan/Wan/Console:";
            // 
            // DeviceFormPorts
            // 
            DeviceFormPorts.AutoSize = true;
            DeviceFormPorts.Font = new Font("Geometria", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeviceFormPorts.Location = new Point(45, 535);
            DeviceFormPorts.Name = "DeviceFormPorts";
            DeviceFormPorts.Size = new Size(186, 24);
            DeviceFormPorts.TabIndex = 9;
            DeviceFormPorts.Text = "Lan/Wan/Console:";
            // 
            // ClientCardDeviceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 597);
            Controls.Add(DeviceFormPorts);
            Controls.Add(label3);
            Controls.Add(DeviceFormPicture);
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
            ((System.ComponentModel.ISupportInitialize)DeviceFormPicture).EndInit();
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
        private PictureBox DeviceFormPicture;
        private Label label3;
        private Label DeviceFormPorts;
    }
}