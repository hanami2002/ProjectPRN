namespace WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Info;
            this.txtUserName.Location = new System.Drawing.Point(296, 160);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "User Name";
            this.txtUserName.Size = new System.Drawing.Size(195, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Tag = "";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(296, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(195, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Tag = "";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(512, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("VNI 22 JackieO", 57F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.IndianRed;
            this.lbName.Location = new System.Drawing.Point(150, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(453, 89);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Hanami Food";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Location = new System.Drawing.Point(217, 163);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(65, 15);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "UserName:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Location = new System.Drawing.Point(222, 207);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(60, 15);
            this.lbPass.TabIndex = 5;
            this.lbPass.Text = "Password:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 418);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lbName;
        private Label lbUser;
        private Label lbPass;
    }
}