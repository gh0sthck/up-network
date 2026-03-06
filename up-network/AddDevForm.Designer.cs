namespace up_network
{
    partial class AddDevForm
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
            EditFormName = new TextBox();
            EditFormMAC = new TextBox();
            EditFormIP = new TextBox();
            EditFormVlan = new TextBox();
            EditFormDescription = new TextBox();
            EditFormLan = new NumericUpDown();
            EditFormWan = new NumericUpDown();
            EditFormConsole = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EditFormBtn = new Button();
            EditFormImage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)EditFormLan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditFormWan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditFormConsole).BeginInit();
            SuspendLayout();
            // 
            // EditFormName
            // 
            EditFormName.Font = new Font("Geometria", 11.9999981F);
            EditFormName.Location = new Point(44, 59);
            EditFormName.Name = "EditFormName";
            EditFormName.PlaceholderText = "Имя устройства";
            EditFormName.Size = new Size(255, 28);
            EditFormName.TabIndex = 0;
            // 
            // EditFormMAC
            // 
            EditFormMAC.Font = new Font("Geometria", 11.9999981F);
            EditFormMAC.Location = new Point(44, 100);
            EditFormMAC.Name = "EditFormMAC";
            EditFormMAC.PlaceholderText = "MAC-адрес";
            EditFormMAC.Size = new Size(255, 28);
            EditFormMAC.TabIndex = 1;
            // 
            // EditFormIP
            // 
            EditFormIP.Font = new Font("Geometria", 11.9999981F);
            EditFormIP.Location = new Point(44, 145);
            EditFormIP.Name = "EditFormIP";
            EditFormIP.PlaceholderText = "IP-адрес ";
            EditFormIP.Size = new Size(255, 28);
            EditFormIP.TabIndex = 2;
            // 
            // EditFormVlan
            // 
            EditFormVlan.Font = new Font("Geometria", 11.9999981F);
            EditFormVlan.Location = new Point(44, 194);
            EditFormVlan.Name = "EditFormVlan";
            EditFormVlan.PlaceholderText = "Vlan";
            EditFormVlan.Size = new Size(255, 28);
            EditFormVlan.TabIndex = 3;
            // 
            // EditFormDescription
            // 
            EditFormDescription.Font = new Font("Geometria", 11.9999981F);
            EditFormDescription.Location = new Point(44, 240);
            EditFormDescription.Multiline = true;
            EditFormDescription.Name = "EditFormDescription";
            EditFormDescription.PlaceholderText = "Описание";
            EditFormDescription.Size = new Size(255, 97);
            EditFormDescription.TabIndex = 4;
            // 
            // EditFormLan
            // 
            EditFormLan.Font = new Font("Geometria", 11.9999981F);
            EditFormLan.Location = new Point(44, 469);
            EditFormLan.Name = "EditFormLan";
            EditFormLan.Size = new Size(106, 28);
            EditFormLan.TabIndex = 5;
            EditFormLan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EditFormWan
            // 
            EditFormWan.Font = new Font("Geometria", 11.9999981F);
            EditFormWan.Location = new Point(177, 469);
            EditFormWan.Name = "EditFormWan";
            EditFormWan.Size = new Size(106, 28);
            EditFormWan.TabIndex = 6;
            EditFormWan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EditFormConsole
            // 
            EditFormConsole.Font = new Font("Geometria", 11.9999981F);
            EditFormConsole.Location = new Point(315, 469);
            EditFormConsole.Name = "EditFormConsole";
            EditFormConsole.Size = new Size(106, 28);
            EditFormConsole.TabIndex = 7;
            EditFormConsole.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(44, 442);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 8;
            label1.Text = "Lan порты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(177, 442);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 9;
            label2.Text = "Wan порты";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(315, 442);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 10;
            label3.Text = "Console порты";
            // 
            // EditFormBtn
            // 
            EditFormBtn.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditFormBtn.Location = new Point(44, 544);
            EditFormBtn.Name = "EditFormBtn";
            EditFormBtn.Size = new Size(195, 31);
            EditFormBtn.TabIndex = 11;
            EditFormBtn.Text = "Добавить";
            EditFormBtn.UseVisualStyleBackColor = true;
            EditFormBtn.Click += EditFormBtn_Click;
            // 
            // EditFormImage
            // 
            EditFormImage.Font = new Font("Geometria", 11.9999981F);
            EditFormImage.Location = new Point(44, 360);
            EditFormImage.Name = "EditFormImage";
            EditFormImage.PlaceholderText = "Путь до изображения";
            EditFormImage.Size = new Size(255, 28);
            EditFormImage.TabIndex = 12;
            // 
            // AddDevForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(488, 600);
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
            Name = "AddDevForm";
            Text = "Добавление устройства";
            Load += AddDevForm_Load;
            ((System.ComponentModel.ISupportInitialize)EditFormLan).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditFormWan).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditFormConsole).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EditFormName;
        private TextBox EditFormMAC;
        private TextBox EditFormIP;
        private TextBox EditFormVlan;
        private TextBox EditFormDescription;
        private NumericUpDown EditFormLan;
        private NumericUpDown EditFormWan;
        private NumericUpDown EditFormConsole;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button EditFormBtn;
        private TextBox EditFormImage;
    }
}