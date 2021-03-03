using LoadProject.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LoadProject
{
    public partial class MainForm : Form
    {
        private const string _jsonParserFileName = "JSONParser.jar";
        private const string _jsonDataFileName = "data.json";
        private const string _connectionStringName = "LocalFileConnectionString";

        private string ConnectionString { get
            {
                return System.Configuration.ConfigurationManager
                    .ConnectionStrings[_connectionStringName].ConnectionString;
            }
        }

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
            var stringJson = File.ReadAllText("C:\\test.json");
            JObject obj = JObject.Parse(stringJson);
            var keyValues = JsonConvert.DeserializeObject<IEnumerable<KeyValuePair<string, string>>>(stringJson);
            KeyValuePair<string, string> facultySection = keyValues.First(k => k.Key == "faculties");
            var faculties = JsonConvert.DeserializeObject<List<Faculty>>(facultySection.Value);
        }

        private void configurationBtnClick(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            configuration.Show();
        }

        private void loadJarBtnClick(object sender, EventArgs e)
        {
            string filePath = $"{Environment.CurrentDirectory}\\{_jsonParserFileName}";
            if (File.Exists(filePath))
            {
                Process.Start("java", $"-jar {filePath} {_jsonDataFileName}");
            }
            else
            {
                MessageBox.Show("Не найден компонент, обратитесь к администратору");
            }
        }

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

        private void FunctionForExportJsonToAccess()
		{
            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                OleDbCommand cmd = new OleDbCommand("INSERT into TABLE (FIELD1, FIELD2) Values(@Param1Name)", conn);
                var oleDbParameters = new OleDbParameter[]
                {
                    new OleDbParameter("Param1Name", "param1VALUE"),
                };

                cmd.Parameters.AddRange(oleDbParameters);

                conn.Open();

                if (conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Ошибка открытия соединения с базой данных MS Access");
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные добавлены в MS Access. Открывается файл...");
                    conn.Close();
                    Process.Start("C:\\database.accdb");
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Ошибка." + ex.Source);
                    conn.Close();
                }
            }          
        }
	}
}
