using System;
using System.Windows.Forms;
using QLBH_BunifuUI.Common;
using QLBH_BunifuUI.form;

namespace QLBH_BunifuUI
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
            Application.Run(new FrmLogin());
            // test
        }

       
    }
}
