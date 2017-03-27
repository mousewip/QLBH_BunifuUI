using System.ComponentModel;
using Bunifu.Framework.UI;

namespace QLBH_BunifuUI.form
{
    partial class ChildFrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildFrmProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.childFrmProductElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDeleteProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelDTGV = new System.Windows.Forms.Panel();
            this.toolTipFrmProduct = new System.Windows.Forms.ToolTip(this.components);
            this.dtgvProduct = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelProductDetail = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).BeginInit();
            this.panelDTGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // childFrmProductElipse
            // 
            this.childFrmProductElipse.ElipseRadius = 0;
            this.childFrmProductElipse.TargetControl = this;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.txtSearch);
            this.panelControl.Controls.Add(this.btnRefresh);
            this.panelControl.Controls.Add(this.btnDeleteProduct);
            this.panelControl.Controls.Add(this.btnEditProduct);
            this.panelControl.Controls.Add(this.btnSearch);
            this.panelControl.Controls.Add(this.btnAddProduct);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(811, 73);
            this.panelControl.TabIndex = 3;
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
            this.txtSearch.TabIndex = 7;
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
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Image")));
            this.btnDeleteProduct.ImageActive = null;
            this.btnDeleteProduct.Location = new System.Drawing.Point(719, 9);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.TabStop = false;
            this.btnDeleteProduct.Zoom = 15;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnEditProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.Image")));
            this.btnEditProduct.ImageActive = null;
            this.btnEditProduct.Location = new System.Drawing.Point(607, 9);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(50, 50);
            this.btnEditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.TabStop = false;
            this.btnEditProduct.Zoom = 15;
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
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageActive = null;
            this.btnAddProduct.Location = new System.Drawing.Point(12, 13);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(50, 50);
            this.btnAddProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.Zoom = 15;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panelDTGV
            // 
            this.panelDTGV.Controls.Add(this.dtgvProduct);
            this.panelDTGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDTGV.Location = new System.Drawing.Point(0, 73);
            this.panelDTGV.Name = "panelDTGV";
            this.panelDTGV.Size = new System.Drawing.Size(377, 500);
            this.panelDTGV.TabIndex = 4;
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.AllowUserToAddRows = false;
            this.dtgvProduct.AllowUserToDeleteRows = false;
            this.dtgvProduct.AllowUserToResizeColumns = false;
            this.dtgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.YellowGreen;
            this.dtgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dtgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvProduct.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.Price});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProduct.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProduct.DoubleBuffered = true;
            this.dtgvProduct.EnableHeadersVisualStyles = false;
            this.dtgvProduct.HeaderBgColor = System.Drawing.Color.ForestGreen;
            this.dtgvProduct.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.ReadOnly = true;
            this.dtgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvProduct.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProduct.Size = new System.Drawing.Size(377, 500);
            this.dtgvProduct.TabIndex = 6;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.FillWeight = 4F;
            this.ProductCode.HeaderText = "Mã Sản Phẩm";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductFullName";
            this.ProductName.FillWeight = 6F;
            this.ProductName.HeaderText = "Tên Sản Phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 4F;
            this.Price.HeaderText = "Đơn Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // panelProductDetail
            // 
            this.panelProductDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductDetail.Location = new System.Drawing.Point(377, 73);
            this.panelProductDetail.Name = "panelProductDetail";
            this.panelProductDetail.Size = new System.Drawing.Size(434, 500);
            this.panelProductDetail.TabIndex = 5;
            // 
            // ChildFrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 573);
            this.Controls.Add(this.panelProductDetail);
            this.Controls.Add(this.panelDTGV);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildFrmProduct";
            this.Text = "childFrmProduct";
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).EndInit();
            this.panelDTGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuElipse childFrmProductElipse;
        private System.Windows.Forms.Panel panelControl;
        private BunifuImageButton btnRefresh;
        private BunifuImageButton btnDeleteProduct;
        private BunifuImageButton btnEditProduct;
        private BunifuImageButton btnSearch;
        private BunifuImageButton btnAddProduct;
        private System.Windows.Forms.Panel panelDTGV;
        private System.Windows.Forms.ToolTip toolTipFrmProduct;
        private BunifuMetroTextbox txtSearch;
        private System.Windows.Forms.Panel panelProductDetail;
        private BunifuCustomDataGrid dtgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}