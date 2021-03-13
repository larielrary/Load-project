using LoadProject.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LoadProject
{
    public partial class MainForm : Form
    {
        private const string _connectionStringName = "LocalFileConnectionString";

        private string ConnectionString
        {
            get
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
            Process.Start("dotnet", $"publish\\IndividualPlanApp.Presentational.dll");
        }

        private void TeacherBtnClick(object sender, EventArgs e)
        {
            //запуск exe нагрузки по преподавателю
            Process p = new Process();
            try
            {
                p.StartInfo.FileName = $"{Environment.CurrentDirectory}\\publishA\\WpfUI.exe";
                p.Start();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Проблема с запуском приложения. {exception.Message}. Обратитесь к администратору", "Произошла ошибка",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void WebsiteBtnClick(object sender, EventArgs e)
        {
            //запуск веб-портала
            Process.Start("dotnet", $"ProjectO\\ViewDirectory.dll");
        }

        private void exportToAccessBtnClick(object sender, EventArgs e)
        {
            var stringJson = File.ReadAllText($"{Environment.CurrentDirectory}\\data.json");
            JObject obj = JObject.Parse(stringJson);
            var facultySection = obj.GetValue("faculties").ToString();
            var groupsSection = obj.GetValue("groups").ToString();
            var groupLoadsSection = obj.GetValue("groupLoads").ToString();
            var loadsSection = obj.GetValue("loads").ToString();
            var subjectsSection = obj.GetValue("subjects").ToString();
            var teachersSection = obj.GetValue("teachers").ToString();
            var unitOfLoadsSection = obj.GetValue("unitOfLoads").ToString();

            var faculties = JsonConvert.DeserializeObject<List<Faculty>>(facultySection);
            var groups = JsonConvert.DeserializeObject<List<Group>>(groupsSection);
            var groupsLoads = JsonConvert.DeserializeObject<List<GroupLoad>>(groupLoadsSection);
            var loads = JsonConvert.DeserializeObject<List<Load>>(loadsSection);
            var subjects = JsonConvert.DeserializeObject<List<Subject>>(subjectsSection);
            var teachers = JsonConvert.DeserializeObject<List<Teacher>>(teachersSection);
            var unitOfLoads = JsonConvert.DeserializeObject<List<UnitOfLoad>>(unitOfLoadsSection);

            ExecuteExportJsonToAccess(faculties, groups, groupsLoads, loads, subjects, teachers, unitOfLoads);
        }

        private void configurationBtnClick(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            configuration.Show();
        }

        private void loadJarBtnClick(object sender, EventArgs e)
        {
            string filePath = $"{Environment.CurrentDirectory}\\JSONParser.jar";
            if (File.Exists(filePath))
            {
                try
                {
                    Process.Start("java", $"-jar {filePath} data.json");
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Проблема с загрузкой данных. {exception.Message}. Обратитесь к администратору", "Произошла ошибка",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не найден компонент, обратитесь к администратору", "Произошла ошибка",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ExecuteExportJsonToAccess(IEnumerable<Faculty> faculties, IEnumerable<Group> groups,
            IEnumerable<GroupLoad> groupLoads, IEnumerable<Load> loads, IEnumerable<Subject> subjects,
            IEnumerable<Teacher> teachers, IEnumerable<UnitOfLoad> unitOfLoads)
        {
            if (File.Exists("C:\\database.accdb"))
            {
                File.Delete("C:\\database.accdb");
            }

            OleDbConnection conn;

            try
            {
                using (conn = new OleDbConnection(ConnectionString))
                {
                    conn.Open();


                    try
                    {
                        List<OleDbCommand> creationCommands = new List<OleDbCommand>
                        {
                            new OleDbCommand("CREATE TABLE Faculties (ID AUTOINCREMENT Primary Key, Name String)", conn),
                            new OleDbCommand("CREATE TABLE Groups (ID AUTOINCREMENT Primary Key, Name String, FacultyId Int)", conn),
                            new OleDbCommand("CREATE TABLE GroupLoads (GroupId Int, UnitOfLoadId Int)", conn),
                            new OleDbCommand("CREATE TABLE UnitOfLoads (ID AUTOINCREMENT Primary Key, LoadId Int, TeacherId Int, Value Double, SubjectId Int, Term Int, Row Int, StudentCount Int)", conn),
                            new OleDbCommand("CREATE TABLE Load (ID AUTOINCREMENT Primary Key, Name String)", conn),
                            new OleDbCommand("CREATE TABLE Subject (ID AUTOINCREMENT Primary Key, Name String)", conn),
                            new OleDbCommand("CREATE TABLE Teacher (ID AUTOINCREMENT Primary Key, Name String)", conn),
                            new OleDbCommand("CREATE TABLE  (ID AUTOINCREMENT Primary Key, Name String)", conn),
                        };

                        foreach (var one in creationCommands)
                        {
                            one.ExecuteNonQuery();
                        }

                        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Faculties (Id, Name) Values (@Id, @Name)", conn))
                        {
                            foreach (var one in faculties)
                            {
                                cmd.Parameters.AddRange(new OleDbParameter[]
                                {
                                    new OleDbParameter("Id", one.Id),
                                    new OleDbParameter("Name", one.Name),
                                });

                                cmd.ExecuteNonQuery();
                            }
                        }

                        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Groups (Id, Name) Values (@Id, @Name)", conn))
                        {
                            foreach (var one in groups)
                            {
                                cmd.Parameters.AddRange(new OleDbParameter[]
                                {
                                    new OleDbParameter("Id", one.Id),
                                    new OleDbParameter("Name", one.Name),
                                });

                                cmd.ExecuteNonQuery();
                            }
                        }

                        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO GroupLoads (GroupId, UnitOfLoadId) Values (@GroupId, @UnitOfLoadId)", conn))
                        {
                            foreach (var one in groupLoads)
                            {
                                cmd.Parameters.AddRange(new OleDbParameter[]
                                {
                                    new OleDbParameter("GroupId", one.GroupId),
                                    new OleDbParameter("UnitOfLoadId", one.UnitOfLoadId),
                                });

                                cmd.ExecuteNonQuery();
                            }
                        }

                        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Loads (Id, Name) Values (@Id, @Name)", conn))
                        {
                            foreach (var one in loads)
                            {
                                cmd.Parameters.AddRange(new OleDbParameter[]
                                {
                                    new OleDbParameter("Id", one.Id),
                                    new OleDbParameter("Name", one.Name),
                                });

                                cmd.ExecuteNonQuery();
                            }
                        }

                        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Subject (Id, Name) Values (@Id, @Name)", conn))
                        {
                            foreach (var one in subjects)
                            {
                                cmd.Parameters.AddRange(new OleDbParameter[]
                                {
                                    new OleDbParameter("Id", one.Id),
                                    new OleDbParameter("Name", one.Name),
                                });

                                cmd.ExecuteNonQuery();
                            }
                        }

                        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Teacher (Id, Name) Values (@Id, @Name)", conn))
                        {
                            foreach (var one in teachers)
                            {
                                cmd.Parameters.AddRange(new OleDbParameter[]
                                {
                                    new OleDbParameter("Id", one.Id),
                                    new OleDbParameter("Name", one.Name),
                                });

                                cmd.ExecuteNonQuery();
                            }
                        }

                        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO UnitOfLoads (Id, Name) Values (@Id, @Name)", conn))
                        {
                            foreach (var one in teachers)
                            {
                                cmd.Parameters.AddRange(new OleDbParameter[]
                                {
                                    new OleDbParameter("Id", one.Id),
                                    new OleDbParameter("Name", one.Name),
                                });

                                cmd.ExecuteNonQuery();
                            }
                        }

                        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO UnitOfLoads (Id, LoadId, TeacherId, Value, SubjectId, Term, Row, StudentCount ) Values (@Id, @Name)", conn))
                        {
                            foreach (var one in unitOfLoads)
                            {
                                cmd.Parameters.AddRange(new OleDbParameter[]
                                {
                                    new OleDbParameter("Id", one.Id),
                                    new OleDbParameter("LoadId", one.LoadId),
                                    new OleDbParameter("TeacherId", one.TeacherId),
                                    new OleDbParameter("SubjectId", one.SubjectId),
                                    new OleDbParameter("Term", one.Term),
                                    new OleDbParameter("Row", one.Row),
                                    new OleDbParameter("StudentCount", one.StudentsCount),
                                });

                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Данные добавлены в MS Access. Открывается файл...");
                        Process.Start("C:\\database.accdb");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при добавлении данных в MS Access" + ex.Source, "Произошла ошибка",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии базы данных MS Access: " + ex.Source, "Произошла ошибка",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }


    }
}
