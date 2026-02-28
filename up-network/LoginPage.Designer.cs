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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geometria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 187);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 0;
            label1.Text = "Вход в аккаунт";
            // 
            // LoginLoginBox
            // 
            LoginLoginBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginLoginBox.Location = new Point(364, 244);
            LoginLoginBox.Multiline = true;
            LoginLoginBox.Name = "LoginLoginBox";
            LoginLoginBox.PlaceholderText = "Логин";
            LoginLoginBox.Size = new Size(306, 33);
            LoginLoginBox.TabIndex = 1;
            // 
            // LoginPasswordBox
            // 
            LoginPasswordBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginPasswordBox.Location = new Point(364, 295);
            LoginPasswordBox.Multiline = true;
            LoginPasswordBox.Name = "LoginPasswordBox";
            LoginPasswordBox.PasswordChar = '*';
            LoginPasswordBox.PlaceholderText = "Пароль";
            LoginPasswordBox.Size = new Size(306, 31);
            LoginPasswordBox.TabIndex = 2;
            // 
            // LoginButton
            // 
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginButton.Location = new Point(439, 378);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(152, 31);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LoginButton);
            Controls.Add(LoginPasswordBox);
            Controls.Add(LoginLoginBox);
            Controls.Add(label1);
            Name = "LoginPage";
            Size = new Size(1058, 711);
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LoginLoginBox;
        private TextBox LoginPasswordBox;
        private Button LoginButton;
    }
}
