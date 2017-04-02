using System;
using System.Windows.Forms;
using DTO;
using DTO.DAO;
using QLBH_BunifuUI.Common;
using QLBH_BunifuUI.SQL;
using System.Threading;

namespace QLBH_BunifuUI.form
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Process();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }


        private void Login()
        {
            
            string SQLInstance;
            if (cbbSqlServer.SelectedValue == null)
                SQLInstance = cbbSqlServer.Text.Trim();
            else
            {
                SQLInstance = cbbSqlServer.Text.Trim();
                SQLInstance += cbbSqlServer.SelectedValue.ToString();
            }

            SQLInstance = "LIVINGROOM-PC";

            DTO.Properties.Settings.Default.ShopTPTConnectionString =
                    "Data Source=" + SQLInstance + ";Initial Catalog=ShopTPT;Persist Security Info=True;User ID=s" +
                    "a;Password=tpt";
            //rtb.Text = DTO.Properties.Settings.Default.ShopTPTConnectionString;
            if (Helper.IsServerConnected(DTO.Properties.Settings.Default.ShopTPTConnectionString))
            {
                var user = UserDao.Instance.FindSingleUser(txtUsername.Text, Helper.Md5Encrypt(txtPassword.Text));
                if (user != null)
                {
                    Session.Instance.Add("ID", user.UserID);
                    Session.Instance.Add("RoleID", user.RoleID);
                    Session.Instance.Add("Password", user.Password);
                    
                    LoadAllForm();
                    Hide();
                    Splash.frmMain.ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show(@"Sai tên đăng nhập hoặc mật khẩu", @"Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến CSDL");
            }

        }

        private int CheckLogin(string userName, string pass)
        {
            return UserDao.Instance.FindSingleUser(userName, pass) == null ? 0 : 1;
        }

        private void Process()
        {
            // Retrieve the enumerator instance and then the data.  
            // var instance = SqlDataSourceEnumerator.Instance;
            var table = FindSqlServerName.GetAllSqlServerName();
            cbbSqlServer.DataSource = table;


            cbbSqlServer.DisplayMember = "ServerName";
            cbbSqlServer.ValueMember = "InstanceName";
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }

        }

        private void cbbSqlServer_DropDown(object sender, EventArgs e)
        {
            cbbSqlServer.UseWaitCursor = true;
            cbbSqlServer.Cursor = Cursors.WaitCursor;
            Process();
            cbbSqlServer.UseWaitCursor = false;
            cbbSqlServer.Cursor = Cursors.Default;
        }


        private void LoadAllForm()
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
