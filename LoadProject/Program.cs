using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(FileProcessor.IsHashFileExisting() ?
                new Authorization()
                : new Authorization());     // CHANGE TO EnterNewPassord WINDOW!!!
        }
    }
}
