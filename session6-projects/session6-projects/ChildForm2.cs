using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session6_projects
{
    public partial class ChildForm2 : Form
    {
        public ChildForm2()
        {
            InitializeComponent();
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fileDialog.FileName;
                pictureBox1.Image = Image.FromFile(txtPath.Text);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                MessageBox.Show(font.Name + "  " + font.Size + " " + font.FontFamily.Name);
            }

            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDialog1.Document = printDoc;
            printDialog1.AllowSelection = true;
            printDialog1.AllowSomePages = true;
            //Call ShowDialog  
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }
    }
}
