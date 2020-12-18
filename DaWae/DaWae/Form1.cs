using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaWae.Scripts;

namespace DaWae
{
    public partial class Form1 : Form
    {
        string passPhrase = "NSdch8*&Huwli";        //Может быть любой строкой
        string saltValue = "nonsuch20142020";        // Может быть любой строкой
        string initVector = "!1A3g2D4s9K556g7"; // Должно быть 16 байт
        string hashAlgorithm = "SHA256";             // может быть "MD5"
        int passwordIterations = 2;                //Может быть любым числом
        int keySize = 256;                // Может быть 192 или 128
        string keycode = "1f0e539d6abc3b78d945c8d0c078ccdb73160d15c275b2f97352e9da1e6e8509";
        clientserver client = new clientserver();
        lang language = new lang();
        Design design = new Design();
        Functions functions = new Functions();
        FtpClient ftp = new FtpClient();
        string playerNickname, playerPassword, playtime, playerID, playerX, playerY, playerZ, playerWorld, UUID, email, firstlogin, lastlogin, credits;
        string startdate = DateTime.Now.ToString();
        int scrollbarLastValue = 0;

        private void Form1_Shown(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("profile.dat");
            if (fi.Exists)
            {
                using (StreamReader sr = fi.OpenText())
                {
                    playerNickname = sr.ReadLine();
                    playerPassword = sr.ReadLine();
                    if (sr.ReadLine() == "True")
                    {
                        signinTextLogin.Text = playerNickname;

                        signinTextPassword.Text = functions.Decrypt(playerPassword, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);
                        checkBox1.Checked = true;
                    }

                }
            }
            design.centerPanel(ref authPanel, ActiveForm.Height, ActiveForm.Width);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value> vScrollBar1.Value)
            {
                ugandanChatLabelChat.Top -= vScrollBar1.Value;
            }
            else
            {
                //ugandanChatLabelChat.Top += vScrollBar1.Value;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.sendmessage(playerNickname, keycode, ugandanChatTextMessage.Text);
            ugandanChatTextMessage.Clear();
            chatReload();
        }

