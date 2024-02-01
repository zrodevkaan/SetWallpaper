using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetWindowsBackground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] themeFiles = Directory.GetFiles("C:\\Windows\\Resources\\Themes");
            foreach (string file in themeFiles)
            {
                comboBox1.Items.Add(file);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var FileDialog = new OpenFileDialog();
            FileDialog.ShowDialog();
            
            DisplayPicture(FileDialog.FileName);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process.Start(comboBox1.Text);
        }
    }
}
