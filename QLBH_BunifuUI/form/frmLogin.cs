using System;
using System.Windows.Forms;
using DTO;
using DTO.DAO;
using QLBH_BunifuUI.Common;
using QLBH_BunifuUI.SQL;

namespace QLBH_BunifuUI.form
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Process(); //213123
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
                SQLInstance = cbbSqlServer.SelectedValue.ToString();
            }

            SQLInstance = "LIVINGROOM-PC";
            //DTO.Properties.Settings.Default.ShopTPTConnectionString =
            //        "Data Source=" + SQLInstance + "Initial Catalog=ShopTPT;Persist Security Info=True;User ID=s" +
            //        "a;Password=tpt";
            if (Helper.IsServerConnected("Data Source=" + SQLInstance + ";Initial Catalog=ShopTPT;Persist Security Info=True;User ID=s" +
                "a;Password=tpt"))
            {
                int result = CheckLogin(txtUsername.Text, Helper.Md5Encrypt(txtPassword.Text));
                if (result == 1)
                {
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
            try
            {
                return UserDao.Instance.FindSingleUser(userName, pass) != 0 ? 1 : 0;
            }
            catch (Exception)
            {
                return -1;
            }
            // return false;
            //return UserDao.Instance.FindSingleUser(userName, pass) != 0 ? true : false;
        }

        private void Process()
        {
            // Retrieve the enumerator instance and then the data.  
            // var instance = SqlDataSourceEnumerator.Instance;
            var table = FindSqlServerName.GetAllSqlServerName();
            string resul = "";
            cbbSqlServer.DataSource = table;


            cbbSqlServer.DisplayMember = "ServerName";
            cbbSqlServer.ValueMember = "ServerName";
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
            Process();
        }

       
    }
}
