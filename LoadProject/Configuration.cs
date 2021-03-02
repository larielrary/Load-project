using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadProject
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
            userPathTextBox.Text = filePath;
            standartPathTextBox.Text = "c:/...";
        }
        public static string filePath = "c:/...";
        private void chosePathBtnClick(object sender, EventArgs e)
        {
            // var fileContent = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                ////Read the contents of the file into a stream
                //var fileStream = openFileDialog.OpenFile();

                //using (StreamReader reader = new StreamReader(fileStream))
                //{
                //    fileContent = reader.ReadToEnd();
                //}
                userPathTextBox.Text = filePath;
            }
            // MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

		private void button2_Click(object sender, EventArgs e)
		{
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
	}
}
