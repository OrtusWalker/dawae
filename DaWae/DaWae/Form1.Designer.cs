namespace DaWae
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.authPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.signinButton = new System.Windows.Forms.Button();
            this.signinTextPassword = new System.Windows.Forms.TextBox();
            this.signinTextLogin = new System.Windows.Forms.TextBox();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.registerLabelPassword = new System.Windows.Forms.Label();
            this.registerLabelLogin = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerTextPassword = new System.Windows.Forms.TextBox();
            this.registerTextLogin = new System.Windows.Forms.TextBox();
            this.registerLabelPassword2 = new System.Windows.Forms.Label();
            this.registerTextPassword2 = new System.Windows.Forms.TextBox();
            this.registerLabelCaptcha = new System.Windows.Forms.Label();
            this.registerTextCaptcha = new System.Windows.Forms.TextBox();
            this.registerButtonCancel = new System.Windows.Forms.Button();
            this.registerPictureCaptcha = new System.Windows.Forms.PictureBox();
            this.authPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerPictureCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.Color.Transparent;
            this.authPanel.BackgroundImage = global::DaWae.Properties.Resources.background_shadow;
            this.authPanel.Controls.Add(this.label3);
            this.authPanel.Controls.Add(this.label2);
            this.authPanel.Controls.Add(this.label1);
            this.authPanel.Controls.Add(this.signupButton);
            this.authPanel.Controls.Add(this.signinButton);
            this.authPanel.Controls.Add(this.signinTextPassword);
            this.authPanel.Controls.Add(this.signinTextLogin);
            this.authPanel.Location = new System.Drawing.Point(294, 97);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(214, 266);
            this.authPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(45, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(44, 212);
            this.label1.MinimumSize = new System.Drawing.Size(128, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(119, 185);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(52, 23);
            this.signupButton.TabIndex = 2;
            this.signupButton.Text = "Signup";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // signinButton
            // 
            this.signinButton.Location = new System.Drawing.Point(46, 185);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(52, 23);
            this.signinButton.TabIndex = 2;
            this.signinButton.Text = "Signin";
            this.signinButton.UseVisualStyleBackColor = true;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // signinTextPassword
            // 
            this.signinTextPassword.Location = new System.Drawing.Point(47, 150);
            this.signinTextPassword.Name = "signinTextPassword";
            this.signinTextPassword.Size = new System.Drawing.Size(125, 20);
            this.signinTextPassword.TabIndex = 1;
            // 
            // signinTextLogin
            // 
            this.signinTextLogin.Location = new System.Drawing.Point(47, 110);
            this.signinTextLogin.Name = "signinTextLogin";
            this.signinTextLogin.Size = new System.Drawing.Size(125, 20);
            this.signinTextLogin.TabIndex = 0;
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.Transparent;
            this.registerPanel.BackgroundImage = global::DaWae.Properties.Resources.background_shadow;
            this.registerPanel.Controls.Add(this.registerPictureCaptcha);
            this.registerPanel.Controls.Add(this.registerButtonCancel);
            this.registerPanel.Controls.Add(this.registerLabelCaptcha);
            this.registerPanel.Controls.Add(this.registerTextCaptcha);
            this.registerPanel.Controls.Add(this.registerLabelPassword2);
            this.registerPanel.Controls.Add(this.registerTextPassword2);
            this.registerPanel.Controls.Add(this.registerLabelPassword);
            this.registerPanel.Controls.Add(this.registerLabelLogin);
            this.registerPanel.Controls.Add(this.registerButton);
            this.registerPanel.Controls.Add(this.registerTextPassword);
            this.registerPanel.Controls.Add(this.registerTextLogin);
            this.registerPanel.Location = new System.Drawing.Point(524, 97);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(248, 300);
            this.registerPanel.TabIndex = 3;
            this.registerPanel.Visible = false;
            // 
            // registerLabelPassword
            // 
            this.registerLabelPassword.AutoSize = true;
            this.registerLabelPassword.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.registerLabelPassword.Location = new System.Drawing.Point(66, 63);
            this.registerLabelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLabelPassword.Name = "registerLabelPassword";
            this.registerLabelPassword.Size = new System.Drawing.Size(56, 13);
            this.registerLabelPassword.TabIndex = 5;
            this.registerLabelPassword.Text = "Password:";
            // 
            // registerLabelLogin
            // 
            this.registerLabelLogin.AutoSize = true;
            this.registerLabelLogin.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.registerLabelLogin.Location = new System.Drawing.Point(66, 23);
            this.registerLabelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLabelLogin.Name = "registerLabelLogin";
            this.registerLabelLogin.Size = new System.Drawing.Size(36, 13);
            this.registerLabelLogin.TabIndex = 4;
            this.registerLabelLogin.Text = "Login:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(154, 264);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(62, 23);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerTextPassword
            // 
            this.registerTextPassword.Location = new System.Drawing.Point(68, 80);
            this.registerTextPassword.Name = "registerTextPassword";
            this.registerTextPassword.Size = new System.Drawing.Size(125, 20);
            this.registerTextPassword.TabIndex = 1;
            // 
            // registerTextLogin
            // 
            this.registerTextLogin.Location = new System.Drawing.Point(68, 40);
            this.registerTextLogin.Name = "registerTextLogin";
            this.registerTextLogin.Size = new System.Drawing.Size(125, 20);
            this.registerTextLogin.TabIndex = 0;
            // 
            // registerLabelPassword2
            // 
            this.registerLabelPassword2.AutoSize = true;
            this.registerLabelPassword2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.registerLabelPassword2.Location = new System.Drawing.Point(66, 103);
            this.registerLabelPassword2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLabelPassword2.Name = "registerLabelPassword2";
            this.registerLabelPassword2.Size = new System.Drawing.Size(93, 13);
            this.registerLabelPassword2.TabIndex = 7;
            this.registerLabelPassword2.Text = "Confirm password:";
            // 
            // registerTextPassword2
            // 
            this.registerTextPassword2.Location = new System.Drawing.Point(68, 120);
            this.registerTextPassword2.Name = "registerTextPassword2";
            this.registerTextPassword2.Size = new System.Drawing.Size(125, 20);
            this.registerTextPassword2.TabIndex = 6;
            // 
            // registerLabelCaptcha
            // 
            this.registerLabelCaptcha.AutoSize = true;
            this.registerLabelCaptcha.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.registerLabelCaptcha.Location = new System.Drawing.Point(66, 221);
            this.registerLabelCaptcha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLabelCaptcha.Name = "registerLabelCaptcha";
            this.registerLabelCaptcha.Size = new System.Drawing.Size(50, 13);
            this.registerLabelCaptcha.TabIndex = 9;
            this.registerLabelCaptcha.Text = "Captcha:";
            // 
            // registerTextCaptcha
            // 
            this.registerTextCaptcha.Location = new System.Drawing.Point(68, 238);
            this.registerTextCaptcha.Name = "registerTextCaptcha";
            this.registerTextCaptcha.Size = new System.Drawing.Size(125, 20);
            this.registerTextCaptcha.TabIndex = 8;
            // 
            // registerButtonCancel
            // 
            this.registerButtonCancel.Location = new System.Drawing.Point(40, 264);
            this.registerButtonCancel.Name = "registerButtonCancel";
            this.registerButtonCancel.Size = new System.Drawing.Size(62, 23);
            this.registerButtonCancel.TabIndex = 10;
            this.registerButtonCancel.Text = "Cancel";
            this.registerButtonCancel.UseVisualStyleBackColor = true;
            this.registerButtonCancel.Click += new System.EventHandler(this.registerButtonCancel_Click);
            // 
            // registerPictureCaptcha
            // 
            this.registerPictureCaptcha.Location = new System.Drawing.Point(59, 150);
            this.registerPictureCaptcha.Name = "registerPictureCaptcha";
            this.registerPictureCaptcha.Size = new System.Drawing.Size(143, 68);
            this.registerPictureCaptcha.TabIndex = 11;
            this.registerPictureCaptcha.TabStop = false;
            this.registerPictureCaptcha.Click += new System.EventHandler(this.registerPictureCaptcha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::DaWae.Properties.Resources.background_mainmenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.authPanel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "DaWae";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerPictureCaptcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.TextBox signinTextPassword;
        private System.Windows.Forms.TextBox signinTextLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Label registerLabelCaptcha;
        private System.Windows.Forms.TextBox registerTextCaptcha;
        private System.Windows.Forms.Label registerLabelPassword2;
        private System.Windows.Forms.TextBox registerTextPassword2;
        private System.Windows.Forms.Label registerLabelPassword;
        private System.Windows.Forms.Label registerLabelLogin;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox registerTextPassword;
        private System.Windows.Forms.TextBox registerTextLogin;
        private System.Windows.Forms.Button registerButtonCancel;
        private System.Windows.Forms.PictureBox registerPictureCaptcha;
    }
}

