using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace QLBH_BunifuUI.form
{
    partial class CfuFrmCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CfuFrmCreateUser));
            this.btnOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.radioBtnNu = new System.Windows.Forms.RadioButton();
            this.radioBtnNam = new System.Windows.Forms.RadioButton();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.card = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkStatus = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbbRoles = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.datePick = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHeader = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cfuCreateUserElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragControlCfuCU = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelForm.SuspendLayout();
            this.card.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(145)))), ((int)(((byte)(87)))));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.BorderRadius = 7;
            this.btnOK.ButtonText = "      OK";
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.DisabledColor = System.Drawing.Color.Gray;
            this.btnOK.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOK.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOK.Iconimage")));
            this.btnOK.Iconimage_right = null;
            this.btnOK.Iconimage_right_Selected = null;
            this.btnOK.Iconimage_Selected = null;
            this.btnOK.IconMarginLeft = 0;
            this.btnOK.IconMarginRight = 0;
            this.btnOK.IconRightVisible = true;
            this.btnOK.IconRightZoom = 0D;
            this.btnOK.IconVisible = true;
            this.btnOK.IconZoom = 60D;
            this.btnOK.IsTab = false;
            this.btnOK.Location = new System.Drawing.Point(492, 478);
            this.btnOK.Name = "btnOK";
            this.btnOK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(145)))), ((int)(((byte)(87)))));
            this.btnOK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.btnOK.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOK.selected = true;
            this.btnOK.Size = new System.Drawing.Size(148, 44);
            this.btnOK.TabIndex = 27;
            this.btnOK.Text = "      OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Textcolor = System.Drawing.Color.White;
            this.btnOK.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(145)))), ((int)(((byte)(87)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 7;
            this.btnClear.ButtonText = "      Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClear.Iconimage")));
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 60D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(264, 478);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(145)))), ((int)(((byte)(87)))));
            this.btnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(148, 44);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "      Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Textcolor = System.Drawing.Color.White;
            this.btnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(145)))), ((int)(((byte)(87)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 7;
            this.btnCancel.ButtonText = "      Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 60D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(43, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(145)))), ((int)(((byte)(87)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(148, 44);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "      Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radioBtnNu
            // 
            this.radioBtnNu.AutoSize = true;
            this.radioBtnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNu.Location = new System.Drawing.Point(453, 55);
            this.radioBtnNu.Name = "radioBtnNu";
            this.radioBtnNu.Size = new System.Drawing.Size(47, 24);
            this.radioBtnNu.TabIndex = 25;
            this.radioBtnNu.TabStop = true;
            this.radioBtnNu.Text = "Nữ";
            this.radioBtnNu.UseVisualStyleBackColor = true;
            // 
            // radioBtnNam
            // 
            this.radioBtnNam.AutoSize = true;
            this.radioBtnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNam.Location = new System.Drawing.Point(377, 55);
            this.radioBtnNam.Name = "radioBtnNam";
            this.radioBtnNam.Size = new System.Drawing.Size(60, 24);
            this.radioBtnNam.TabIndex = 24;
            this.radioBtnNam.TabStop = true;
            this.radioBtnNam.Text = "Nam";
            this.radioBtnNam.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.HintForeColor = System.Drawing.Color.Gray;
            this.txtPhone.HintText = "Nhập số điện thoại";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtPhone.LineThickness = 4;
            this.txtPhone.Location = new System.Drawing.Point(364, 203);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(280, 40);
            this.txtPhone.TabIndex = 23;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HintForeColor = System.Drawing.Color.Gray;
            this.txtAddress.HintText = "Nhập địa chỉ";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtAddress.LineThickness = 4;
            this.txtAddress.Location = new System.Drawing.Point(364, 117);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(280, 40);
            this.txtAddress.TabIndex = 22;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HintForeColor = System.Drawing.Color.Gray;
            this.txtEmail.HintText = "Nhập Email";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtEmail.LineThickness = 4;
            this.txtEmail.Location = new System.Drawing.Point(41, 284);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 40);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.HintForeColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.HintText = "Nhập mật khẩu";
            this.txtConfirmPassword.isPassword = true;
            this.txtConfirmPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.LineThickness = 4;
            this.txtConfirmPassword.Location = new System.Drawing.Point(41, 202);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(280, 40);
            this.txtConfirmPassword.TabIndex = 20;
            this.txtConfirmPassword.Text = "    ";
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.card);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 53);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(700, 547);
            this.panelForm.TabIndex = 3;
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.White;
            this.card.BorderRadius = 5;
            this.card.BottomSahddow = true;
            this.card.color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.card.Controls.Add(this.bunifuCustomLabel12);
            this.card.Controls.Add(this.chkStatus);
            this.card.Controls.Add(this.bunifuCustomLabel11);
            this.card.Controls.Add(this.cbbRoles);
            this.card.Controls.Add(this.bunifuCustomLabel10);
            this.card.Controls.Add(this.txtName);
            this.card.Controls.Add(this.bunifuCustomLabel9);
            this.card.Controls.Add(this.txtPassword);
            this.card.Controls.Add(this.btnOK);
            this.card.Controls.Add(this.btnClear);
            this.card.Controls.Add(this.btnCancel);
            this.card.Controls.Add(this.radioBtnNu);
            this.card.Controls.Add(this.radioBtnNam);
            this.card.Controls.Add(this.txtPhone);
            this.card.Controls.Add(this.txtAddress);
            this.card.Controls.Add(this.txtEmail);
            this.card.Controls.Add(this.txtConfirmPassword);
            this.card.Controls.Add(this.txtUsername);
            this.card.Controls.Add(this.datePick);
            this.card.Controls.Add(this.bunifuCustomLabel8);
            this.card.Controls.Add(this.bunifuCustomLabel7);
            this.card.Controls.Add(this.bunifuCustomLabel6);
            this.card.Controls.Add(this.bunifuCustomLabel5);
            this.card.Controls.Add(this.bunifuCustomLabel4);
            this.card.Controls.Add(this.bunifuCustomLabel3);
            this.card.Controls.Add(this.bunifuCustomLabel2);
            this.card.Controls.Add(this.bunifuCustomLabel1);
            this.card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card.LeftSahddow = false;
            this.card.Location = new System.Drawing.Point(0, 0);
            this.card.Name = "card";
            this.card.RightSahddow = true;
            this.card.ShadowDepth = 20;
            this.card.Size = new System.Drawing.Size(700, 547);
            this.card.TabIndex = 0;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(586, 55);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(75, 19);
            this.bunifuCustomLabel12.TabIndex = 35;
            this.bunifuCustomLabel12.Text = "Kích hoạt";
            // 
            // chkStatus
            // 
            this.chkStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkStatus.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkStatus.Checked = true;
            this.chkStatus.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkStatus.ForeColor = System.Drawing.Color.White;
            this.chkStatus.Location = new System.Drawing.Point(560, 55);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(20, 20);
            this.chkStatus.TabIndex = 34;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(534, 18);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(75, 19);
            this.bunifuCustomLabel11.TabIndex = 33;
            this.bunifuCustomLabel11.Text = "Trạng thái";
            // 
            // cbbRoles
            // 
            this.cbbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRoles.FormattingEnabled = true;
            this.cbbRoles.Location = new System.Drawing.Point(358, 284);
            this.cbbRoles.Name = "cbbRoles";
            this.cbbRoles.Size = new System.Drawing.Size(121, 28);
            this.cbbRoles.TabIndex = 32;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(353, 256);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(53, 19);
            this.bunifuCustomLabel10.TabIndex = 31;
            this.bunifuCustomLabel10.Text = "Quyền";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HintForeColor = System.Drawing.Color.Gray;
            this.txtName.HintText = "Nhập Họ Tên";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtName.LineThickness = 4;
            this.txtName.Location = new System.Drawing.Point(43, 381);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 40);
            this.txtName.TabIndex = 30;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(31, 353);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(77, 19);
            this.bunifuCustomLabel9.TabIndex = 29;
            this.bunifuCustomLabel9.Text = "Họ và Tên";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HintForeColor = System.Drawing.Color.Gray;
            this.txtPassword.HintText = "Nhập mật khẩu";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtPassword.LineThickness = 4;
            this.txtPassword.Location = new System.Drawing.Point(41, 117);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 40);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.Text = "    ";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HintForeColor = System.Drawing.Color.Gray;
            this.txtUsername.HintText = "Nhập tên đăng nhập";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtUsername.LineThickness = 4;
            this.txtUsername.Location = new System.Drawing.Point(41, 39);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(280, 40);
            this.txtUsername.TabIndex = 18;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // datePick
            // 
            this.datePick.BackColor = System.Drawing.Color.SeaGreen;
            this.datePick.BorderRadius = 0;
            this.datePick.ForeColor = System.Drawing.Color.White;
            this.datePick.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePick.FormatCustom = null;
            this.datePick.Location = new System.Drawing.Point(363, 381);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(280, 40);
            this.datePick.TabIndex = 16;
            this.datePick.Value = new System.DateTime(2017, 3, 17, 22, 16, 29, 220);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(354, 353);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(76, 19);
            this.bunifuCustomLabel8.TabIndex = 8;
            this.bunifuCustomLabel8.Text = "Ngày sinh";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(354, 178);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(99, 19);
            this.bunifuCustomLabel7.TabIndex = 7;
            this.bunifuCustomLabel7.Text = "Số điện thoại";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(354, 92);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(58, 19);
            this.bunifuCustomLabel6.TabIndex = 6;
            this.bunifuCustomLabel6.Text = "Địa chỉ";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(353, 18);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(70, 19);
            this.bunifuCustomLabel5.TabIndex = 5;
            this.bunifuCustomLabel5.Text = "Giới tính";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(29, 178);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(129, 19);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Nhập lại mật khẩu";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(29, 256);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(49, 19);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Email";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(31, 92);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 19);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Mật khẩu";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 19);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Tên đăng nhập";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(700, 53);
            this.panelMain.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.btnHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 47);
            this.panel2.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(667, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(27, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnHeader
            // 
            this.btnHeader.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeader.BorderRadius = 0;
            this.btnHeader.ButtonText = "Thên mới Nhân viên";
            this.btnHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeader.DisabledColor = System.Drawing.Color.Gray;
            this.btnHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeader.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHeader.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHeader.Iconimage")));
            this.btnHeader.Iconimage_right = null;
            this.btnHeader.Iconimage_right_Selected = null;
            this.btnHeader.Iconimage_Selected = null;
            this.btnHeader.IconMarginLeft = 0;
            this.btnHeader.IconMarginRight = 0;
            this.btnHeader.IconRightVisible = true;
            this.btnHeader.IconRightZoom = 0D;
            this.btnHeader.IconVisible = true;
            this.btnHeader.IconZoom = 90D;
            this.btnHeader.IsTab = false;
            this.btnHeader.Location = new System.Drawing.Point(4, 1);
            this.btnHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHeader.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnHeader.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHeader.selected = false;
            this.btnHeader.Size = new System.Drawing.Size(207, 44);
            this.btnHeader.TabIndex = 1;
            this.btnHeader.Text = "Thên mới Nhân viên";
            this.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeader.Textcolor = System.Drawing.Color.White;
            this.btnHeader.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cfuCreateUserElipse
            // 
            this.cfuCreateUserElipse.ElipseRadius = 5;
            this.cfuCreateUserElipse.TargetControl = this;
            // 
            // dragControlCfuCU
            // 
            this.dragControlCfuCU.Fixed = true;
            this.dragControlCfuCU.Horizontal = true;
            this.dragControlCfuCU.TargetControl = this.panel2;
            this.dragControlCfuCU.Vertical = true;
            // 
            // CfuFrmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CfuFrmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cfuFrmCreateUser";
            this.VisibleChanged += new System.EventHandler(this.CfuFrmCreateUser_VisibleChanged);
            this.panelForm.ResumeLayout(false);
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuFlatButton btnOK;
        private BunifuFlatButton btnClear;
        private BunifuFlatButton btnCancel;
        private RadioButton radioBtnNu;
        private RadioButton radioBtnNam;
        private BunifuMaterialTextbox txtPhone;
        private BunifuMaterialTextbox txtAddress;
        private BunifuMaterialTextbox txtEmail;
        private BunifuMaterialTextbox txtConfirmPassword;
        private Panel panelForm;
        private BunifuCards card;
        private BunifuMaterialTextbox txtUsername;
        private BunifuDatepicker datePick;
        private BunifuCustomLabel bunifuCustomLabel8;
        private BunifuCustomLabel bunifuCustomLabel7;
        private BunifuCustomLabel bunifuCustomLabel6;
        private BunifuCustomLabel bunifuCustomLabel5;
        private BunifuCustomLabel bunifuCustomLabel4;
        private BunifuCustomLabel bunifuCustomLabel3;
        private BunifuCustomLabel bunifuCustomLabel2;
        private BunifuCustomLabel bunifuCustomLabel1;
        private Panel panelMain;
        private BunifuElipse cfuCreateUserElipse;
        private BunifuDragControl dragControlCfuCU;
        private Panel panel2;
        private BunifuFlatButton btnHeader;
        private BunifuMaterialTextbox txtPassword;
        private BunifuCustomLabel bunifuCustomLabel10;
        private BunifuMaterialTextbox txtName;
        private BunifuCustomLabel bunifuCustomLabel9;
        private ComboBox cbbRoles;
        private BunifuImageButton bunifuImageButton1;
        private BunifuCustomLabel bunifuCustomLabel12;
        private BunifuCheckbox chkStatus;
        private BunifuCustomLabel bunifuCustomLabel11;
    }
}