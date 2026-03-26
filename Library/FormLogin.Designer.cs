namespace Library
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonGuest = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(264, 118);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(52, 19);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(264, 227);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(58, 19);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(169, 169);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(246, 26);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(169, 278);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(246, 26);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(74, 111, 165);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Location = new Point(215, 336);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(148, 44);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // buttonGuest
            // 
            buttonGuest.BackColor = Color.FromArgb(74, 111, 165);
            buttonGuest.FlatStyle = FlatStyle.Flat;
            buttonGuest.Location = new Point(215, 410);
            buttonGuest.Name = "buttonGuest";
            buttonGuest.Size = new Size(148, 48);
            buttonGuest.TabIndex = 5;
            buttonGuest.Text = "Гость";
            buttonGuest.UseVisualStyleBackColor = false;
            buttonGuest.Click += ButtonGuest_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 561);
            Controls.Add(buttonGuest);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonGuest;
    }
}
