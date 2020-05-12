using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session5_projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            changeAttributes();

            rbtnGreen.Checked = true;
        }

        private void changeAttributes()
        {
            //you can add some actions/behaviors
            //It can check the OS
            //MessageBox.Show("Welcome users");
            lblWelcome.Text = "Hello dear User";
            lblWelcome.BackColor = Color.Red;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome.Dock = DockStyle.Top;

            txtboxSample.Text = "johnabbott";
            txtboxSample.Width = 450;
            txtboxSample.Height = 100;

            txtboxSample.BackColor = Color.Blue;
            txtboxSample.ForeColor = Color.White;
            txtboxSample.BorderStyle = BorderStyle.Fixed3D;

            //Restriction
            txtboxSample.MaxLength = 20;

            //readonly-access
            txtboxSample.ReadOnly = true;

            //txtboxSample.Multiline = false;
            //txtboxSample.PasswordChar = '*';
            //txtboxSample.Font = new Font(FontFamily, FontStyle.Bold);
            this.txtboxSample.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            txtboxSample.Text += " " + "studnets" + "\r\n" + "are the best";

            //string values => retreive value from textbox
            string txt = txtboxSample.Text;


            btnSample.Width = 300;
            btnSample.Text += " please";


            //removing
            cmboxGender.Items.Remove("man");
            cmboxGender.Items.Remove("woman");

            //adding
            cmboxGender.Items.Add("Male");
            cmboxGender.Items.Add("Female");

            cmboxGender.SelectedIndex = 1;
            //take the selectedItem
            string selected = cmboxGender.Text;

            var item = cmboxGender.
                GetItemText(cmboxGender.SelectedItem);

            cmboxGender.SelectedIndex = cmboxGender.FindStringExact("Male");

            //checkedListbox
            checkedListBox1.Items.Add("Sunday", false);
            checkedListBox1.Items.Add("Monday", CheckState.Checked);
            checkedListBox1.Items.Add("Tuesday", CheckState.Unchecked);
            checkedListBox1.Items.Add("Wednesday", CheckState.Indeterminate);

            string[] days = new[] { "Thursday", "Friday" };
            checkedListBox1.Items.AddRange(days);

            checkedListBox1.SetItemChecked(0, true);
        }
        private void txtboxSample_TextChanged(object sender, EventArgs e)
        {
            lblWelcome.Text = txtboxSample.Text;
        }

        private void txtboxSample_KeyDown(object sender, KeyEventArgs e)
        {
            //it captures which key is pressed by user
            if(e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("user entered ENTER");
            }
            if(e.KeyCode == Keys.CapsLock)
            {
                MessageBox.Show("user presses on Capslock");
            }

            
        }

        private void txtboxAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.A < e.KeyCode && e.KeyCode < Keys.Z)
            {
                MessageBox.Show("enter a number");
                txtboxAge.Text = "";
                txtboxAge.ForeColor = Color.White;
                txtboxAge.BackColor = Color.Red;
            }
        }

        private void parseTxtBox()
        {
            try
            {
                int val = int.Parse(txtboxSample.Text);
                float f = float.Parse(txtboxSample.Text);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("enter a number");
            }
            catch (ArithmeticException exc)
            {

            }
            catch (Exception exc)
            {

            }
            finally
            {
                //happens all the time with/without occuring exception
            }
        }

        private void txtboxAge_ForeColorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("forcolor changed");
        }

        private void txtboxAge_BackColorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("backcolor changed");
        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            try
            {
                int ageValue = int.Parse(txtboxAge.Text);

            }catch(FormatException exc)
            {
                string message = exc.Message;
                MessageBox.Show("error in the input " + message);
            }
            
        }

        private void cmboxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmboxGender.SelectedItem.ToString() == "Male")
            {

            }
            else if(cmboxGender.SelectedItem.ToString() == "Female")
            {

            }
        }

        private void cmboxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboxDate.Items.Clear();

            if (cmboxDate.SelectedItem.ToString() == "Year")
            {
                comboBoxDynamic.Items.Add("2020");
                comboBoxDynamic.Items.Add("2021");
                comboBoxDynamic.Items.Add("2022");

            }

            if (cmboxDate.SelectedItem.ToString() == "Month")
            {
                comboBoxDynamic.Items.Add("Jan");
                comboBoxDynamic.Items.Add("Feb");
            }

            if (cmboxDate.SelectedItem.ToString() == "Day")
            {
                for(int i=1; i<31; i++)
                {
                    comboBoxDynamic.Items.Add(i);
                }
            }
        }

        private void btnCheked_Click(object sender, EventArgs e)
        {
            bool isChecked= checkedListBox1.GetItemChecked(0);
            if (isChecked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                }
            }
            
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(rbtnBlue.Checked == true && rbtnRectangle.Checked)
            {
                MessageBox.Show("Blue rectangle was selected");
            }
            else if(rbtnGreen.Checked == true)
            {
                MessageBox.Show("Green was selected");
            }
            else
            {
                MessageBox.Show("Red was selected");
            }
            
        }
    }
}
