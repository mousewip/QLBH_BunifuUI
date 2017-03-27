using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace QLBH_BunifuUI.form
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panelLogin = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMinus = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPlus = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelSQLServer = new System.Windows.Forms.Panel();
            this.lblSQLServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.drlSQLServer = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblOption = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.imageFrmLogin = new System.Windows.Forms.PictureBox();
            this.imagePass = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.imageUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipseFRMLogin = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControlFRMLogin = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer_Loader = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).BeginInit();
            this.panelSQLServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFrmLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogin.BackgroundImage")));
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.btnMinus);
            this.panelLogin.Controls.Add(this.btnPlus);
            this.panelLogin.Controls.Add(this.panelSQLServer);
            this.panelLogin.Controls.Add(this.lblOption);
            this.panelLogin.Controls.Add(this.btnExit);
            this.panelLogin.Controls.Add(this.imageFrmLogin);
            this.panelLogin.Controls.Add(this.imagePass);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.imageUser);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.GradientBottomLeft = System.Drawing.Color.Orchid;
            this.panelLogin.GradientBottomRight = System.Drawing.Color.Turquoise;
            this.panelLogin.GradientTopLeft = System.Drawing.Color.DarkMagenta;
            this.panelLogin.GradientTopRight = System.Drawing.Color.SteelBlue;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Quality = 10;
            this.panelLogin.Size = new System.Drawing.Size(398, 506);
            this.panelLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(43)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.ButtonText = "ĐĂNG NHẬP";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogin.Iconimage")));
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 90D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(92, 382);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(43)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = true;
            this.btnLogin.Size = new System.Drawing.Size(200, 40);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.ImageActive = null;
            this.btnMinus.Location = new System.Drawing.Point(49, 297);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(22, 22);
            this.btnMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinus.TabIndex = 19;
            this.btnMinus.TabStop = false;
            this.btnMinus.Visible = false;
            this.btnMinus.Zoom = 0;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnPlus.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus.Image")));
            this.btnPlus.ImageActive = null;
            this.btnPlus.Location = new System.Drawing.Point(49, 297);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(22, 22);
            this.btnPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlus.TabIndex = 18;
            this.btnPlus.TabStop = false;
            this.btnPlus.Zoom = 0;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // panelSQLServer
            // 
            this.panelSQLServer.BackColor = System.Drawing.Color.Transparent;
            this.panelSQLServer.Controls.Add(this.lblSQLServer);
            this.panelSQLServer.Controls.Add(this.drlSQLServer);
            this.panelSQLServer.Location = new System.Drawing.Point(55, 325);
            this.panelSQLServer.Name = "panelSQLServer";
            this.panelSQLServer.Size = new System.Drawing.Size(278, 0);
            this.panelSQLServer.TabIndex = 17;
            // 
            // lblSQLServer
            // 
            this.lblSQLServer.Activecolor = System.Drawing.Color.Transparent;
            this.lblSQLServer.BackColor = System.Drawing.Color.Transparent;
            this.lblSQLServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblSQLServer.BorderRadius = 0;
            this.lblSQLServer.ButtonText = "  Chọn SQL Server Name";
            this.lblSQLServer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSQLServer.DisabledColor = System.Drawing.Color.Gray;
            this.lblSQLServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSQLServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblSQLServer.Iconcolor = System.Drawing.Color.Transparent;
            this.lblSQLServer.Iconimage = ((System.Drawing.Image)(resources.GetObject("lblSQLServer.Iconimage")));
            this.lblSQLServer.Iconimage_right = null;
            this.lblSQLServer.Iconimage_right_Selected = null;
            this.lblSQLServer.Iconimage_Selected = null;
            this.lblSQLServer.IconMarginLeft = 0;
            this.lblSQLServer.IconMarginRight = 0;
            this.lblSQLServer.IconRightVisible = true;
            this.lblSQLServer.IconRightZoom = 0D;
            this.lblSQLServer.IconVisible = true;
            this.lblSQLServer.IconZoom = 60D;
            this.lblSQLServer.IsTab = false;
            this.lblSQLServer.Location = new System.Drawing.Point(0, 0);
            this.lblSQLServer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblSQLServer.Name = "lblSQLServer";
            this.lblSQLServer.Normalcolor = System.Drawing.Color.Transparent;
            this.lblSQLServer.OnHovercolor = System.Drawing.Color.Transparent;
            this.lblSQLServer.OnHoverTextColor = System.Drawing.Color.White;
            this.lblSQLServer.selected = false;
            this.lblSQLServer.Size = new System.Drawing.Size(278, 36);
            this.lblSQLServer.TabIndex = 0;
            this.lblSQLServer.TabStop = false;
            this.lblSQLServer.Text = "  Chọn SQL Server Name";
            this.lblSQLServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSQLServer.Textcolor = System.Drawing.Color.White;
            this.lblSQLServer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // drlSQLServer
            // 
            this.drlSQLServer.BackColor = System.Drawing.Color.LightGray;
            this.drlSQLServer.BorderRadius = 3;
            this.drlSQLServer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drlSQLServer.ForeColor = System.Drawing.Color.Black;
            this.drlSQLServer.Items = new string[0];
            this.drlSQLServer.Location = new System.Drawing.Point(27, 40);
            this.drlSQLServer.Margin = new System.Windows.Forms.Padding(5);
            this.drlSQLServer.Name = "drlSQLServer";
            this.drlSQLServer.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.drlSQLServer.onHoverColor = System.Drawing.Color.Silver;
            this.drlSQLServer.selectedIndex = -1;
            this.drlSQLServer.Size = new System.Drawing.Size(246, 29);
            this.drlSQLServer.TabIndex = 22;
            this.drlSQLServer.onItemSelected += new System.EventHandler(this.drlSQLServer_onItemSelected);
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.BackColor = System.Drawing.Color.Transparent;
            this.lblOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.ForeColor = System.Drawing.Color.White;
            this.lblOption.Location = new System.Drawing.Point(78, 297);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(73, 20);
            this.lblOption.TabIndex = 16;
            this.lblOption.Text = "Tùy chọn";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(366, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 13;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imageFrmLogin
            // 
            this.imageFrmLogin.BackColor = System.Drawing.Color.Transparent;
            this.imageFrmLogin.Image = ((System.Drawing.Image)(resources.GetObject("imageFrmLogin.Image")));
            this.imageFrmLogin.Location = new System.Drawing.Point(140, 22);
            this.imageFrmLogin.Name = "imageFrmLogin";
            this.imageFrmLogin.Size = new System.Drawing.Size(135, 130);
            this.imageFrmLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageFrmLogin.TabIndex = 12;
            this.imageFrmLogin.TabStop = false;
            // 
            // imagePass
            // 
            this.imagePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(183)))));
            this.imagePass.Image = ((System.Drawing.Image)(resources.GetObject("imagePass.Image")));
            this.imagePass.ImageActive = null;
            this.imagePass.Location = new System.Drawing.Point(55, 249);
            this.imagePass.Name = "imagePass";
            this.imagePass.Size = new System.Drawing.Size(30, 30);
            this.imagePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePass.TabIndex = 9;
            this.imagePass.TabStop = false;
            this.imagePass.Zoom = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(183)))));
            this.txtPassword.BorderColorFocused = System.Drawing.Color.White;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(47, 241);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.txtPassword.Size = new System.Drawing.Size(301, 45);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "123456";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // imageUser
            // 
            this.imageUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(183)))));
            this.imageUser.Image = ((System.Drawing.Image)(resources.GetObject("imageUser.Image")));
            this.imageUser.ImageActive = null;
            this.imageUser.Location = new System.Drawing.Point(55, 194);
            this.imageUser.Name = "imageUser";
            this.imageUser.Size = new System.Drawing.Size(30, 30);
            this.imageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageUser.TabIndex = 8;
            this.imageUser.TabStop = false;
            this.imageUser.Zoom = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(183)))));
            this.txtUsername.BorderColorFocused = System.Drawing.Color.White;
            this.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtUsername.BorderThickness = 1;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(47, 186);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.txtUsername.Size = new System.Drawing.Size(301, 45);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.Text = "admin";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // bunifuElipseFRMLogin
            // 
            this.bunifuElipseFRMLogin.ElipseRadius = 5;
            this.bunifuElipseFRMLogin.TargetControl = this;
            // 
            // bunifuDragControlFRMLogin
            // 
            this.bunifuDragControlFRMLogin.Fixed = true;
            this.bunifuDragControlFRMLogin.Horizontal = true;
            this.bunifuDragControlFRMLogin.TargetControl = this.panelLogin;
            this.bunifuDragControlFRMLogin.Vertical = true;
            // 
            // timer_Loader
            // 
            this.timer_Loader.Interval = 200;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 506);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).EndInit();
            this.panelSQLServer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFrmLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuGradientPanel panelLogin;
        private BunifuElipse bunifuElipseFRMLogin;
        private BunifuImageButton imagePass;
        private BunifuMetroTextbox txtPassword;
        private BunifuImageButton imageUser;
        private BunifuMetroTextbox txtUsername;
        private PictureBox imageFrmLogin;
        private BunifuDragControl bunifuDragControlFRMLogin;
        private BunifuImageButton btnExit;
        private BunifuCustomLabel lblOption;
        private Panel panelSQLServer;
        private BunifuImageButton btnPlus;
        private BunifuImageButton btnMinus;
        private BunifuFlatButton lblSQLServer;
        private BunifuFlatButton btnLogin;
        private Timer timer_Loader;
        private ImageList imageList1;
        private BunifuDropdown drlSQLServer;
    }
}