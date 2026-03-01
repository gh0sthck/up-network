namespace up_network
{
    partial class ClientsPage
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
            MainExitButton = new Button();
            NavbarClientsBg = new Panel();
            label4 = new Label();
            NavbarTableBg = new Panel();
            label3 = new Label();
            NavbarDevicesBg = new Panel();
            label2 = new Label();
            label1 = new Label();
            MainUsername = new Label();
            ClientFlowLayout = new FlowLayoutPanel();
            ClientsNameFilter = new ComboBox();
            ClientsContractFilter = new ComboBox();
            ClientsDeviceFilter = new ComboBox();
            panel1.SuspendLayout();
            NavbarClientsBg.SuspendLayout();
            NavbarTableBg.SuspendLayout();
            NavbarDevicesBg.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 171, 251);
            panel1.Controls.Add(MainExitButton);
            panel1.Controls.Add(NavbarClientsBg);
            panel1.Controls.Add(NavbarTableBg);
            panel1.Controls.Add(NavbarDevicesBg);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MainUsername);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 711);
            panel1.TabIndex = 1;
            // 
            // MainExitButton
            // 
            MainExitButton.Location = new Point(25, 676);
            MainExitButton.Name = "MainExitButton";
            MainExitButton.Size = new Size(195, 23);
            MainExitButton.TabIndex = 6;
            MainExitButton.Text = "Выход";
            MainExitButton.UseVisualStyleBackColor = true;
            MainExitButton.Click += MainExitButton_Click;
            // 
            // NavbarClientsBg
            // 
            NavbarClientsBg.BackColor = Color.FromArgb(35, 137, 250);
            NavbarClientsBg.Controls.Add(label4);
            NavbarClientsBg.Location = new Point(0, 324);
            NavbarClientsBg.Name = "NavbarClientsBg";
            NavbarClientsBg.Size = new Size(262, 70);
            NavbarClientsBg.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(51, 25);
            label4.Name = "label4";
            label4.Size = new Size(92, 24);
            label4.TabIndex = 3;
            label4.Text = "Клиенты";
            // 
            // NavbarTableBg
            // 
            NavbarTableBg.BackColor = Color.FromArgb(100, 171, 251);
            NavbarTableBg.Controls.Add(label3);
            NavbarTableBg.Location = new Point(0, 254);
            NavbarTableBg.Name = "NavbarTableBg";
            NavbarTableBg.Size = new Size(262, 70);
            NavbarTableBg.TabIndex = 4;
            NavbarTableBg.Click += NavbarTableBg_Click;
            NavbarTableBg.MouseLeave += NavbarTableBg_MouseLeave;
            NavbarTableBg.MouseHover += NavbarTableBg_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 22);
            label3.Name = "label3";
            label3.Size = new Size(169, 24);
            label3.TabIndex = 1;
            label3.Text = "Сетевая таблица";
            label3.Click += NavbarTableBg_Click;
            label3.MouseLeave += NavbarTableBg_MouseLeave;
            label3.MouseHover += NavbarTableBg_MouseHover;
            // 
            // NavbarDevicesBg
            // 
            NavbarDevicesBg.BackColor = Color.FromArgb(100, 171, 251);
            NavbarDevicesBg.Controls.Add(label2);
            NavbarDevicesBg.Location = new Point(0, 184);
            NavbarDevicesBg.Name = "NavbarDevicesBg";
            NavbarDevicesBg.Size = new Size(262, 70);
            NavbarDevicesBg.TabIndex = 2;
            NavbarDevicesBg.Click += NavbarMainBg_Click;
            NavbarDevicesBg.MouseLeave += NavbarDevicesBg_MouseLeave;
            NavbarDevicesBg.MouseHover += NavbarDevicesBg_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Geometria", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 24);
            label2.Name = "label2";
            label2.Size = new Size(153, 24);
            label2.TabIndex = 0;
            label2.Text = "Оборудование";
            label2.Click += NavbarMainBg_Click;
            label2.MouseLeave += NavbarDevicesBg_MouseLeave;
            label2.MouseHover += NavbarDevicesBg_MouseHover;
            // 
            // label1
            // 
            label1.Font = new Font("Geometria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(236, 69);
            label1.TabIndex = 1;
            label1.Text = "СЕТЕВОЙ УЧЕТ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainUsername
            // 
            MainUsername.AutoSize = true;
            MainUsername.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainUsername.ForeColor = Color.White;
            MainUsername.Location = new Point(25, 643);
            MainUsername.Name = "MainUsername";
            MainUsername.Size = new Size(195, 20);
            MainUsername.TabIndex = 0;
            MainUsername.Text = "megakrutyfgfo@mail.ru";
            // 
            // ClientFlowLayout
            // 
            ClientFlowLayout.AutoScroll = true;
            ClientFlowLayout.FlowDirection = FlowDirection.TopDown;
            ClientFlowLayout.Location = new Point(268, 75);
            ClientFlowLayout.Margin = new Padding(0);
            ClientFlowLayout.Name = "ClientFlowLayout";
            ClientFlowLayout.Size = new Size(1019, 624);
            ClientFlowLayout.TabIndex = 2;
            // 
            // ClientsNameFilter
            // 
            ClientsNameFilter.FormattingEnabled = true;
            ClientsNameFilter.Location = new Point(317, 40);
            ClientsNameFilter.Name = "ClientsNameFilter";
            ClientsNameFilter.Size = new Size(157, 23);
            ClientsNameFilter.TabIndex = 3;
            // 
            // ClientsContractFilter
            // 
            ClientsContractFilter.FormattingEnabled = true;
            ClientsContractFilter.Location = new Point(868, 40);
            ClientsContractFilter.Name = "ClientsContractFilter";
            ClientsContractFilter.Size = new Size(157, 23);
            ClientsContractFilter.TabIndex = 4;
            // 
            // ClientsDeviceFilter
            // 
            ClientsDeviceFilter.FormattingEnabled = true;
            ClientsDeviceFilter.Location = new Point(1058, 40);
            ClientsDeviceFilter.Name = "ClientsDeviceFilter";
            ClientsDeviceFilter.Size = new Size(157, 23);
            ClientsDeviceFilter.TabIndex = 5;
            // 
            // ClientsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClientsDeviceFilter);
            Controls.Add(ClientsContractFilter);
            Controls.Add(ClientsNameFilter);
            Controls.Add(ClientFlowLayout);
            Controls.Add(panel1);
            Name = "ClientsPage";
            Size = new Size(1298, 711);
            Load += ClientsPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            NavbarClientsBg.ResumeLayout(false);
            NavbarClientsBg.PerformLayout();
            NavbarTableBg.ResumeLayout(false);
            NavbarTableBg.PerformLayout();
            NavbarDevicesBg.ResumeLayout(false);
            NavbarDevicesBg.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button MainExitButton;
        private Panel NavbarClientsBg;
        private Label label4;
        private Panel NavbarTableBg;
        private Label label3;
        private Panel NavbarDevicesBg;
        private Label label2;
        private Label label1;
        private Label MainUsername;
        private FlowLayoutPanel ClientFlowLayout;
        private ComboBox ClientsNameFilter;
        private ComboBox ClientsContractFilter;
        private ComboBox ClientsDeviceFilter;
    }
}
