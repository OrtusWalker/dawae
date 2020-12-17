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

        private void button1_Click(object sender, EventArgs e)
        {
            if (client.auth(textBox1.Text, textBox2.Text, keycode).Contains("Successful"))
            {
                label1.Text = $"Signin:\r\n{client.auth(textBox1.Text, textBox2.Text, keycode)}";
            }
            else
            {
                label1.Text = $"Signin denied:\r\n{client.auth(textBox1.Text, textBox2.Text, keycode)}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (client.nickdupe(textBox1.Text, keycode).Contains("Successful"))
            {
                if (client.register(textBox1.Text, textBox2.Text, keycode).Contains("Successful"))
                {
                    label1.Text = $"Signup:\r\n{client.auth(textBox1.Text, textBox2.Text, keycode)}";
                }
                else
                {
                    label1.Text = $"Signup denied:\r\n{client.auth(textBox1.Text, textBox2.Text, keycode)}";
                }
            }
            else
            {
                label1.Text = $"Signup denied:\r\n{client.auth(textBox1.Text, textBox2.Text, keycode)}";
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            design.centerPanel(ref authPanel, ActiveForm.Height, ActiveForm.Width);
        }
    }
}