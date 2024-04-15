namespace PhoneBookMonolit
{
    partial class LoginForm
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
            tb_username = new TextBox();
            tb_password = new TextBox();
            label1 = new Label();
            btn_login = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tb_username.Location = new Point(331, 51);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(371, 44);
            tb_username.TabIndex = 0;
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tb_password.Location = new Point(331, 101);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(371, 44);
            tb_password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 51);
            label1.Name = "label1";
            label1.Size = new Size(157, 61);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(520, 151);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(182, 51);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 176);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 4;
            label2.Text = "login er : admin / pass";
            // 
            // LoginForm
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 224);
            Controls.Add(label2);
            Controls.Add(btn_login);
            Controls.Add(label1);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_username;
        private TextBox tb_password;
        private Label label1;
        private Button btn_login;
        private Label label2;
    }
}