namespace up_network
{
    partial class UpdateDevForm
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
            EditFormImage = new TextBox();
            EditFormBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            EditFormConsole = new NumericUpDown();
            EditFormWan = new NumericUpDown();
            EditFormLan = new NumericUpDown();
            EditFormDescription = new TextBox();
            EditFormVlan = new TextBox();
            EditFormIP = new TextBox();
            EditFormMAC = new TextBox();
            EditFormName = new TextBox();
            EditFormConnected = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)EditFormConsole).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditFormWan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditFormLan).BeginInit();
            SuspendLayout();
            // 
            // EditFormImage
            // 
            EditFormImage.Font = new Font("Geometria", 11.9999981F);
            EditFormImage.Location = new Point(45, 340);
            EditFormImage.Name = "EditFormImage";
            EditFormImage.PlaceholderText = "Путь до изображения";
            EditFormImage.Size = new Size(255, 28);
            EditFormImage.TabIndex = 25;
            // 
            // EditFormBtn
            // 
            EditFormBtn.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditFormBtn.Location = new Point(45, 580);
            EditFormBtn.Name = "EditFormBtn";
            EditFormBtn.Size = new Size(195, 31);
            EditFormBtn.TabIndex = 24;
            EditFormBtn.Text = "Изменить";
            EditFormBtn.UseVisualStyleBackColor = true;
            EditFormBtn.Click += EditFormBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(316, 478);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 23;
            label3.Text = "Console порты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(178, 478);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 22;
            label2.Text = "Wan порты";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(45, 478);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 21;
            label1.Text = "Lan порты";
            // 
            // EditFormConsole
            // 
            EditFormConsole.Font = new Font("Geometria", 11.9999981F);
            EditFormConsole.Location = new Point(316, 505);
            EditFormConsole.Name = "EditFormConsole";
            EditFormConsole.Size = new Size(106, 28);
            EditFormConsole.TabIndex = 20;
            EditFormConsole.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EditFormWan
            // 
            EditFormWan.Font = new Font("Geometria", 11.9999981F);
            EditFormWan.Location = new Point(178, 505);
            EditFormWan.Name = "EditFormWan";
            EditFormWan.Size = new Size(106, 28);
            EditFormWan.TabIndex = 19;
            EditFormWan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EditFormLan
            // 
            EditFormLan.Font = new Font("Geometria", 11.9999981F);
            EditFormLan.Location = new Point(45, 505);
            EditFormLan.Name = "EditFormLan";
            EditFormLan.Size = new Size(106, 28);
            EditFormLan.TabIndex = 18;
            EditFormLan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EditFormDescription
            // 
            EditFormDescription.Font = new Font("Geometria", 11.9999981F);
            EditFormDescription.Location = new Point(45, 220);
            EditFormDescription.Multiline = true;
            EditFormDescription.Name = "EditFormDescription";
            EditFormDescription.PlaceholderText = "Описание";
            EditFormDescription.Size = new Size(255, 97);
            EditFormDescription.TabIndex = 17;
            // 
            // EditFormVlan
            // 
            EditFormVlan.Font = new Font("Geometria", 11.9999981F);
            EditFormVlan.Location = new Point(45, 174);
            EditFormVlan.Name = "EditFormVlan";
            EditFormVlan.PlaceholderText = "Vlan";
            EditFormVlan.Size = new Size(255, 28);
            EditFormVlan.TabIndex = 16;
            // 
            // EditFormIP
            // 
            EditFormIP.Font = new Font("Geometria", 11.9999981F);
            EditFormIP.Location = new Point(45, 125);
            EditFormIP.Name = "EditFormIP";
            EditFormIP.PlaceholderText = "IP-адрес ";
            EditFormIP.Size = new Size(255, 28);
            EditFormIP.TabIndex = 15;
            // 
            // EditFormMAC
            // 
            EditFormMAC.Font = new Font("Geometria", 11.9999981F);
            EditFormMAC.Location = new Point(45, 80);
            EditFormMAC.Name = "EditFormMAC";
            EditFormMAC.PlaceholderText = "MAC-адрес";
            EditFormMAC.Size = new Size(255, 28);
            EditFormMAC.TabIndex = 14;
            // 
            // EditFormName
            // 
            EditFormName.Font = new Font("Geometria", 11.9999981F);
            EditFormName.Location = new Point(45, 39);
            EditFormName.Name = "EditFormName";
            EditFormName.PlaceholderText = "Имя устройства";
            EditFormName.Size = new Size(255, 28);
            EditFormName.TabIndex = 13;
            // 
            // EditFormConnected
            // 
            EditFormConnected.AutoSize = true;
            EditFormConnected.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditFormConnected.Location = new Point(46, 405);
            EditFormConnected.Name = "EditFormConnected";
            EditFormConnected.Size = new Size(130, 24);
            EditFormConnected.TabIndex = 26;
            EditFormConnected.Text = "Подключено";
            EditFormConnected.UseVisualStyleBackColor = true;
            // 
            // UpdateDevForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(516, 739);
            Controls.Add(EditFormConnected);
            Controls.Add(EditFormImage);
            Controls.Add(EditFormBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EditFormConsole);
            Controls.Add(EditFormWan);
            Controls.Add(EditFormLan);
            Controls.Add(EditFormDescription);
            Controls.Add(EditFormVlan);
            Controls.Add(EditFormIP);
            Controls.Add(EditFormMAC);
            Controls.Add(EditFormName);
            Name = "UpdateDevForm";
            Text = "Изменение устройства";
            Load += UpdateDevForm_Load;
            ((System.ComponentModel.ISupportInitialize)EditFormConsole).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditFormWan).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditFormLan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EditFormImage;
        private Button EditFormBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown EditFormConsole;
        private NumericUpDown EditFormWan;
        private NumericUpDown EditFormLan;
        private TextBox EditFormDescription;
        private TextBox EditFormVlan;
        private TextBox EditFormIP;
        private TextBox EditFormMAC;
        private TextBox EditFormName;
        private CheckBox EditFormConnected;
    }
}