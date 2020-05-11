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
    public partial class FrmTest2 : Form
    {
        public FrmTest2()
        {
            InitializeComponent();
        }

        private void btnFillValues_Click(object sender, EventArgs e)
        {
            //Connect to the database
            //fetch the information
            //fill an array 
            //pass this array to the form(listbox)

            string[] fruits = new string[5];
            fruits[0] = "A";
            fruits[1] = "B";
            fruits[2] = "C";
            fruits[3] = "D";
            fruits[4] = "E";

            //you can pass the real data from database and
            //update the listbox with new information

            lstboxSample.DataSource = fruits;

            //lstboxSample.Items.Add("Tomato");
            //lstboxSample.Items.Add("Cucumber");


            //Array
            //lowerbound = 0
            int[] evenumbrs = new int[5];
            

            int[] evenums = new int[4] { 2, 4, 6, 8 };
            string[] cities = new string[3] {"Montreal", "Toronto", "Ottawa" };

            var oddNums = new int[] { 2, 4, 6, 8 };

            //Access by index
            evenumbrs[0] = 0;
            evenumbrs[1] = 2;

            //Access by doing LOOP
            string result = "";
            for(int i=0;i< evenums.Length; i++)
            {
                result += evenums[i] + " ";
            }
            MessageBox.Show(result);

            //foreach by using var
            result = "";
            foreach (var item in evenums)
            {
                result += item + " ";
            }
            MessageBox.Show(result);

            result = "";
            foreach (var city in cities)
            {
                result += city + " ";
            }
            MessageBox.Show(result);

            Array.Sort(cities);
            Array.Reverse(evenums)
        }
    }
}
