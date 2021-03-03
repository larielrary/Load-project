using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LoadProject
{
    public partial class Authorization : Form
    {
        private string _login;
        private string _password;
        MainForm mainForm;

        public Authorization()
        {
             InitializeComponent();
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void InputBtnClick(object sender, EventArgs e)
        {
            CheckInputData();


            if (mainForm == null)
            {
                Show();
            }
        }

        public void CheckInputData()
        {
            (string, string) creds = FileProcessor.ReadCredentialsFromFile();

            _login = loginTextBox.Text;
            _password = passTextBox.Text;
            if (GetHash(_login) == creds.Item1 && GetHash(_password) == creds.Item2)
            {
                mainForm = new MainForm();
                mainForm.Show();
                Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Ошибка входа", "Вы ввели неверные данные", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    loginTextBox.Clear();
                    passTextBox.Clear();
                }
            }
        }

		private void Authorization_Load(object sender, EventArgs e)
		{

		}

        public string GetHash(string line)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(line));
            return Convert.ToBase64String(hash);
        }
    }
}
