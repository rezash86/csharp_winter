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
    public partial class frmegistrationForm : Form
    {
        public frmegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;

            MessageBox.Show(name + "  " + email);
        }

        private void btnRegistration_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("Mouse hovered", "my caption",
            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
