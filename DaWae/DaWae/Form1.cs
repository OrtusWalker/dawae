using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaWae.Scripts;

namespace DaWae
{
    public partial class Form1 : Form
    {
        string keycode = "1f0e539d6abc3b78d945c8d0c078ccdb73160d15c275b2f97352e9da1e6e8509";
        clientserver client = new clientserver();
        Design design = new Design();
        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (ActiveForm.Height > 0)
            {
                design.centerPanel(ref authPanel, ActiveForm.Height, ActiveForm.Width);
                design.centerPanel(ref registerPanel, ActiveForm.Height, ActiveForm.Width);
            }
            
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            //authPanel.Visible = false;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //authPanel.Visible = true;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            design.centerPanel(ref registerPanel, ActiveForm.Height, ActiveForm.Width);
            authPanel.Visible = false;
            registerPanel.Visible = true;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (client.nickdupe(signinTextLogin.Text, keycode).Contains("Successful"))
            {
                if (client.register(signinTextLogin.Text, signinTextPassword.Text, keycode).Contains("Successful"))
                {
                    label1.Text = $"Signup:\r\n{client.auth(signinTextLogin.Text, signinTextPassword.Text, keycode)}";
                }
                else
                {
                    label1.Text = $"Signup denied:\r\n{client.auth(signinTextLogin.Text, signinTextPassword.Text, keycode)}";
                }
            }
            else
            {
                label1.Text = $"Signup denied:\r\n{client.auth(signinTextLogin.Text, signinTextPassword.Text, keycode)}";
            }
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            if (client.auth(signinTextLogin.Text, signinTextPassword.Text, keycode).Contains("Successful"))
            {
                label1.Text = $"Signup:\r\n{client.auth(signinTextLogin.Text, signinTextPassword.Text, keycode)}";
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
            authPanel.Visible = true;
        }
    }
}