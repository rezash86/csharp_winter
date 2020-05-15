using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session7_projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> emps = GetEmployees();
            //foreach(Employee emp in emps)
            //{
            //    MessageBox.Show(emp.ToString());
            //}

            dataGridView1.DataSource = emps;


        }

        private List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "A", "MON"));
            employees.Add(new Employee(2, "B", "TOR"));
            employees.Add(new Employee(3, "C", "OTW"));
            employees.Add(new Employee(4, "D", "CAL"));
            employees.Add(new Employee(5, "E", "VEN"));
            employees.Add(new Employee(6, "F", "VAN"));
            employees.Add(new Employee(7, "G", "CID"));

            return employees;
        }
        private void DataCollectionSample()
        {
            //List !
            //I will do something to fill the datagrid

            //adding a value in the middle of an array has low performance

            //Generic means having only one type of data in the class
            //Generic Collection => our collection only accepts one type of data

            //ArrayList => Non Generic, we can add all types of data
            ArrayList Arrlist = new ArrayList();
            Arrlist.Add(11);
            Arrlist.Add("Brad pitt");
            Arrlist.Add(new Employee(1, "A", "Montreal"));

            ArrayList arrayList2 = new ArrayList()
            { 100, "two", 12.5, 200};

            foreach (var value in arrayList2)
            {
                //             MessageBox.Show(value.ToString());
            }

            //adding a value by the index(position)
            arrayList2.Insert(1, "temp value");
            foreach (var value in arrayList2)
            {
                MessageBox.Show(value.ToString());
            }
            arrayList2.RemoveAt(1);

            if (!arrayList2.Contains("temp value"))
            {
                MessageBox.Show("the value cannot be found");
            }
            //It will remove all the elements
            arrayList2.Clear();
            //List => Generic
            List<Employee> list = new List<Employee>();
            //so adding a Non-employee type will gives us compilation error
            //list.Add(1);
            list.Clear();
            //LINQ
            //list.All()
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string data = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            MessageBox.Show(data);
        }
    }
}
