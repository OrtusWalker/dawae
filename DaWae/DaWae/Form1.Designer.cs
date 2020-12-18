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
            this.components = new System.ComponentModel.Container();
            this.authPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.signinPictureLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.signinButton = new System.Windows.Forms.Button();
            this.signinTextPassword = new System.Windows.Forms.TextBox();
            this.signinTextLogin = new System.Windows.Forms.TextBox();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.registerPictureCaptcha = new System.Windows.Forms.PictureBox();
            this.registerButtonCancel = new System.Windows.Forms.Button();
            this.registerLabelCaptcha = new System.Windows.Forms.Label();
            this.registerTextCaptcha = new System.Windows.Forms.TextBox();
            this.registerLabelPassword2 = new System.Windows.Forms.Label();
            this.registerTextPassword2 = new System.Windows.Forms.TextBox();
            this.registerLabelPassword = new System.Windows.Forms.Label();
            this.registerLabelLogin = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerTextPassword = new System.Windows.Forms.TextBox();
            this.registerTextLogin = new System.Windows.Forms.TextBox();
            this.personalAccountPanel = new System.Windows.Forms.Panel();
            this.ugandanChatTextMessage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ugandanChatGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ugandanChatLabelChat = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.personalAccountLabel5 = new System.Windows.Forms.Label();
            this.personalAccountLabel4 = new System.Windows.Forms.Label();
            this.personalAccountLabel3 = new System.Windows.Forms.Label();
            this.personalAccountLabel2 = new System.Windows.Forms.Label();
            this.personalAccountLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.personalAccountButtonChangeAvatar = new System.Windows.Forms.Button();
            this.personalAccountPictureAvatar = new System.Windows.Forms.PictureBox();
            this.personalAccountLabelNickname = new System.Windows.Forms.Label();
            this.FormBlack = new System.Windows.Forms.PictureBox();
            this.chatReloader = new System.Windows.Forms.Timer(this.components);
            this.authPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signinPictureLogo)).BeginInit();
            this.registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerPictureCaptcha)).BeginInit();
            this.personalAccountPanel.SuspendLayout();
            this.ugandanChatGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalAccountPictureAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.Color.Transparent;
            this.authPanel.BackgroundImage = global::DaWae.Properties.Resources.background_shadow;
            this.authPanel.Controls.Add(this.checkBox1);
            this.authPanel.Controls.Add(this.signinPictureLogo);
            this.authPanel.Controls.Add(this.label3);
            this.authPanel.Controls.Add(this.label2);
            this.authPanel.Controls.Add(this.label1);
            this.authPanel.Controls.Add(this.signupButton);
            this.authPanel.Controls.Add(this.signinButton);
            this.authPanel.Controls.Add(this.signinTextPassword);
            this.authPanel.Controls.Add(this.signinTextLogin);
            this.authPanel.Location = new System.Drawing.Point(624, 158);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(214, 266);
            this.authPanel.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(73, 223);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Remind me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // signinPictureLogo
            // 
            this.signinPictureLogo.Image = global::DaWae.Properties.Resources.shirt_1516110388_f933f4e085414d8c606fa0a9b0a6f164;
            this.signinPictureLogo.Location = new System.Drawing.Point(47, 11);
            this.signinPictureLogo.Name = "signinPictureLogo";
            this.signinPictureLogo.Size = new System.Drawing.Size(124, 79);
            this.signinPictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.signinPictureLogo.TabIndex = 6;
            this.signinPictureLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
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
            this.signupButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.signupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.Location = new System.Drawing.Point(114, 185);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(57, 23);
            this.signupButton.TabIndex = 2;
            this.signupButton.Text = "Signup";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // signinButton
            // 
            this.signinButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.signinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.signinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signinButton.ForeColor = System.Drawing.Color.White;
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
            this.signinTextPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signinTextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signinTextPassword.Location = new System.Drawing.Point(47, 150);
            this.signinTextPassword.MaxLength = 64;
            this.signinTextPassword.Name = "signinTextPassword";
            this.signinTextPassword.PasswordChar = '*';
            this.signinTextPassword.Size = new System.Drawing.Size(125, 21);
            this.signinTextPassword.TabIndex = 1;
            // 
            // signinTextLogin
            // 
            this.signinTextLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signinTextLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signinTextLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.signinTextLogin.Location = new System.Drawing.Point(47, 110);
            this.signinTextLogin.MaxLength = 32;
            this.signinTextLogin.Name = "signinTextLogin";
            this.signinTextLogin.Size = new System.Drawing.Size(125, 21);
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
            this.registerPanel.Location = new System.Drawing.Point(697, 29);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(248, 300);
            this.registerPanel.TabIndex = 3;
            this.registerPanel.Visible = false;
            // 
            // registerPictureCaptcha
            // 
            this.registerPictureCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.registerPictureCaptcha.Location = new System.Drawing.Point(59, 150);
            this.registerPictureCaptcha.Name = "registerPictureCaptcha";
            this.registerPictureCaptcha.Size = new System.Drawing.Size(143, 68);
            this.registerPictureCaptcha.TabIndex = 11;
            this.registerPictureCaptcha.TabStop = false;
            this.registerPictureCaptcha.Click += new System.EventHandler(this.registerPictureCaptcha_Click);
            // 
            // registerButtonCancel
            // 
            this.registerButtonCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.registerButtonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.registerButtonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.registerButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButtonCancel.ForeColor = System.Drawing.Color.White;
            this.registerButtonCancel.Location = new System.Drawing.Point(40, 264);
            this.registerButtonCancel.Name = "registerButtonCancel";
            this.registerButtonCancel.Size = new System.Drawing.Size(62, 23);
            this.registerButtonCancel.TabIndex = 10;
            this.registerButtonCancel.Text = "Cancel";
            this.registerButtonCancel.UseVisualStyleBackColor = true;
            this.registerButtonCancel.Click += new System.EventHandler(this.registerButtonCancel_Click);
            // 
            // registerLabelCaptcha
            // 
            this.registerLabelCaptcha.AutoSize = true;
            this.registerLabelCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.registerLabelCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabelCaptcha.ForeColor = System.Drawing.Color.White;
            this.registerLabelCaptcha.Location = new System.Drawing.Point(66, 221);
            this.registerLabelCaptcha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLabelCaptcha.Name = "registerLabelCaptcha";
            this.registerLabelCaptcha.Size = new System.Drawing.Size(58, 13);
            this.registerLabelCaptcha.TabIndex = 9;
            this.registerLabelCaptcha.Text = "Captcha:";
            // 
            // registerTextCaptcha
            // 
            this.registerTextCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerTextCaptcha.Location = new System.Drawing.Point(68, 238);
            this.registerTextCaptcha.MaxLength = 8;
            this.registerTextCaptcha.Name = "registerTextCaptcha";
            this.registerTextCaptcha.Size = new System.Drawing.Size(125, 21);
            this.registerTextCaptcha.TabIndex = 8;
            // 
            // registerLabelPassword2
            // 
            this.registerLabelPassword2.AutoSize = true;
            this.registerLabelPassword2.BackColor = System.Drawing.Color.Transparent;
            this.registerLabelPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabelPassword2.ForeColor = System.Drawing.Color.White;
            this.registerLabelPassword2.Location = new System.Drawing.Point(66, 103);
            this.registerLabelPassword2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLabelPassword2.Name = "registerLabelPassword2";
            this.registerLabelPassword2.Size = new System.Drawing.Size(110, 13);
            this.registerLabelPassword2.TabIndex = 7;
            this.registerLabelPassword2.Text = "Confirm password:";
            // 
            // registerTextPassword2
            // 
            this.registerTextPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerTextPassword2.Location = new System.Drawing.Point(68, 120);
            this.registerTextPassword2.MaxLength = 64;
            this.registerTextPassword2.Name = "registerTextPassword2";
            this.registerTextPassword2.PasswordChar = '*';
            this.registerTextPassword2.Size = new System.Drawing.Size(125, 21);
            this.registerTextPassword2.TabIndex = 6;
            // 
            // registerLabelPassword
            // 
            this.registerLabelPassword.AutoSize = true;
            this.registerLabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.registerLabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabelPassword.ForeColor = System.Drawing.Color.White;
            this.registerLabelPassword.Location = new System.Drawing.Point(66, 63);
            this.registerLabelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLabelPassword.Name = "registerLabelPassword";
            this.registerLabelPassword.Size = new System.Drawing.Size(65, 13);
            this.registerLabelPassword.TabIndex = 5;
            this.registerLabelPassword.Text = "Password:";
            // 
            // registerLabelLogin
            // 
            this.registerLabelLogin.AutoSize = true;
            this.registerLabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.registerLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabelLogin.ForeColor = System.Drawing.Color.White;
            this.registerLabelLogin.Location = new System.Drawing.Point(66, 23);
            this.registerLabelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLabelLogin.Name = "registerLabelLogin";
            this.registerLabelLogin.Size = new System.Drawing.Size(42, 13);
            this.registerLabelLogin.TabIndex = 4;
            this.registerLabelLogin.Text = "Login:";
            // 
            // registerButton
            // 
            this.registerButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
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
            this.registerTextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerTextPassword.Location = new System.Drawing.Point(68, 80);
            this.registerTextPassword.MaxLength = 64;
            this.registerTextPassword.Name = "registerTextPassword";
            this.registerTextPassword.PasswordChar = '*';
            this.registerTextPassword.Size = new System.Drawing.Size(125, 21);
            this.registerTextPassword.TabIndex = 1;
            // 
            // registerTextLogin
            // 
            this.registerTextLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerTextLogin.Location = new System.Drawing.Point(68, 40);
            this.registerTextLogin.MaxLength = 32;
            this.registerTextLogin.Name = "registerTextLogin";
            this.registerTextLogin.Size = new System.Drawing.Size(125, 21);
            this.registerTextLogin.TabIndex = 0;
            // 
            // personalAccountPanel
            // 
            this.personalAccountPanel.BackColor = System.Drawing.Color.Transparent;
            this.personalAccountPanel.BackgroundImage = global::DaWae.Properties.Resources.background_shadow;
            this.personalAccountPanel.Controls.Add(this.ugandanChatTextMessage);
            this.personalAccountPanel.Controls.Add(this.button2);
            this.personalAccountPanel.Controls.Add(this.ugandanChatGroupBox);
            this.personalAccountPanel.Controls.Add(this.personalAccountLabel5);
            this.personalAccountPanel.Controls.Add(this.personalAccountLabel4);
            this.personalAccountPanel.Controls.Add(this.personalAccountLabel3);
            this.personalAccountPanel.Controls.Add(this.personalAccountLabel2);
            this.personalAccountPanel.Controls.Add(this.personalAccountLabel1);
            this.personalAccountPanel.Controls.Add(this.button1);
            this.personalAccountPanel.Controls.Add(this.personalAccountButtonChangeAvatar);
            this.personalAccountPanel.Controls.Add(this.personalAccountPictureAvatar);
            this.personalAccountPanel.Controls.Add(this.personalAccountLabelNickname);
            this.personalAccountPanel.Location = new System.Drawing.Point(56, 69);
            this.personalAccountPanel.Name = "personalAccountPanel";
            this.personalAccountPanel.Size = new System.Drawing.Size(650, 350);
            this.personalAccountPanel.TabIndex = 4;
            this.personalAccountPanel.Visible = false;
            // 
            // ugandanChatTextMessage
            // 
            this.ugandanChatTextMessage.Location = new System.Drawing.Point(338, 248);
            this.ugandanChatTextMessage.MaxLength = 128;
            this.ugandanChatTextMessage.Name = "ugandanChatTextMessage";
            this.ugandanChatTextMessage.Size = new System.Drawing.Size(243, 20);
            this.ugandanChatTextMessage.TabIndex = 10;
            this.ugandanChatTextMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ugandanChatTextMessage_KeyDown);
            // 
            // button2
            // 
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(587, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 21);
            this.button2.TabIndex = 9;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ugandanChatGroupBox
            // 
            this.ugandanChatGroupBox.Controls.Add(this.panel1);
            this.ugandanChatGroupBox.Controls.Add(this.vScrollBar1);
            this.ugandanChatGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ugandanChatGroupBox.ForeColor = System.Drawing.Color.White;
            this.ugandanChatGroupBox.Location = new System.Drawing.Point(338, 40);
            this.ugandanChatGroupBox.Name = "ugandanChatGroupBox";
            this.ugandanChatGroupBox.Size = new System.Drawing.Size(297, 207);
            this.ugandanChatGroupBox.TabIndex = 8;
            this.ugandanChatGroupBox.TabStop = false;
            this.ugandanChatGroupBox.Text = "Ugandan Chat";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ugandanChatLabelChat);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 182);
            this.panel1.TabIndex = 3;
            // 
            // ugandanChatLabelChat
            // 
            this.ugandanChatLabelChat.AutoEllipsis = true;
            this.ugandanChatLabelChat.AutoSize = true;
            this.ugandanChatLabelChat.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ugandanChatLabelChat.Location = new System.Drawing.Point(3, 4);
            this.ugandanChatLabelChat.MaximumSize = new System.Drawing.Size(260, 0);
            this.ugandanChatLabelChat.MinimumSize = new System.Drawing.Size(32, 16);
            this.ugandanChatLabelChat.Name = "ugandanChatLabelChat";
            this.ugandanChatLabelChat.Size = new System.Drawing.Size(32, 16);
            this.ugandanChatLabelChat.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 2;
            this.vScrollBar1.Location = new System.Drawing.Point(278, 20);
            this.vScrollBar1.Maximum = 1;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 181);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // personalAccountLabel5
            // 
            this.personalAccountLabel5.AutoSize = true;
            this.personalAccountLabel5.BackColor = System.Drawing.Color.Transparent;
            this.personalAccountLabel5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalAccountLabel5.ForeColor = System.Drawing.Color.White;
            this.personalAccountLabel5.Location = new System.Drawing.Point(157, 114);
            this.personalAccountLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.personalAccountLabel5.Name = "personalAccountLabel5";
            this.personalAccountLabel5.Size = new System.Drawing.Size(70, 20);
            this.personalAccountLabel5.TabIndex = 7;
            this.personalAccountLabel5.Text = "Some info";
            // 
            // personalAccountLabel4
            // 
            this.personalAccountLabel4.AutoSize = true;
            this.personalAccountLabel4.BackColor = System.Drawing.Color.Transparent;
            this.personalAccountLabel4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalAccountLabel4.ForeColor = System.Drawing.Color.White;
            this.personalAccountLabel4.Location = new System.Drawing.Point(157, 96);
            this.personalAccountLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.personalAccountLabel4.Name = "personalAccountLabel4";
            this.personalAccountLabel4.Size = new System.Drawing.Size(70, 20);
            this.personalAccountLabel4.TabIndex = 7;
            this.personalAccountLabel4.Text = "Some info";
            // 
            // personalAccountLabel3
            // 
            this.personalAccountLabel3.AutoSize = true;
            this.personalAccountLabel3.BackColor = System.Drawing.Color.Transparent;
            this.personalAccountLabel3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalAccountLabel3.ForeColor = System.Drawing.Color.White;
            this.personalAccountLabel3.Location = new System.Drawing.Point(157, 78);
            this.personalAccountLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.personalAccountLabel3.Name = "personalAccountLabel3";
            this.personalAccountLabel3.Size = new System.Drawing.Size(70, 20);
            this.personalAccountLabel3.TabIndex = 7;
            this.personalAccountLabel3.Text = "Some info";
            // 
            // personalAccountLabel2
            // 
            this.personalAccountLabel2.AutoSize = true;
            this.personalAccountLabel2.BackColor = System.Drawing.Color.Transparent;
            this.personalAccountLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalAccountLabel2.ForeColor = System.Drawing.Color.White;
            this.personalAccountLabel2.Location = new System.Drawing.Point(157, 60);
            this.personalAccountLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.personalAccountLabel2.Name = "personalAccountLabel2";
            this.personalAccountLabel2.Size = new System.Drawing.Size(70, 20);
            this.personalAccountLabel2.TabIndex = 7;
            this.personalAccountLabel2.Text = "Some info";
            // 
            // personalAccountLabel1
            // 
            this.personalAccountLabel1.AutoSize = true;
            this.personalAccountLabel1.BackColor = System.Drawing.Color.Transparent;
            this.personalAccountLabel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalAccountLabel1.ForeColor = System.Drawing.Color.White;
            this.personalAccountLabel1.Location = new System.Drawing.Point(157, 42);
            this.personalAccountLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.personalAccountLabel1.Name = "personalAccountLabel1";
            this.personalAccountLabel1.Size = new System.Drawing.Size(70, 20);
            this.personalAccountLabel1.TabIndex = 7;
            this.personalAccountLabel1.Text = "Some info";
            // 
            // button1
            // 
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(271, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Connect da game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // personalAccountButtonChangeAvatar
            // 
            this.personalAccountButtonChangeAvatar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.personalAccountButtonChangeAvatar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.personalAccountButtonChangeAvatar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.personalAccountButtonChangeAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalAccountButtonChangeAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalAccountButtonChangeAvatar.ForeColor = System.Drawing.Color.White;
            this.personalAccountButtonChangeAvatar.Location = new System.Drawing.Point(24, 174);
            this.personalAccountButtonChangeAvatar.Name = "personalAccountButtonChangeAvatar";
            this.personalAccountButtonChangeAvatar.Size = new System.Drawing.Size(128, 23);
            this.personalAccountButtonChangeAvatar.TabIndex = 6;
            this.personalAccountButtonChangeAvatar.Text = "Change avatar";
            this.personalAccountButtonChangeAvatar.UseVisualStyleBackColor = true;
            this.personalAccountButtonChangeAvatar.Click += new System.EventHandler(this.personalAccountButtonChangeAvatar_Click);
            // 
            // personalAccountPictureAvatar
            // 
            this.personalAccountPictureAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personalAccountPictureAvatar.Location = new System.Drawing.Point(24, 40);
            this.personalAccountPictureAvatar.Name = "personalAccountPictureAvatar";
            this.personalAccountPictureAvatar.Size = new System.Drawing.Size(128, 128);
            this.personalAccountPictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personalAccountPictureAvatar.TabIndex = 5;
            this.personalAccountPictureAvatar.TabStop = false;
            // 
            // personalAccountLabelNickname
            // 
            this.personalAccountLabelNickname.AutoSize = true;
            this.personalAccountLabelNickname.BackColor = System.Drawing.Color.Transparent;
            this.personalAccountLabelNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalAccountLabelNickname.ForeColor = System.Drawing.Color.White;
            this.personalAccountLabelNickname.Location = new System.Drawing.Point(45, 11);
            this.personalAccountLabelNickname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.personalAccountLabelNickname.Name = "personalAccountLabelNickname";
            this.personalAccountLabelNickname.Size = new System.Drawing.Size(245, 20);
            this.personalAccountLabelNickname.TabIndex = 4;
            this.personalAccountLabelNickname.Text = "Welcom commando nickname";
            // 
            // FormBlack
            // 
            this.FormBlack.BackColor = System.Drawing.Color.Black;
            this.FormBlack.Location = new System.Drawing.Point(0, 0);
            this.FormBlack.Name = "FormBlack";
            this.FormBlack.Size = new System.Drawing.Size(36, 30);
            this.FormBlack.TabIndex = 5;
            this.FormBlack.TabStop = false;
            this.FormBlack.Visible = false;
            // 
            // chatReloader
            // 
            this.chatReloader.Interval = 5000;
            this.chatReloader.Tick += new System.EventHandler(this.chatReloader_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DaWae.Properties.Resources.background_mainmenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.FormBlack);
            this.Controls.Add(this.personalAccountPanel);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.authPanel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "DaWae";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signinPictureLogo)).EndInit();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerPictureCaptcha)).EndInit();
            this.personalAccountPanel.ResumeLayout(false);
            this.personalAccountPanel.PerformLayout();
            this.ugandanChatGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalAccountPictureAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormBlack)).EndInit();
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
        private System.Windows.Forms.Panel personalAccountPanel;
        private System.Windows.Forms.Label personalAccountLabelNickname;
        private System.Windows.Forms.PictureBox signinPictureLogo;
        private System.Windows.Forms.PictureBox FormBlack;
        private System.Windows.Forms.PictureBox personalAccountPictureAvatar;
        private System.Windows.Forms.Button personalAccountButtonChangeAvatar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label personalAccountLabel5;
        private System.Windows.Forms.Label personalAccountLabel4;
        private System.Windows.Forms.Label personalAccountLabel3;
        private System.Windows.Forms.Label personalAccountLabel2;
        private System.Windows.Forms.Label personalAccountLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox ugandanChatGroupBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox ugandanChatTextMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ugandanChatLabelChat;
        private System.Windows.Forms.Timer chatReloader;
    }
}

