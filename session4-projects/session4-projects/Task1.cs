using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session4_projects
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text != string.Empty)
            {
                string userName = txtName.Text;
                string password = txtPassword.Text;

                MessageBox.Show($"username => {userName} and password => {password}"
                    , "information about the user", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
               MessageBox.Show("don't forget the username");
                txtName.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
