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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildFrmUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.toolTipFrmUser = new System.Windows.Forms.ToolTip(this.components);
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelControl.Size = new System.Drawing.Size(830, 73);
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
            this.panelDTGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDTGV.Location = new System.Drawing.Point(0, 73);
            this.panelDTGV.Name = "panelDTGV";
            this.panelDTGV.Size = new System.Drawing.Size(830, 427);
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.YellowGreen;
            this.dtgvUser2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvUser2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dtgvUser2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvUser2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvUser2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvUser2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
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
            this.tk,
            this.quyen,
            this.status});
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
            this.dtgvUser2.HeaderBgColor = System.Drawing.Color.ForestGreen;
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
            this.dtgvUser2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvUser2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvUser2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvUser2.ShowEditingIcon = false;
            this.dtgvUser2.Size = new System.Drawing.Size(830, 427);
            this.dtgvUser2.TabIndex = 4;
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.manv.DataPropertyName = "UserCode";
            this.manv.FillWeight = 6F;
            this.manv.HeaderText = "ID";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.manv.Width = 31;
            // 
            // tenNV
            // 
            this.tenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNV.DataPropertyName = "FullName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tenNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.tenNV.FillWeight = 8F;
            this.tenNV.HeaderText = "Họ Tên";
            this.tenNV.Name = "tenNV";
            this.tenNV.ReadOnly = true;
            // 
            // tk
            // 
            this.tk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tk.DataPropertyName = "UserName";
            this.tk.FillWeight = 4F;
            this.tk.HeaderText = "Tài Khoản";
            this.tk.Name = "tk";
            this.tk.ReadOnly = true;
            // 
            // quyen
            // 
            this.quyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quyen.DataPropertyName = "RoleID";
            this.quyen.FillWeight = 4F;
            this.quyen.HeaderText = "Quyền";
            this.quyen.Name = "quyen";
            this.quyen.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "Status";
            this.status.FillWeight = 4F;
            this.status.HeaderText = "Trạng Thái";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // ChildFrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 500);
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
        private DataGridViewTextBoxColumn quyen;
        private DataGridViewTextBoxColumn status;
    }
}