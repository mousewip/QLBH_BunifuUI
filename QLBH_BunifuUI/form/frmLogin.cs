using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DTO;
using DTO.DAO;
using QLBH_BunifuUI.Common;

namespace QLBH_BunifuUI.form
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            Process();
            panelSQLServer.Visible = false;
            btnMinus.Visible = false;
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            
            btnMinus.Visible = false;
            btnPlus.Visible = true;
            panelSQLServer.Height = 0;
            var pnt = new Point
            {
                X = btnLogin.Location.X,
                Y = btnLogin.Location.Y - 74
            };
            btnLogin.Location = pnt;
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            btnPlus.Visible = false;
            btnMinus.Visible = true;
            panelSQLServer.Visible = true;
            var pnt = new Point
            {
                X = btnLogin.Location.X,
                Y = btnLogin.Location.Y + 74
            };
            btnLogin.Location = pnt;

            panelSQLServer.Height = 74;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }


        private void Login()
        {

            if (CheckLogin(txtUsername.Text, Helper.Md5Encrypt(txtPassword.Text)))
            {
                // Opacity = 0.8;
                //timer_Loader.Start();
                //panelWait.Visible = true;
                //loader.Visible = true;
                //lblLogin.Visible = true;
                Hide();
                Splash.frmMain.ShowDialog();
                Show();


            }
            else
            {
                MessageBox.Show(@"Sai tên đăng nhập hoặc mật khẩu", @"Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool CheckLogin(string userName, string pass)
        {
            return UserDao.Instance.FindSingleUser(userName, pass) != 0 ? true : false;
        }

        /*private void timer_Loader_Tick(object sender, EventArgs e)
        {
            timer_Loader.Stop();
            
           // panelWait.Visible = false;
          //  loader.Visible = false;
           // lblLogin.Visible = false;
            Opacity = 1;
            
            Hide();
            Splash.frmMain.ShowDialog();
            Show();
        }*/
        
        private void Process()
        {
            // Retrieve the enumerator instance and then the data.  
            var instance = SqlDataSourceEnumerator.Instance;
            var table = instance.GetDataSources();

            // Display the contents of the table.  
            var arr = DisplayData(table);
            foreach (var a in arr)
                drlSQLServer.AddItem(a);
        }

        private IEnumerable<string> DisplayData(DataTable table)
        {
            return (from DataRow row in table.Rows select row[0].ToString()).ToList();
        }

        private void drlSQLServer_onItemSelected(object sender, EventArgs e)
        {
            var dataSource = drlSQLServer.selectedValue;

            DTO.Properties.Settings.Default.ShopTPTConnectionString = "Data Source="+dataSource+";Initial Catalog=ShopTPT;Persist Security Info=True;User ID=" +
            "sa;Password=tpt";
           
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                Login();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
            
        }
    }
}
