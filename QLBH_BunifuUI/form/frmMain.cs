using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using QLBH_BunifuUI.Common;

namespace QLBH_BunifuUI.form
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            const string message = "Bạn thực sự muốn thoát chương trình?";
            const string caption = "Exit Program";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelLeft.Width == 50)
            {
                panelLeft.Visible = true;
                panelLeft.Width = 200;
                LogoTransition.ShowSync(pictrueBoxLogo);
            }
            else
            {
                LogoTransition.Hide(pictrueBoxLogo);
                panelLeft.Visible = false;
                panelLeft.Width = 50;
                PanelTransition.ShowSync(panelLeft);
            }
        }


        private void ChangTitle(BunifuFlatButton btn)
        {
            lblTitle.Text = btn.Text.Trim();
            pictureBoxTitle.Image = btn.Iconimage;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            ChangTitle(btnDashboard);
            panelMain.Controls.Clear();
            Splash.cfd.TopLevel = false;
            panelMain.Controls.Add(Splash.cfd);
            Splash.cfd.Dock = DockStyle.Fill;
            Splash.cfd.Show(); 
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ChangTitle(btnBill);
            panelMain.Controls.Clear();
            Splash.cfb.TopLevel = false;
            panelMain.Controls.Add(Splash.cfb);
            Splash.cfb.Dock = DockStyle.Fill;
            Splash.cfb.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ChangTitle(btnProduct);
            panelMain.Controls.Clear();
            Splash.cfp.TopLevel = false;
            panelMain.Controls.Add(Splash.cfp);
            Splash.cfp.Dock = DockStyle.Fill;
            Splash.cfp.Show();
        }

        private void btnProductCategory_Click(object sender, EventArgs e)
        {
            ChangTitle(btnProductCategory);
            panelMain.Controls.Clear();
            Splash.cfpc.TopLevel = false;
            panelMain.Controls.Add(Splash.cfpc);
            Splash.cfpc.Dock = DockStyle.Fill;
            Splash.cfpc.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ChangTitle(btnUser);
            panelMain.Controls.Clear();
            Splash.cfu.TopLevel = false;
            panelMain.Controls.Add(Splash.cfu);
            Splash.cfu.Dock = DockStyle.Fill;
            Splash.cfu.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ChangTitle(btnSetting);
            panelMain.Controls.Clear();
            Splash.cfs.TopLevel = false;
            panelMain.Controls.Add(Splash.cfs);
            Splash.cfs.Dock = DockStyle.Fill;
            Splash.cfs.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ChangTitle(btnAbout);
            panelMain.Controls.Clear();
            Splash.cfa.TopLevel = false;
            panelMain.Controls.Add(Splash.cfa);
            Splash.cfa.Dock = DockStyle.Fill;
            Splash.cfa.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            const string message = "Bạn thực sự muốn đăng xuất khỏi phiên làm việc?";
            const string caption = "Logout Session";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
