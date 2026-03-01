namespace up_network
{
    partial class ClientCard
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
            ClientCardName = new Label();
            ClientCardDevice = new Label();
            ClientCardContract = new Label();
            ClientCardCompany = new Label();
            SuspendLayout();
            // 
            // ClientCardName
            // 
            ClientCardName.AutoSize = true;
            ClientCardName.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClientCardName.Location = new Point(225, 31);
            ClientCardName.Name = "ClientCardName";
            ClientCardName.Size = new Size(61, 24);
            ClientCardName.TabIndex = 0;
            ClientCardName.Text = "name";
            // 
            // ClientCardDevice
            // 
            ClientCardDevice.AutoSize = true;
            ClientCardDevice.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClientCardDevice.Location = new Point(830, 31);
            ClientCardDevice.Name = "ClientCardDevice";
            ClientCardDevice.Size = new Size(70, 24);
            ClientCardDevice.TabIndex = 1;
            ClientCardDevice.Text = "device";
            // 
            // ClientCardContract
            // 
            ClientCardContract.AutoSize = true;
            ClientCardContract.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClientCardContract.Location = new Point(614, 31);
            ClientCardContract.Name = "ClientCardContract";
            ClientCardContract.Size = new Size(88, 24);
            ClientCardContract.TabIndex = 2;
            ClientCardContract.Text = "contract";
            // 
            // ClientCardCompany
            // 
            ClientCardCompany.AutoSize = true;
            ClientCardCompany.Font = new Font("Geometria", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientCardCompany.Location = new Point(52, 31);
            ClientCardCompany.Name = "ClientCardCompany";
            ClientCardCompany.Size = new Size(96, 24);
            ClientCardCompany.TabIndex = 3;
            ClientCardCompany.Text = "company";
            // 
            // ClientCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClientCardCompany);
            Controls.Add(ClientCardContract);
            Controls.Add(ClientCardDevice);
            Controls.Add(ClientCardName);
            Name = "ClientCard";
            Size = new Size(976, 80);
            Load += ClientCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ClientCardName;
        private Label ClientCardDevice;
        private Label ClientCardContract;
        private Label ClientCardCompany;
    }
}
