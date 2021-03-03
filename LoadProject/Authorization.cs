using System;
using System.IO;
using System.Windows.Forms;

namespace LoadProject
{
    public partial class Authorization : Form
    {
        private string _login;
        private string _password;
        MainForm mainForm;
        public string key = "b14ca5898a4e4133bbce2ea2315a1916";
        public Authorization()
        {
             InitializeComponent();
             WriteToFile("login", Encryption("pass"));

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

            string readTextFromFile = ReadFile();
            String[] words = readTextFromFile.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string pasFrFile= AesOperation.DecryptString(key, words[1]);
            _login = loginTextBox.Text;
            _password = passTextBox.Text;
            if (_login == words[0] && _password == pasFrFile)
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

        public string Encryption(string password)
		{
            var encryptedString = AesOperation.EncryptString(key, password);
            return encryptedString;
        }

        public void WriteToFile(string login,string password)
		{
            string text = login + " " + password;
            string path = Environment.CurrentDirectory+ "\\file.txt";
            using (FileStream fstream = new FileStream(path, FileMode.Truncate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
            }
        }

        public string ReadFile()
		{
            string textFromFile = string.Empty;
            string path = Environment.CurrentDirectory;
            using (FileStream fstream = File.OpenRead($"{path}\\file.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                textFromFile = System.Text.Encoding.Default.GetString(array);
            }
            return textFromFile;
		}
   
	}
}
