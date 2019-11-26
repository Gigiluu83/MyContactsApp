//STUDENT:  PHUQUY PHAM
//COURSE:  MONDAY, C# CODELOUISVILLE BELLARMINE
//DATE:  NOV 26, 2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContactsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyContactsApp());
        }
    }
}
