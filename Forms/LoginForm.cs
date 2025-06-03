using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KickBlastJudo.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameBox.Text;
            string password = passwordBox.Text;

            if (username == "admin" && password == "admin")
            {
                DashboardForm dform = new DashboardForm();
                dform.Show();
                Hide();
            } else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
