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
            LoadAllForm();
            Application.Run(new FrmLogin());
        }

        private static void LoadAllForm()
        {
            Splash.frmMain = new FrmMain();
            Splash.cfd = new ChildFrmDashboard();
            Splash.cfb = new ChildFrmBill();
            Splash.cfp = new ChildFrmProduct();
            Splash.cfpc = new ChildFrmProductCategory();
            Splash.cfu = new ChildFrmUser();
            Splash.cfa = new ChildFrmAbout();
            Splash.cfs = new ChildFrmSetting();
            Splash.CfuCreateUser = new CfuFrmCreateUser();
        }
    }
}
