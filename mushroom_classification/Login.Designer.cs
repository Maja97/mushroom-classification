namespace mushroom_classification
{
    partial class Login
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
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.label_register = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBoxUsernameLogin = new MetroFramework.Controls.MetroTextBox();
            this.textBoxPasswordLogin = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(255, 282);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(108, 24);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label_register
            // 
            this.label_register.AutoSize = true;
            this.label_register.Location = new System.Drawing.Point(154, 325);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(241, 20);
            this.label_register.TabIndex = 7;
            this.label_register.Text = "Dont have an account? Register here!";
            this.label_register.Click += new System.EventHandler(this.label_register_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(154, 175);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 20);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Username:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(154, 227);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 20);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Password: ";
            // 
            // textBoxUsernameLogin
            // 
            // 
            // 
            // 
            this.textBoxUsernameLogin.CustomButton.Image = null;
            this.textBoxUsernameLogin.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.textBoxUsernameLogin.CustomButton.Name = "";
            this.textBoxUsernameLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxUsernameLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxUsernameLogin.CustomButton.TabIndex = 1;
            this.textBoxUsernameLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxUsernameLogin.CustomButton.UseSelectable = true;
            this.textBoxUsernameLogin.CustomButton.Visible = false;
            this.textBoxUsernameLogin.Lines = new string[0];
            this.textBoxUsernameLogin.Location = new System.Drawing.Point(283, 172);
            this.textBoxUsernameLogin.MaxLength = 32767;
            this.textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            this.textBoxUsernameLogin.PasswordChar = '\0';
            this.textBoxUsernameLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxUsernameLogin.SelectedText = "";
            this.textBoxUsernameLogin.SelectionLength = 0;
            this.textBoxUsernameLogin.SelectionStart = 0;
            this.textBoxUsernameLogin.ShortcutsEnabled = true;
            this.textBoxUsernameLogin.Size = new System.Drawing.Size(179, 23);
            this.textBoxUsernameLogin.TabIndex = 10;
            this.textBoxUsernameLogin.UseSelectable = true;
            this.textBoxUsernameLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxUsernameLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxPasswordLogin
            // 
            // 
            // 
            // 
            this.textBoxPasswordLogin.CustomButton.Image = null;
            this.textBoxPasswordLogin.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.textBoxPasswordLogin.CustomButton.Name = "";
            this.textBoxPasswordLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPasswordLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPasswordLogin.CustomButton.TabIndex = 1;
            this.textBoxPasswordLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPasswordLogin.CustomButton.UseSelectable = true;
            this.textBoxPasswordLogin.CustomButton.Visible = false;
            this.textBoxPasswordLogin.Lines = new string[0];
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(283, 227);
            this.textBoxPasswordLogin.MaxLength = 32767;
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.PasswordChar = '●';
            this.textBoxPasswordLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPasswordLogin.SelectedText = "";
            this.textBoxPasswordLogin.SelectionLength = 0;
            this.textBoxPasswordLogin.SelectionStart = 0;
            this.textBoxPasswordLogin.ShortcutsEnabled = true;
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(179, 23);
            this.textBoxPasswordLogin.TabIndex = 11;
            this.textBoxPasswordLogin.UseSelectable = true;
            this.textBoxPasswordLogin.UseSystemPasswordChar = true;
            this.textBoxPasswordLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPasswordLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.textBoxPasswordLogin);
            this.Controls.Add(this.textBoxUsernameLogin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label_register);
            this.Controls.Add(this.btn_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroLabel label_register;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBoxUsernameLogin;
        private MetroFramework.Controls.MetroTextBox textBoxPasswordLogin;
    }
}