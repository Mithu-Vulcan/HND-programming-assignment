using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KickBlastJudo.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        public void loadSubform(Form subForm)
        {
            MainPanel.Controls.Clear();
            subForm.TopLevel = false;
            MainPanel.Controls.Add(subForm);
            subForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AthleteButton_Click(object sender, EventArgs e)
        {
            AthleteForm aForm = new AthleteForm();
            loadSubform(aForm);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
