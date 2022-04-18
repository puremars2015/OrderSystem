using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopcartDesktop
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //FormLogin login = new FormLogin();
            //var result = login.ShowDialog();

            //if (result == DialogResult.OK)
            //{
                Application.Run(new FormMain());
            //}

        }
    }
}
