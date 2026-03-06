namespace up_network
{
    partial class MainPage
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
            MainRoleText = new Label();
            MainExitButton = new Button();
            NavbarClientsBg = new Panel();
            label4 = new Label();
            NavbarTableBg = new Panel();
            label3 = new Label();
            NavbarDevicesBg = new Panel();
            label2 = new Label();
            label1 = new Label();
            MainUsername = new Label();
            MainFlowLayout = new FlowLayoutPanel();
            MainFilterBox = new ComboBox();
            label5 = new Label();
            MainAddBtn = new Button();
            panel1.SuspendLayout();
            NavbarClientsBg.SuspendLayout();
            NavbarTableBg.SuspendLayout();
            NavbarDevicesBg.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 171, 251);
            panel1.Controls.Add(MainRoleText);
            panel1.Controls.Add(MainExitButton);
            panel1.Controls.Add(NavbarClientsBg);
            panel1.Controls.Add(NavbarTableBg);
            panel1.Controls.Add(NavbarDevicesBg);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MainUsername);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 711);
            panel1.TabIndex = 0;
            // 
            // MainRoleText
            // 
            MainRoleText.AutoSize = true;
            MainRoleText.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainRoleText.ForeColor = Color.White;
            MainRoleText.Location = new Point(25, 633);
            MainRoleText.Name = "MainRoleText";
            MainRoleText.Size = new Size(129, 20);
            MainRoleText.TabIndex = 7;
            MainRoleText.Text = "(Administrator)";
            // 
            // MainExitButton
            // 
            MainExitButton.Font = new Font("Geometria", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainExitButton.Location = new Point(25, 667);
            MainExitButton.Name = "MainExitButton";
            MainExitButton.Size = new Size(195, 32);
            MainExitButton.TabIndex = 6;
            MainExitButton.Text = "Выход";
            MainExitButton.UseVisualStyleBackColor = true;
            MainExitButton.Click += MainExitButton_Click;
            // 
            // NavbarClientsBg
            // 
            NavbarClientsBg.BackColor = Color.FromArgb(100, 171, 251);
            NavbarClientsBg.Controls.Add(label4);
            NavbarClientsBg.Location = new Point(0, 324);
            NavbarClientsBg.Name = "NavbarClientsBg";
            NavbarClientsBg.Size = new Size(262, 70);
            NavbarClientsBg.TabIndex = 5;
            NavbarClientsBg.Click += NavbarClientsBg_Click;
            NavbarClientsBg.MouseLeave += NavbarClientsBg_MouseLeave;
            NavbarClientsBg.MouseHover += NavbarClientsBg_MouseHover;
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
            label4.Click += NavbarClientsBg_Click;
            label4.MouseLeave += NavbarTableBg_MouseLeave;
            label4.MouseHover += NavbarClientsBg_MouseHover;
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
            NavbarDevicesBg.BackColor = Color.FromArgb(35, 137, 250);
            NavbarDevicesBg.Controls.Add(label2);
            NavbarDevicesBg.Location = new Point(0, 184);
            NavbarDevicesBg.Name = "NavbarDevicesBg";
            NavbarDevicesBg.Size = new Size(262, 70);
            NavbarDevicesBg.TabIndex = 2;
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
            MainUsername.Location = new Point(25, 600);
            MainUsername.Name = "MainUsername";
            MainUsername.Size = new Size(195, 20);
            MainUsername.TabIndex = 0;
            MainUsername.Text = "megakrutyfgfo@mail.ru";
            // 
            // MainFlowLayout
            // 
            MainFlowLayout.AutoScroll = true;
            MainFlowLayout.Location = new Point(265, 85);
            MainFlowLayout.Margin = new Padding(5);
            MainFlowLayout.Name = "MainFlowLayout";
            MainFlowLayout.Padding = new Padding(10);
            MainFlowLayout.Size = new Size(1033, 626);
            MainFlowLayout.TabIndex = 1;
            // 
            // MainFilterBox
            // 
            MainFilterBox.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainFilterBox.FormattingEnabled = true;
            MainFilterBox.Location = new Point(391, 42);
            MainFilterBox.Name = "MainFilterBox";
            MainFilterBox.Size = new Size(192, 28);
            MainFilterBox.TabIndex = 2;
            MainFilterBox.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Geometria", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(265, 45);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 3;
            label5.Text = "Фильтровать:";
            label5.Visible = false;
            // 
            // MainAddBtn
            // 
            MainAddBtn.Font = new Font("Geometria", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainAddBtn.Location = new Point(1037, 37);
            MainAddBtn.Name = "MainAddBtn";
            MainAddBtn.Size = new Size(233, 28);
            MainAddBtn.TabIndex = 4;
            MainAddBtn.Text = "Добавить устройство";
            MainAddBtn.UseVisualStyleBackColor = true;
            MainAddBtn.Visible = false;
            MainAddBtn.Click += MainAddBtn_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainAddBtn);
            Controls.Add(label5);
            Controls.Add(MainFilterBox);
            Controls.Add(MainFlowLayout);
            Controls.Add(panel1);
            Name = "MainPage";
            Size = new Size(1298, 711);
            Load += MainPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            NavbarClientsBg.ResumeLayout(false);
            NavbarClientsBg.PerformLayout();
            NavbarTableBg.ResumeLayout(false);
            NavbarTableBg.PerformLayout();
            NavbarDevicesBg.ResumeLayout(false);
            NavbarDevicesBg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label MainUsername;
        private Label label1;
        private Panel NavbarDevicesBg;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel NavbarTableBg;
        private Panel NavbarClientsBg;
        private FlowLayoutPanel MainFlowLayout;
        private Button MainExitButton;
        private ComboBox MainFilterBox;
        private Label label5;
        private Button MainAddBtn;
        private Label MainRoleText;
    }
}
