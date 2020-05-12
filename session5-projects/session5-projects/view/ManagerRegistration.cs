using session5_projects.domain;
using session5_projects.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session5_projects.view
{
    public partial class ManagerRegistration : Form
    {
        public ManagerRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //view
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string tel = txtTelephon.Text;
            int count = int.Parse(txtCount.Text);
            
            //Model
            Employee employee =
                new Manager(firstName, lastName, tel, count);


            //Spring(spirngboot)
            IRegistrationService service =
                new ManagerRegisterService();

            //At runtime => it will go to the real
            //implementation
            //Polymorphism
            service.RegisterEmployee(employee);
        }
    }
}
