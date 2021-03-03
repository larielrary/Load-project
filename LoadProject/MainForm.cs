using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LoadProject
{
    public partial class MainForm : Form
    {
        private const string JsonParserFileName = "JSONParser.jar";
        private const string JsonDataFileName = "data.json";

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
            Process p = new Process();
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
            string filePath = $"{Environment.CurrentDirectory}\\{JsonParserFileName}";
            if (File.Exists(filePath))
            {
                Process.Start("java", $"-jar {filePath} {JsonDataFileName}");
            }
            else
            {
                MessageBox.Show("Не найден компонент, обратитесь к администратору")
            }
        }

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

        private void FunctionForExportJsonToAccess()
		{
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\tlwhitten\Documents\Database2.accdb";

            int CO2 = 50;
            int Temperature = 50;

            OleDbCommand cmd = new OleDbCommand("INSERT into Data (CO2, Temperature) Values(@CO2, @Temperature)");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@CO2", OleDbType.VarChar).Value = CO2;
                cmd.Parameters.Add("@Temperature", OleDbType.VarChar).Value = Temperature;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    conn.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Source + " POOOOOPY");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }
	}
}
