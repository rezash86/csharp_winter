using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session6_projects
{
    public partial class Form1 : Form
    {
        public DateTime selectedValue;
        public Form1()
        {
            InitializeComponent();
            //loadDate()
            createTreeView();


        }

        private void createTreeView()
        {
            //clear the treeview
            treeView1.Nodes.Clear();

            TreeNode tNode = treeView1.Nodes.Add("Vegetables");
            treeView1.Nodes[0].Nodes.Add("cucumber");
            treeView1.Nodes[0].Nodes.Add("tomato");
            treeView1.Nodes[0].Nodes.Add("potato");


            TreeNode tNode2 = treeView1.Nodes.Add("Fruit");
            treeView1.Nodes[1].Nodes.Add("Orange");

            treeView1.Nodes[0].Nodes[2].Nodes.Add("yellow potato");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("white potato");
            treeView1.Nodes.Add("Fruit");
            treeView1.Nodes.Add("Fruit");
            treeView1.Nodes.Add("Fruit");
            treeView1.Nodes.Add("Fruit");
            treeView1.Nodes.Add("Fruit");
            treeView1.Nodes.Add("Fruit");
            treeView1.Nodes.Add("Fruit");
            treeView1.Nodes.Add("Fruit");
            treeView1.Nodes.Add("Fruit");
            treeView1.Nodes.Add("Fruit");




            //Data structure
            //using a collection framework like
            //list, set, stack, queue
            string[] Fruits = new string[1000];
            //arrays are not dynamic!
            List<Student> list = new List<Student>();

            //a database with object
            list.Add(new Student());
        }

        private void loadDate()
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Short;

            DateTime dt = new DateTime(636370000000000000);
            label1.Text = dt.ToString("dd/MM/yyyy");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date_time_chosen = dateTimePicker1.Value;
            //Datetime

            // assigns the default value 01/01/0001 00:00:00
            DateTime dt = new DateTime(2020, 12, 13, 11, 12, 52);
            //MessageBox.Show(dt.ToString());

            DateTime currentDateTime = DateTime.Now;
            DateTime todayDate = DateTime.Today;

            //TimeSpan => show the time in days, hours...
            DateTime dt1 = new DateTime(2015, 12, 10);
            TimeSpan ts = new TimeSpan(25, 20, 55);
            //add a time into a date
            DateTime modifiedDt = dt1.Add(ts);

            //MessageBox.Show(modifiedDt.ToString());

            //Subtract dates
            DateTime dtFirst = new DateTime(2015, 12, 31);
            DateTime dtSecond = new DateTime(2016, 12, 31);

            //to subtract times
            TimeSpan tsSubtract = dtSecond.Subtract(dtFirst);

            //Convert a datetime to String
            var dtNow = DateTime.Now;
            //date format
            string format1 = dtNow.ToString("d");
            string format2 = dtNow.ToString("MM/dd/yyyy");
            string format3 = dtNow.ToString("dd/MM/yyyy");
            string format4 = dtNow.ToString("MM/dd/yyyy h:mm: tt");
            //MessageBox.Show(format1 +
            // " %%%%" + format2 + "%%%% " + format3 + " %%%" 
            //    + format4);

            string format5 = dtNow.ToShortDateString();
            string format6 = dtNow.ToLongDateString();
            string format7 = dtNow.ToShortTimeString();

            //convert string to datetime
            //valid date and time string can be converted
            //That is correct
            DateTime converted = DateTime.Parse("5/12/2020");

            //a better way to convert
            var str = "5/122020";
            DateTime convertedDt;

            var isValid = DateTime.TryParse(str, out convertedDt);
            if (isValid)
            {
                //Do something
            }
            else
            {

                //It does not throw excpetion
                MessageBox.Show("the value inserted is not correct");
            }





        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void form1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectedValue = dateTimePicker1.Value;
            //call by constructor
            //ChildForm1 form1 = new ChildForm1(selectedValue);            
            //form1.Show();

            //call by object
                
            ChildForm1 childForm = new ChildForm1();
            childForm.frm1 = this;
            childForm.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm2 form2 = new ChildForm2();
            form2.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();
            dg.Filter = "pdf files (*.pdf)|*.txt|All files (*.*)|*.*";

            //check the existance of file
            dg.CheckFileExists = true;

            if (dg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dg.FileName;
                MessageBox.Show(fileName);
            }


        }
    }

    class Student
    {
        int id;
        string name;
    }

}
