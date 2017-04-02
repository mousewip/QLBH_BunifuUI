using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace QLBH_BunifuUI.form
{
    partial class ChildFrmUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildFrmUser));
            this.childFrmUserElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDeleteUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelDTGV = new System.Windows.Forms.Panel();
            this.dtgvUser2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipFrmUser = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.radioBtnNam = new System.Windows.Forms.RadioButton();
            this.radioBtnNu = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).BeginInit();
            this.panelDTGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser2)).BeginInit();
            this.SuspendLayout();
            // 
            // childFrmUserElipse
            // 
            this.childFrmUserElipse.ElipseRadius = 0;
            this.childFrmUserElipse.TargetControl = this;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.txtSearch);
            this.panelControl.Controls.Add(this.btnRefresh);
            this.panelControl.Controls.Add(this.btnDeleteUser);
            this.panelControl.Controls.Add(this.btnSearch);
            this.panelControl.Controls.Add(this.btnAddUser);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1076, 73);
            this.panelControl.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSearch.BorderColorIdle = System.Drawing.Color.ForestGreen;
            this.txtSearch.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSearch.BorderThickness = 3;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.isPassword = false;
            this.txtSearch.Location = new System.Drawing.Point(137, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 47);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.Location = new System.Drawing.Point(619, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 50);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Zoom = 15;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.ImageActive = null;
            this.btnDeleteUser.Location = new System.Drawing.Point(746, 9);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.TabStop = false;
            this.btnDeleteUser.Zoom = 15;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(469, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 15;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageActive = null;
            this.btnAddUser.Location = new System.Drawing.Point(12, 13);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(50, 50);
            this.btnAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.TabStop = false;
            this.btnAddUser.Zoom = 15;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panelDTGV
            // 
            this.panelDTGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDTGV.Controls.Add(this.dtgvUser2);
            this.panelDTGV.Location = new System.Drawing.Point(30, 91);
            this.panelDTGV.Name = "panelDTGV";
            this.panelDTGV.Size = new System.Drawing.Size(400, 562);
            this.panelDTGV.TabIndex = 2;
            // 
            // dtgvUser2
            // 
            this.dtgvUser2.AllowUserToAddRows = false;
            this.dtgvUser2.AllowUserToDeleteRows = false;
            this.dtgvUser2.AllowUserToOrderColumns = true;
            this.dtgvUser2.AllowUserToResizeColumns = false;
            this.dtgvUser2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dtgvUser2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvUser2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dtgvUser2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvUser2.BackgroundColor = System.Drawing.Color.White;
            this.dtgvUser2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvUser2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUser2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvUser2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tenNV,
            this.tk});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvUser2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvUser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvUser2.DoubleBuffered = true;
            this.dtgvUser2.EnableHeadersVisualStyles = false;
            this.dtgvUser2.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvUser2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.dtgvUser2.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvUser2.Location = new System.Drawing.Point(0, 0);
            this.dtgvUser2.Name = "dtgvUser2";
            this.dtgvUser2.ReadOnly = true;
            this.dtgvUser2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUser2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvUser2.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dtgvUser2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvUser2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvUser2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvUser2.ShowEditingIcon = false;
            this.dtgvUser2.Size = new System.Drawing.Size(400, 562);
            this.dtgvUser2.TabIndex = 13;
            this.dtgvUser2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUser2_CellClick);
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.manv.DataPropertyName = "UserID";
            this.manv.FillWeight = 6F;
            this.manv.HeaderText = "ID";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.manv.Width = 70;
            // 
            // tenNV
            // 
            this.tenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tenNV.DataPropertyName = "FullName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tenNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.tenNV.FillWeight = 11.52756F;
            this.tenNV.HeaderText = "Họ Tên";
            this.tenNV.Name = "tenNV";
            this.tenNV.ReadOnly = true;
            this.tenNV.Width = 200;
            // 
            // tk
            // 
            this.tk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tk.DataPropertyName = "UserName";
            this.tk.FillWeight = 0.4724407F;
            this.tk.HeaderText = "Tài Khoản";
            this.tk.Name = "tk";
            this.tk.ReadOnly = true;
            this.tk.Width = 130;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Hủy";
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
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(677, 547);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.BorderRadius = 0;
            this.btnAccept.ButtonText = "Xác nhận";
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccept.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccept.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccept.Iconimage")));
            this.btnAccept.Iconimage_right = null;
            this.btnAccept.Iconimage_right_Selected = null;
            this.btnAccept.Iconimage_Selected = null;
            this.btnAccept.IconMarginLeft = 0;
            this.btnAccept.IconMarginRight = 0;
            this.btnAccept.IconRightVisible = true;
            this.btnAccept.IconRightZoom = 0D;
            this.btnAccept.IconVisible = true;
            this.btnAccept.IconZoom = 90D;
            this.btnAccept.IsTab = false;
            this.btnAccept.Location = new System.Drawing.Point(850, 547);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccept.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAccept.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccept.selected = false;
            this.btnAccept.Size = new System.Drawing.Size(140, 40);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Textcolor = System.Drawing.Color.White;
            this.btnAccept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Cập nhật";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(483, 547);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(140, 40);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label6.Location = new System.Drawing.Point(479, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "SDT";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(619, 376);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(263, 26);
            this.txtPhone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label5.Location = new System.Drawing.Point(479, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label4.Location = new System.Drawing.Point(479, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label3.Location = new System.Drawing.Point(479, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(619, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(263, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(619, 147);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(263, 26);
            this.txtFullName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(479, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Họ tên";
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(619, 100);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(263, 26);
            this.txtUserID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(479, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.lblNewPass.Location = new System.Drawing.Point(479, 483);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(116, 20);
            this.lblNewPass.TabIndex = 41;
            this.lblNewPass.Text = "Mật khẩu mới";
            this.lblNewPass.Visible = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(619, 480);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(263, 26);
            this.txtNewPassword.TabIndex = 9;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.Visible = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.lblPass.Location = new System.Drawing.Point(479, 432);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(83, 20);
            this.lblPass.TabIndex = 39;
            this.lblPass.Text = "Mật khẩu";
            this.lblPass.Visible = false;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(619, 429);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(263, 26);
            this.txtCurrentPassword.TabIndex = 8;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.Visible = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangePassword.BorderRadius = 0;
            this.btnChangePassword.ButtonText = "Thay đổi mật khẩu";
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.DisabledColor = System.Drawing.Color.Gray;
            this.btnChangePassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Iconimage")));
            this.btnChangePassword.Iconimage_right = null;
            this.btnChangePassword.Iconimage_right_Selected = null;
            this.btnChangePassword.Iconimage_Selected = null;
            this.btnChangePassword.IconMarginLeft = 0;
            this.btnChangePassword.IconMarginRight = 0;
            this.btnChangePassword.IconRightVisible = true;
            this.btnChangePassword.IconRightZoom = 0D;
            this.btnChangePassword.IconVisible = true;
            this.btnChangePassword.IconZoom = 90D;
            this.btnChangePassword.IsTab = false;
            this.btnChangePassword.Location = new System.Drawing.Point(483, 426);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangePassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnChangePassword.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChangePassword.selected = false;
            this.btnChangePassword.Size = new System.Drawing.Size(189, 26);
            this.btnChangePassword.TabIndex = 42;
            this.btnChangePassword.Text = "Thay đổi mật khẩu";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Textcolor = System.Drawing.Color.White;
            this.btnChangePassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Visible = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // radioBtnNam
            // 
            this.radioBtnNam.AutoSize = true;
            this.radioBtnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNam.Location = new System.Drawing.Point(619, 247);
            this.radioBtnNam.Name = "radioBtnNam";
            this.radioBtnNam.Size = new System.Drawing.Size(60, 24);
            this.radioBtnNam.TabIndex = 4;
            this.radioBtnNam.TabStop = true;
            this.radioBtnNam.Text = "Nam";
            this.radioBtnNam.UseVisualStyleBackColor = true;
            // 
            // radioBtnNu
            // 
            this.radioBtnNu.AutoSize = true;
            this.radioBtnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNu.Location = new System.Drawing.Point(719, 247);
            this.radioBtnNu.Name = "radioBtnNu";
            this.radioBtnNu.Size = new System.Drawing.Size(47, 24);
            this.radioBtnNu.TabIndex = 5;
            this.radioBtnNu.TabStop = true;
            this.radioBtnNu.Text = "Nữ";
            this.radioBtnNu.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(619, 290);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '*';
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(263, 53);
            this.txtAddress.TabIndex = 43;
            this.txtAddress.UseSystemPasswordChar = true;
            // 
            // ChildFrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 665);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.radioBtnNu);
            this.Controls.Add(this.radioBtnNam);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDTGV);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildFrmUser";
            this.Text = "childFrmUser";
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).EndInit();
            this.panelDTGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuElipse childFrmUserElipse;
        private Panel panelControl;
        private BunifuImageButton btnAddUser;
        private Panel panelDTGV;
        private BunifuCustomDataGrid dtgvUser2;
        private BunifuImageButton btnDeleteUser;
        private BunifuImageButton btnSearch;
        private BunifuImageButton btnRefresh;
        private ToolTip toolTipFrmUser;
        private BunifuMetroTextbox txtSearch;
        private BunifuFlatButton btnCancel;
        private BunifuFlatButton btnAccept;
        private BunifuFlatButton btnUpdate;
        private Label label6;
        private TextBox txtPhone;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtUserID;
        private Label label1;
        private BunifuFlatButton btnChangePassword;
        private Label lblNewPass;
        private TextBox txtNewPassword;
        private Label lblPass;
        private TextBox txtCurrentPassword;
        private RadioButton radioBtnNu;
        private RadioButton radioBtnNam;
        private DataGridViewTextBoxColumn manv;
        private DataGridViewTextBoxColumn tenNV;
        private DataGridViewTextBoxColumn tk;
        private TextBox txtAddress;
    }
}