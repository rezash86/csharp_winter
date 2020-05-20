using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session8_winform_projects
{
    public partial class Form1 : Form
    {
        List<Employee> employeesReceived = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("1", "A", "AA", EmploymentType.FULLTIME));
            employees.Add(new Employee("2", "B", "BB", EmploymentType.PARTTIME));
            employees.Add(new Employee("3", "C", "CC", EmploymentType.FULLTIME));
            employees.Add(new Employee("4", "D", "DD", EmploymentType.PARTTIME));
            employees.Add(new Employee("5", "E", "EE", EmploymentType.FULLTIME));

            List<string> content = new List<string>();
            foreach (var emp in employees)
            {
                content.Add(emp.ToString());
                //MessageBox.Show(emp.ToString());
            }
            
            File.WriteAllLines(@"C:\csharp\registered_employee.txt", content);

            //reading the file
            List<string> lines = File.ReadLines(@"C:\csharp\registered_employee.txt").ToList();
            
            foreach (string line in lines)
            {
                //emplyoee id = 1 firstname = A and lastName = AA and employment_type = FULLTIME
                //I want to convert it to an Employee object
                string[] attributes = line.Split(',');
                string id = String.Empty;
                string firstname = String.Empty;
                string lastName = String.Empty;
                string employmentType = String.Empty;
                foreach (string str in attributes)
                {
                    if (str.Contains("emplyoee id="))
                    {
                        id = str.Split('=')[1];
                    }
                    if (str.Contains("firstname ="))
                    {
                        firstname = str.Split('=')[1];
                    }
                    if (str.Contains("lastName="))
                    {
                        lastName = str.Split('=')[1];
                    }
                    if (str.Contains("employment_type="))
                    {
                        employmentType = str.Split('=')[1];
                    }
                }
                employeesReceived.Add(new Employee(id, firstname, lastName, EmploymentType.FULLTIME));
            }
            //it will populate the grid

            BindingSource source = new BindingSource();
            source.DataSource = employeesReceived;
            dataGridView1.DataSource = source;

            source.ResetBindings(false);
            //Action (delegate)
            //employees.ForEach(emp => MessageBox.Show(emp.ToString()));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("1", "A", "AA", EmploymentType.FULLTIME));
            employees.Add(new Employee("2", "B", "BB", EmploymentType.PARTTIME));
            employees.Add(new Employee("3", "C", "CC", EmploymentType.FULLTIME));
            employees.Add(new Employee("4", "D", "DD", EmploymentType.PARTTIME));
            employees.Add(new Employee("5", "E", "EE", EmploymentType.FULLTIME));

            BindingSource source = new BindingSource();
            source.DataSource = employees;
            dataGridView1.DataSource = source;

            source.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee2> employees = new List<Employee2>();
            employees.Add(new Employee2("1", "A", "AA"));
            employees.Add(new Employee2("2", "B", "BB"));
            employees.Add(new Employee2("3", "C", "CC"));
            employees.Add(new Employee2("4", "D", "DD"));
            employees.Add(new Employee2("5", "E", "EE"));

            BindingSource source = new BindingSource();
            source.DataSource = employees;
            dataGridView1.DataSource = source;

            source.ResetBindings(false);
        }
    }
}
