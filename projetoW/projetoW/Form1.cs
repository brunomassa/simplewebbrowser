using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetoW.Properties;

namespace projetoW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            webBrowser1.Navigate(Settings.Default.home);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                webBrowser1.Navigate(textBox1.Text);
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }
    }
}
