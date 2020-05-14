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

namespace session6_projects
{
    public partial class ChildForm1 : Form
    {
        public Form1 frm1;
        public ChildForm1()
        {
            InitializeComponent();
        }

        public ChildForm1(DateTime dateTime)
        {
            InitializeComponent();
            richTextBox1.Text = dateTime.ToString("d");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text File",
                CheckFileExists = true,
                CheckPathExists = true
            };

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = dialog.FileName;
                string content = File.ReadAllText(txtFileName.Text);

                using (FileStream fs= File.Open(txtFileName.Text,
                        FileMode.OpenOrCreate))
                {
                    StreamReader sr = new StreamReader(fs);
                    string fileContent = sr.ReadToEnd();

                }
                
                //using syntax => databases
                
                

                richTextBox1.Text = content;
            }

            //File => we can read a text file/ read a binary file
            //we can write a text/stream/binary data into a file
            
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            string content = richTextBox1.Text;
            SaveFileDialog dialog = new SaveFileDialog()
            {
                InitialDirectory = @"C:\csharp",
                DefaultExt = "txt",
                AddExtension = true,
                Title = "path to save a file"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                File.WriteAllText(path, content, Encoding.UTF8);
                MessageBox.Show("file is saved");
            }
        }

        private void ChildForm1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = ((Form1)frm1).dateTimePicker1.Value.ToString("d");         
        }
    }
}
