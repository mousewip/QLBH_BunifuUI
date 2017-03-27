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
            this.btnEditUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelDTGV = new System.Windows.Forms.Panel();
            this.dtgvUser2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipFrmUser = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).BeginInit();
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
            this.panelControl.Controls.Add(this.btnEditUser);
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
            this.txtSearch.Location = new System.Drawing.Point(74, 12);
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
            this.btnRefresh.Location = new System.Drawing.Point(508, 9);
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
            this.btnDeleteUser.Location = new System.Drawing.Point(719, 9);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.TabStop = false;
            this.btnDeleteUser.Zoom = 15;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.Transparent;
            this.btnEditUser.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUser.Image")));
            this.btnEditUser.ImageActive = null;
            this.btnEditUser.Location = new System.Drawing.Point(607, 9);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(50, 50);
            this.btnEditUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.TabStop = false;
            this.btnEditUser.Zoom = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(406, 9);
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
            this.panelDTGV.Controls.Add(this.dtgvUser2);
            this.panelDTGV.Location = new System.Drawing.Point(30, 91);
            this.panelDTGV.Name = "panelDTGV";
            this.panelDTGV.Size = new System.Drawing.Size(400, 638);
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
            this.dtgvUser2.Size = new System.Drawing.Size(400, 638);
            this.dtgvUser2.TabIndex = 4;
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.manv.DataPropertyName = "UserCode";
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
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Hủy";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(662, 588);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(140, 40);
            this.bunifuFlatButton3.TabIndex = 37;
            this.bunifuFlatButton3.Text = "Hủy";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Xác nhận";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(835, 588);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(140, 40);
            this.bunifuFlatButton2.TabIndex = 36;
            this.bunifuFlatButton2.Text = "Xác nhận";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cập nhật";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(468, 588);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(140, 40);
            this.bunifuFlatButton1.TabIndex = 35;
            this.bunifuFlatButton1.Text = "Cập nhật";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label7.Location = new System.Drawing.Point(479, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Địa chỉ";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(621, 462);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(263, 26);
            this.textBox7.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label6.Location = new System.Drawing.Point(479, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "SDT";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(621, 411);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(263, 26);
            this.textBox6.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label5.Location = new System.Drawing.Point(479, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Địa chỉ";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(621, 325);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(263, 65);
            this.textBox5.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label4.Location = new System.Drawing.Point(479, 280);
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
            this.label3.Location = new System.Drawing.Point(479, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Email";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(621, 277);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(263, 26);
            this.textBox4.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(621, 229);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 26);
            this.textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(621, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 26);
            this.textBox2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(479, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Họ tên";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(621, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 26);
            this.textBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(479, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // ChildFrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 665);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDTGV);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildFrmUser";
            this.Text = "childFrmUser";
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).EndInit();
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
        private BunifuImageButton btnEditUser;
        private BunifuImageButton btnSearch;
        private BunifuImageButton btnRefresh;
        private ToolTip toolTipFrmUser;
        private BunifuMetroTextbox txtSearch;
        private DataGridViewTextBoxColumn manv;
        private DataGridViewTextBoxColumn tenNV;
        private DataGridViewTextBoxColumn tk;
        private BunifuFlatButton bunifuFlatButton3;
        private BunifuFlatButton bunifuFlatButton2;
        private BunifuFlatButton bunifuFlatButton1;
        private Label label7;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}