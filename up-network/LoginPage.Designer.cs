namespace up_network
{
    partial class LoginPage
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
            label1 = new Label();
            LoginLoginBox = new TextBox();
            LoginPasswordBox = new TextBox();
            LoginButton = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geometria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 35);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 0;
            label1.Text = "Вход в аккаунт";
            // 
            // LoginLoginBox
            // 
            LoginLoginBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginLoginBox.Location = new Point(128, 262);
            LoginLoginBox.Multiline = true;
            LoginLoginBox.Name = "LoginLoginBox";
            LoginLoginBox.PlaceholderText = "Логин";
            LoginLoginBox.Size = new Size(306, 33);
            LoginLoginBox.TabIndex = 1;
            // 
            // LoginPasswordBox
            // 
            LoginPasswordBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginPasswordBox.Location = new Point(128, 319);
            LoginPasswordBox.Multiline = true;
            LoginPasswordBox.Name = "LoginPasswordBox";
            LoginPasswordBox.PasswordChar = '*';
            LoginPasswordBox.PlaceholderText = "Пароль";
            LoginPasswordBox.Size = new Size(306, 31);
            LoginPasswordBox.TabIndex = 2;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(100, 171, 251);
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Geometria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginButton.Location = new Point(128, 396);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(306, 36);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 171, 251);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 101);
            panel1.TabIndex = 4;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(LoginButton);
            Controls.Add(LoginPasswordBox);
            Controls.Add(LoginLoginBox);
            Name = "LoginPage";
            Size = new Size(1298, 711);
            Load += LoginPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LoginLoginBox;
        private TextBox LoginPasswordBox;
        private Button LoginButton;
        private Panel panel1;
    }
}
