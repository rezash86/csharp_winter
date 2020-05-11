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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sample = txtSample.Text;
            string result = sample.Last<char>() + 
                sample.Substring(1, sample.Length - 2) + 
                sample.First<char>();

            MessageBox.Show(result);
            
            //Reverse
            string revers = new string(sample.Reverse<char>().ToArray<char>());
            MessageBox.Show(revers);
            //Reverse
            string temp = "";
            foreach (char ch in sample)
            {
                temp = ch + temp;
            }

            MessageBox.Show(temp);


        }
    }
}
