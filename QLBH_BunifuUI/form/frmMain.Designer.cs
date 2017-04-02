using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;

namespace QLBH_BunifuUI.form
{
    partial class FrmMain
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.bunifuElipseFRMMain = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAbout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSetting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictrueBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.panelExit = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControlHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictrueBoxLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipseFRMMain
            // 
            this.bunifuElipseFRMMain.ElipseRadius = 3;
            this.bunifuElipseFRMMain.TargetControl = this;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnAbout);
            this.panelLeft.Controls.Add(this.btnSetting);
            this.panelLeft.Controls.Add(this.btnUser);
            this.panelLeft.Controls.Add(this.btnProductCategory);
            this.panelLeft.Controls.Add(this.btnProduct);
            this.panelLeft.Controls.Add(this.btnBill);
            this.panelLeft.Controls.Add(this.btnDashboard);
            this.panelLeft.Controls.Add(this.btnMenu);
            this.panelLeft.Controls.Add(this.pictrueBoxLogo);
            this.PanelTransition.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 35);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 665);
            this.panelLeft.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "     Đăng Xuất";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 60D;
            this.btnLogout.IsTab = true;
            this.btnLogout.Location = new System.Drawing.Point(0, 615);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(250, 50);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "     Đăng Xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.BorderRadius = 0;
            this.btnAbout.ButtonText = "    GIỚI THIỆU";
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnAbout, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnAbout, BunifuAnimatorNS.DecorationType.None);
            this.btnAbout.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAbout.Iconimage")));
            this.btnAbout.Iconimage_right = null;
            this.btnAbout.Iconimage_right_Selected = null;
            this.btnAbout.Iconimage_Selected = null;
            this.btnAbout.IconMarginLeft = 0;
            this.btnAbout.IconMarginRight = 0;
            this.btnAbout.IconRightVisible = true;
            this.btnAbout.IconRightZoom = 0D;
            this.btnAbout.IconVisible = true;
            this.btnAbout.IconZoom = 60D;
            this.btnAbout.IsTab = true;
            this.btnAbout.Location = new System.Drawing.Point(0, 414);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAbout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAbout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAbout.selected = false;
            this.btnAbout.Size = new System.Drawing.Size(250, 50);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "    GIỚI THIỆU";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Textcolor = System.Drawing.Color.White;
            this.btnAbout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.BorderRadius = 0;
            this.btnSetting.ButtonText = "  CÀI ĐẶT";
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnSetting, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnSetting, BunifuAnimatorNS.DecorationType.None);
            this.btnSetting.DisabledColor = System.Drawing.Color.Gray;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSetting.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSetting.Iconimage")));
            this.btnSetting.Iconimage_right = null;
            this.btnSetting.Iconimage_right_Selected = null;
            this.btnSetting.Iconimage_Selected = null;
            this.btnSetting.IconMarginLeft = 0;
            this.btnSetting.IconMarginRight = 0;
            this.btnSetting.IconRightVisible = true;
            this.btnSetting.IconRightZoom = 0D;
            this.btnSetting.IconVisible = true;
            this.btnSetting.IconZoom = 60D;
            this.btnSetting.IsTab = true;
            this.btnSetting.Location = new System.Drawing.Point(0, 364);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSetting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSetting.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSetting.selected = false;
            this.btnSetting.Size = new System.Drawing.Size(250, 50);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "  CÀI ĐẶT";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Textcolor = System.Drawing.Color.White;
            this.btnSetting.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnUser
            // 
            this.btnUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUser.BorderRadius = 0;
            this.btnUser.ButtonText = "  NHÂN VIÊN";
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnUser, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnUser, BunifuAnimatorNS.DecorationType.None);
            this.btnUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUser.Iconimage")));
            this.btnUser.Iconimage_right = null;
            this.btnUser.Iconimage_right_Selected = null;
            this.btnUser.Iconimage_Selected = null;
            this.btnUser.IconMarginLeft = 0;
            this.btnUser.IconMarginRight = 0;
            this.btnUser.IconRightVisible = true;
            this.btnUser.IconRightZoom = 0D;
            this.btnUser.IconVisible = true;
            this.btnUser.IconZoom = 60D;
            this.btnUser.IsTab = true;
            this.btnUser.Location = new System.Drawing.Point(0, 313);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUser.Name = "btnUser";
            this.btnUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUser.selected = false;
            this.btnUser.Size = new System.Drawing.Size(250, 50);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "  NHÂN VIÊN";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Textcolor = System.Drawing.Color.White;
            this.btnUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnProductCategory
            // 
            this.btnProductCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnProductCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnProductCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductCategory.BorderRadius = 0;
            this.btnProductCategory.ButtonText = "  DANH MỤC SẢN PHẨM";
            this.btnProductCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnProductCategory, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnProductCategory, BunifuAnimatorNS.DecorationType.None);
            this.btnProductCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductCategory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductCategory.ForeColor = System.Drawing.Color.White;
            this.btnProductCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductCategory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductCategory.Iconimage")));
            this.btnProductCategory.Iconimage_right = null;
            this.btnProductCategory.Iconimage_right_Selected = null;
            this.btnProductCategory.Iconimage_Selected = null;
            this.btnProductCategory.IconMarginLeft = 0;
            this.btnProductCategory.IconMarginRight = 0;
            this.btnProductCategory.IconRightVisible = true;
            this.btnProductCategory.IconRightZoom = 0D;
            this.btnProductCategory.IconVisible = true;
            this.btnProductCategory.IconZoom = 60D;
            this.btnProductCategory.IsTab = true;
            this.btnProductCategory.Location = new System.Drawing.Point(0, 263);
            this.btnProductCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductCategory.Name = "btnProductCategory";
            this.btnProductCategory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnProductCategory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnProductCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProductCategory.selected = false;
            this.btnProductCategory.Size = new System.Drawing.Size(250, 50);
            this.btnProductCategory.TabIndex = 4;
            this.btnProductCategory.Text = "  DANH MỤC SẢN PHẨM";
            this.btnProductCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductCategory.Textcolor = System.Drawing.Color.White;
            this.btnProductCategory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductCategory.Click += new System.EventHandler(this.btnProductCategory_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduct.BorderRadius = 0;
            this.btnProduct.ButtonText = "  SẢN PHẨM";
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnProduct, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnProduct, BunifuAnimatorNS.DecorationType.None);
            this.btnProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProduct.Iconimage")));
            this.btnProduct.Iconimage_right = null;
            this.btnProduct.Iconimage_right_Selected = null;
            this.btnProduct.Iconimage_Selected = null;
            this.btnProduct.IconMarginLeft = 0;
            this.btnProduct.IconMarginRight = 0;
            this.btnProduct.IconRightVisible = true;
            this.btnProduct.IconRightZoom = 0D;
            this.btnProduct.IconVisible = true;
            this.btnProduct.IconZoom = 60D;
            this.btnProduct.IsTab = true;
            this.btnProduct.Location = new System.Drawing.Point(0, 213);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProduct.selected = false;
            this.btnProduct.Size = new System.Drawing.Size(250, 50);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "  SẢN PHẨM";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Textcolor = System.Drawing.Color.White;
            this.btnProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnBill
            // 
            this.btnBill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBill.BorderRadius = 0;
            this.btnBill.ButtonText = "  HÓA ĐƠN";
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnBill, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnBill, BunifuAnimatorNS.DecorationType.None);
            this.btnBill.DisabledColor = System.Drawing.Color.Gray;
            this.btnBill.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBill.Iconimage")));
            this.btnBill.Iconimage_right = null;
            this.btnBill.Iconimage_right_Selected = null;
            this.btnBill.Iconimage_Selected = null;
            this.btnBill.IconMarginLeft = 0;
            this.btnBill.IconMarginRight = 0;
            this.btnBill.IconRightVisible = true;
            this.btnBill.IconRightZoom = 0D;
            this.btnBill.IconVisible = true;
            this.btnBill.IconZoom = 60D;
            this.btnBill.IsTab = true;
            this.btnBill.Location = new System.Drawing.Point(0, 162);
            this.btnBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBill.Name = "btnBill";
            this.btnBill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnBill.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBill.selected = false;
            this.btnBill.Size = new System.Drawing.Size(250, 50);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "  HÓA ĐƠN";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Textcolor = System.Drawing.Color.White;
            this.btnBill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "  THỐNG KÊ";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnDashboard, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnDashboard, BunifuAnimatorNS.DecorationType.None);
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 60D;
            this.btnDashboard.IsTab = true;
            this.btnDashboard.Location = new System.Drawing.Point(0, 112);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = true;
            this.btnDashboard.Size = new System.Drawing.Size(250, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "  THỐNG KÊ";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.PanelTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(209, 18);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 20;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictrueBoxLogo
            // 
            this.LogoTransition.SetDecoration(this.pictrueBoxLogo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.pictrueBoxLogo, BunifuAnimatorNS.DecorationType.None);
            this.pictrueBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictrueBoxLogo.Image")));
            this.pictrueBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictrueBoxLogo.Name = "pictrueBoxLogo";
            this.pictrueBoxLogo.Size = new System.Drawing.Size(203, 95);
            this.pictrueBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictrueBoxLogo.TabIndex = 0;
            this.pictrueBoxLogo.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.pictureBoxTitle);
            this.panelHeader.Controls.Add(this.panelExit);
            this.PanelTransition.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1326, 35);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.LogoTransition.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(45, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 22);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "DASHBOARD - TPT";
            // 
            // pictureBoxTitle
            // 
            this.LogoTransition.SetDecoration(this.pictureBoxTitle, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.pictureBoxTitle, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTitle.Image")));
            this.pictureBoxTitle.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(36, 29);
            this.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitle.TabIndex = 5;
            this.pictureBoxTitle.TabStop = false;
            // 
            // panelExit
            // 
            this.panelExit.BackColor = System.Drawing.Color.Transparent;
            this.panelExit.Controls.Add(this.btnClose);
            this.panelExit.Controls.Add(this.btnMaximize);
            this.panelExit.Controls.Add(this.btnMinimize);
            this.PanelTransition.SetDecoration(this.panelExit, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panelExit, BunifuAnimatorNS.DecorationType.None);
            this.panelExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelExit.Location = new System.Drawing.Point(1167, 0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(159, 35);
            this.panelExit.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.PanelTransition.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(113, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.PanelTransition.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.ImageActive = null;
            this.btnMaximize.Location = new System.Drawing.Point(67, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(43, 30);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Zoom = 20;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.PanelTransition.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(20, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 20;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControlHeader
            // 
            this.bunifuDragControlHeader.Fixed = true;
            this.bunifuDragControlHeader.Horizontal = true;
            this.bunifuDragControlHeader.TargetControl = this.panelHeader;
            this.bunifuDragControlHeader.Vertical = true;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.LogoTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation2;
            this.LogoTransition.MaxAnimationTime = 1000;
            this.LogoTransition.TimeStep = 0.01F;
            // 
            // panelMain
            // 
            this.PanelTransition.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 35);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1076, 665);
            this.panelMain.TabIndex = 2;
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 0.3F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation1;
            this.PanelTransition.MaxAnimationTime = 1000;
            this.PanelTransition.TimeStep = 0.01F;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1326, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictrueBoxLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuElipse bunifuElipseFRMMain;
        private Panel panelLeft;
        private PictureBox pictrueBoxLogo;
        private Panel panelHeader;
        private BunifuCustomLabel lblTitle;
        private PictureBox pictureBoxTitle;
        private BunifuDragControl bunifuDragControl1;
        private BunifuDragControl bunifuDragControlHeader;
        private BunifuImageButton btnMenu;
        private Panel panelExit;
        private BunifuImageButton btnClose;
        private BunifuImageButton btnMaximize;
        private BunifuImageButton btnMinimize;
        private Panel panelMain;
        private BunifuTransition PanelTransition;
        private BunifuTransition LogoTransition;
        private BunifuFlatButton btnAbout;
        private BunifuFlatButton btnSetting;
        private BunifuFlatButton btnUser;
        private BunifuFlatButton btnProductCategory;
        private BunifuFlatButton btnProduct;
        private BunifuFlatButton btnBill;
        private BunifuFlatButton btnDashboard;
        private BunifuFlatButton btnLogout;
    }
}

