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
            _login = loginTextBox.Text;
            _password = passTextBox.Text;
            if (_login == "login" && _password == "pass")
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
    }
}