        private void ugandanChatTextMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                //button2_Click(sender, e);
            }
        }

        private void chatReloader_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        string captcha = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (ActiveForm.Height > 0)
            {
                
                int Height = ActiveForm.Height;
                int Width = ActiveForm.Width;
                design.centerPanel(ref authPanel, Height, Width);
                design.centerPanel(ref registerPanel, Height, Width);
                design.centerPanel(ref personalAccountPanel, Height, Width);
                
            }
            
        }

        private void signupButton_Click(object sender, EventArgs e) //Открыть окно регистрации
        {
            registerPictureCaptcha.Image = design.CreateImage(registerPictureCaptcha.Width, registerPictureCaptcha.Height, ref captcha);
            design.centerPanel(ref registerPanel, ActiveForm.Height, ActiveForm.Width);
            authPanel.Visible = false;
            registerPanel.Visible = true;
        }

        private void registerButton_Click(object sender, EventArgs e) //Регистрация нового аккаунта
        {
            registerLabelLogin.BackColor = Color.Transparent;
            registerLabelPassword.BackColor = Color.Transparent;
            registerLabelPassword2.BackColor = Color.Transparent;
            registerLabelCaptcha.BackColor = Color.Transparent;
            
            bool access = true;
            if (client.nickdupe(registerTextLogin.Text, keycode).Contains("always exists"))
            {
                access = false;
                registerLabelLogin.BackColor = Color.Red;
            }
            if (registerTextLogin.Text.Length < 2)
            {
                access = false;
                registerLabelLogin.BackColor = Color.Red;
            }
            if ((registerTextPassword.Text != registerTextPassword2.Text) || (registerTextPassword.Text.Length<3))
            {
                access = false;
                registerLabelPassword.BackColor = Color.Red;
                registerLabelPassword2.BackColor = Color.Red;
            }
            if (captcha.ToLower() != registerTextCaptcha.Text.ToLower())
            {
                access = false;
                registerLabelCaptcha.BackColor = Color.Red;
            }
            if (!access)
            {
                if (client.register(registerTextLogin.Text, registerTextPassword.Text, keycode).Contains("Successful"))
                {
                    registerLabelLogin.BackColor = Color.Transparent;
                    registerLabelPassword.BackColor = Color.Transparent;
                    registerLabelPassword2.BackColor = Color.Transparent;
                    registerLabelCaptcha.BackColor = Color.Transparent;
                    registerTextCaptcha.Clear();
                    registerTextLogin.Clear();
                    registerTextPassword.Clear();
                    registerTextPassword2.Clear();
                    MessageBox.Show("Registered!");
                }
            }
            else
            {
                
                MessageBox.Show($"Signup denied:\r\n{client.register(registerTextLogin.Text, registerTextPassword.Text, keycode)}");
            }
        }

        private void successfulAuth()
        {
            design.ResetPersonalAccountPanel(ref personalAccountPanel);
            design.centerPanel(ref personalAccountPanel, ActiveForm.Height, ActiveForm.Width);

            personalAccountLabelNickname.Text = $"{language.personalAccountLabelNickname} {playerNickname}!";

            try
            {
                var request = (HttpWebRequest)WebRequest.Create($"{client.hrefurl12was()}nonsuch/download_player_info.php");
                request.Timeout = 120000;
                var postData = "playerinfo=True";
                postData += "&nick=" + playerNickname;
                postData += "&nickvar2=" + playerNickname.ToLower();
                postData += "&keycode=" + keycode;
                var dat = Encoding.ASCII.GetBytes(postData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = dat.Length;
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(dat, 0, dat.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                //MessageBox.Show(responseString);
                if (responseString.Contains("playtime"))
                {
                    playtime = responseString.Substring(responseString.IndexOf("playtime=") + 9, responseString.IndexOf("#") - 9);
                    responseString = responseString.Substring(responseString.IndexOf("#") + 1, responseString.LastIndexOf("#") - (9 + playtime.Length));
                    playerID = responseString.Substring(responseString.IndexOf("id=") + 3, responseString.IndexOf("#") - 3);
                    responseString = responseString.Substring(responseString.IndexOf("#") + 1, responseString.LastIndexOf("#") - (3 + playerID.Length));
                    playerX = responseString.Substring(responseString.IndexOf("x=") + 2, responseString.IndexOf("#") - 2);
                    responseString = responseString.Substring(responseString.IndexOf("#") + 1, responseString.LastIndexOf("#") - (2 + playerX.Length));
                    playerY = responseString.Substring(responseString.IndexOf("y=") + 2, responseString.IndexOf("#") - 2);
                    responseString = responseString.Substring(responseString.IndexOf("#") + 1, responseString.LastIndexOf("#") - (2 + playerY.Length));
                    playerZ = responseString.Substring(responseString.IndexOf("z=") + 2, responseString.IndexOf("#") - 2);
                    responseString = responseString.Substring(responseString.IndexOf("#") + 1, responseString.LastIndexOf("#") - (2 + playerZ.Length));
                    playerWorld = responseString.Substring(responseString.IndexOf("world=") + 6, responseString.IndexOf("#") - 6);
                    responseString = responseString.Substring(responseString.IndexOf("#") + 1, responseString.LastIndexOf("#") - (6 + playerWorld.Length));
                    UUID = responseString.Substring(responseString.IndexOf("uuid=") + 5, responseString.IndexOf("#") - 5);
                    responseString = responseString.Substring(responseString.IndexOf("#") + 1, responseString.LastIndexOf("#") - (5 + UUID.Length));
                    email = responseString.Substring(responseString.IndexOf("email=") + 6, responseString.IndexOf("#") - 6);
                    responseString = responseString.Substring(responseString.IndexOf("#") + 1, responseString.LastIndexOf("#") - (6 + email.Length));
                    firstlogin = responseString.Substring(responseString.IndexOf("firstlogin=") + 11, responseString.IndexOf("#") - 11);
                    responseString = responseString.Substring(responseString.IndexOf("#") + 1, responseString.LastIndexOf("#") - (11 + firstlogin.Length));
                    lastlogin = responseString.Substring(responseString.IndexOf("lastlogin=") + 10, responseString.IndexOf("#") - 10);
                    responseString = responseString.Substring(responseString.IndexOf("#") + 1, responseString.LastIndexOf("#") - (10 + lastlogin.Length));
                    credits = responseString.Replace("credits=", "").Replace("#", "");
                    if (playerWorld == "world")
                    {
                        playerWorld = "Обычный мир";
                    }
                    if (playerWorld == "world_nether")
                    {
                        playerWorld = "Ад";
                    }
                    if (playerWorld == "world_the_end")
                    {
                        playerWorld = "Мир Эндера";
                    }
                    if (playtime == "")
                    {
                        playtime = "0";
                    }
                    if (lastlogin == "")
                    {
                        lastlogin = "Неизвестно ";
                    }
                    if (firstlogin == "")
                    {
                        firstlogin = "Неизвестно ";
                    }
                    personalAccountLabel1.Text = "Монеты NonSuch: " + credits;
                    personalAccountLabel2.Text = "Текущий мир: " + playerWorld;
                    personalAccountLabel3.Text = $"Текущая позиция: X={playerX} Y={playerY} Z={playerZ}";
                    personalAccountLabel4.Text = "Ваш Email: " + email;
                    //l_firstlogin.Text = "Зарегистрирован: " + firstlogin.Substring(0, firstlogin.IndexOf(" "));
                    //l_lastlogin.Text = "Последний раз был в игре: " + lastlogin.Substring(0, lastlogin.IndexOf(" "));
                    personalAccountLabel5.Text = $"Вы провели в игре: {playtime} мин.\r\n({Math.Truncate(Convert.ToDouble(playtime) / 60)} ч.)";

                }

            }
            catch (Exception)
            {

            } //Загрузка данных

            try
            {
                personalAccountPictureAvatar.Load($"{client.hrefurl12was()}nonsuch/Avatars/{playerNickname}.png");
            }
            catch (Exception e2)
            {
                if (e2.ToString().Contains("404"))
                {
                    if (playerNickname == "Test")
                    {
                        personalAccountPictureAvatar.Load($"{client.hrefurl12was()}nonsuch/Avatars/{playerNickname}.gif");
                    }
                    else
                    {
                        personalAccountPictureAvatar.Load($"{client.hrefurl12was()}nonsuch/Avatars/default_avatar.png");
                    }

                }
                else
                {
                    MessageBox.Show("Error: 404\r\nСвяжитесь с Администратором.", "Ошибка!");
                }
            } //Загрузка аватарки

            client.sendmessage(playerNickname, keycode, "joined the chat.");
            startdate = "";
            chatReload();

            authPanel.Visible = false;
            personalAccountPanel.Visible = true;
            chatReloader.Enabled = true;
        }

        private void chatReload()
        {
            string estring = estring = client.getmessage(playerNickname, keycode, startdate); 
            //int i=1;
            //var label = new Label();
            //label.Text = "";
            //label = ugandanChatLabelChat;
            //label.ForeColor = Color.White;
            if (estring.Length < 2)
            {
                //estring = client.getmessage(playerNickname, keycode, startdate);
            }
            
            String[] messages = estring.Split(new string[] { "<###>" }, StringSplitOptions.RemoveEmptyEntries);
            //ugandanChatGroupBox.Controls.Clear();
            ugandanChatLabelChat.Text = "";
            foreach (string item in messages)
            {
                if (item.Length > 5)
                {
                    ugandanChatLabelChat.Text += item+ "\r\n";
                }
                /*
                label.Name = $"message{i}";
                label.Text = item + $"    message{i}";
                ugandanChatGroupBox.Controls.Add(label);
                i++;
                */
            }
            //MessageBox.Show(ugandanChatGroupBox.Controls.Count.ToString());
            //ugandanChatGroupBox.Controls.Clear();
            //ugandanChatLabelChat.Text = estring.Replace("<###>", $"\r\n");

            if (ugandanChatLabelChat.Height > ugandanChatGroupBox.Height)
            {
                vScrollBar1.Maximum = ugandanChatLabelChat.Height - ugandanChatGroupBox.Height;
            }
        }

        private void signinButton_Click(object sender, EventArgs e) //Залогиниться
        {
            playerPassword = signinTextPassword.Text;
            string response = client.auth(signinTextLogin.Text, signinTextPassword.Text, keycode);
            if (response.Contains("actual name"))
            {
                playerNickname = response.Replace("Your actual name is: ","");
                successfulAuth();
            }
            if (response.Contains("Successful"))
            {
                playerNickname = signinTextLogin.Text;
                successfulAuth();
            }
            else
            {
                label1.Text = $"Signup denied:\r\n{client.auth(signinTextLogin.Text, signinTextPassword.Text, keycode)}";
            }
        }

        private void registerButtonCancel_Click(object sender, EventArgs e)
        {
            design.centerPanel(ref authPanel, ActiveForm.Height, ActiveForm.Width);
            registerPanel.Visible = false;
            registerLabelLogin.BackColor = Color.Transparent;
            registerLabelPassword.BackColor = Color.Transparent;
            registerLabelPassword2.BackColor = Color.Transparent;
            registerLabelCaptcha.BackColor = Color.Transparent;
            registerTextCaptcha.Clear();
            registerTextLogin.Clear();
            registerTextPassword.Clear();
            registerTextPassword2.Clear();
            authPanel.Visible = true;
        }

        private void registerPictureCaptcha_Click(object sender, EventArgs e)
        {
            registerPictureCaptcha.Image = design.CreateImage(registerPictureCaptcha.Width, registerPictureCaptcha.Height, ref captcha);
        }

        private void personalAccountButtonChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Multiselect = false;
            OPF.Filter = "Файлы (*.jpg, *.png)|*.jpg;*.png";
            int fsize, fwidth, fheight;
            try
            {
                if (OPF.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in OPF.FileNames)
                    {
                        if (File.Exists(file))
                        {
                            if (file.ToLower().Contains(".jpg") || file.ToLower().Contains(".png"))
                            {
                                FileInfo finfo = new FileInfo(file);
                                fsize = Convert.ToInt32(finfo.Length);
                                using (System.Drawing.Image objImage = System.Drawing.Image.FromFile(file))
                                {
                                    fwidth = objImage.Width;
                                    fheight = objImage.Height;
                                }
                                if ((fwidth >= 16 & fheight >= 16) & (fwidth <= 1024 & fheight <= 1024))
                                {
                                    Directory.CreateDirectory("temp");
                                    FileInfo fn = new FileInfo(file);

                                    personalAccountPictureAvatar.Load(file);
                                    if (fwidth < 64 || fheight < 64)
                                    {
                                        Bitmap avatar = new Bitmap(personalAccountPictureAvatar.Image);
                                        Bitmap renderAvatar = new Bitmap(avatar.Width * 8, avatar.Height * 8);
                                        using (Graphics gr = Graphics.FromImage(renderAvatar))
                                        {
                                            gr.SmoothingMode = SmoothingMode.HighQuality;
                                            gr.InterpolationMode = InterpolationMode.NearestNeighbor;
                                            gr.PixelOffsetMode = PixelOffsetMode.Half;
                                            gr.DrawImage(avatar, new Rectangle(0, 0, avatar.Width * 8, avatar.Height * 8));
                                        }
                                        personalAccountPictureAvatar.Image = renderAvatar;
                                        renderAvatar.Save($"temp/{playerNickname}.png");
                                    }
                                    else
                                    {
                                        fn.CopyTo($"temp/{playerNickname}.png", true);
                                    }

                                    WebClient Client = new WebClient();
                                    Client.Headers.Add("Content-Type", "binary/octet-stream");
                                    byte[] result = Client.UploadFile($"{client.hrefurl12was()}nonsuch/avatar_nonsuch.php", "POST", $"temp/{playerNickname}.png");

                                    fn = new FileInfo($"temp/{playerNickname}.png");
                                    fn.Delete();
                                    personalAccountPictureAvatar.Load($"{client.hrefurl12was()}nonsuch/Avatars/{playerNickname}.png");
                                }
                                else
                                {
                                    MessageBox.Show("Разрешение аватарки не должно быть больше, чем 1024х1024\r\nи не должно быть меньше, чем 16x16", "Ошибка!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Расширение файла должно быть png или jpg!", "Ошибка!");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Файл не найден!\r\n{file}", "Ошибка!");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Error: 601\r\nОшибка загрузки аватарки!", "Ошибка!");
            }
        } //Загрузка аватарки

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (personalAccountPanel.Visible == true)
            {
                client.sendmessage(playerNickname, keycode, "left the chat.");
                functions.AuthRemind(ref playerNickname, ref playerPassword, checkBox1.Checked);
            }
            else
            {
                playerPassword = signinTextPassword.Text;
                functions.AuthRemind(ref playerNickname, ref playerPassword, checkBox1.Checked);
            }
        }
    }
}