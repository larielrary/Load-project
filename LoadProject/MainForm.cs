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

namespace LoadProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            Close();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void YearBtnClick(object sender, EventArgs e)
        {
            //запуск exe нагрузки на год
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = @"C:\Users\masha\OneDrive\Учеба\4 курс\УРПО\ConsoleApp1\ConsoleApp1\bin\Debug\netcoreapp3.1\ConsoleApp1.exe";
            p.Start();
        }

        private void TeacherBtnClick(object sender, EventArgs e)
        {
            //запуск exe нагрузки по преподавателю
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = @"C:\Users\masha\OneDrive\Учеба\4 курс\УРПО\ConsoleApp2\ConsoleApp2\bin\Debug\netcoreapp3.1\ConsoleApp2.exe";
            p.Start();
        }

        private void exportToAccessBtnClick(object sender, EventArgs e)
        {

        }

        private void configurationBtnClick(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            configuration.Show();
        }

        private void loadJarBtnClick(object sender, EventArgs e)
        {

        }
    }
}
