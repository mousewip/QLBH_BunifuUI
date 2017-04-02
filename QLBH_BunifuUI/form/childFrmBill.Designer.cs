using System.ComponentModel;
using Bunifu.Framework.UI;

namespace QLBH_BunifuUI.form
{
    partial class ChildFrmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildFrmBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControl = new System.Windows.Forms.Panel();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOutput = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViewListBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelBillDetail = new System.Windows.Forms.Panel();
            this.dtgvBillDetail = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbProductCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDeleteProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.childFrmProductElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTipFrmProduct = new System.Windows.Forms.ToolTip(this.components);
            this.childFrmBillElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.panelBillDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetail)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.ptbImage);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.nmQuantity);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.cbbProduct);
            this.panelControl.Controls.Add(this.label11);
            this.panelControl.Controls.Add(this.btnOutput);
            this.panelControl.Controls.Add(this.btnViewListBill);
            this.panelControl.Controls.Add(this.btnAdd);
            this.panelControl.Controls.Add(this.panelBillDetail);
            this.panelControl.Controls.Add(this.cbbProductCategory);
            this.panelControl.Controls.Add(this.panel1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1076, 665);
            this.panelControl.TabIndex = 0;
            // 
            // ptbImage
            // 
            this.ptbImage.Image = ((System.Drawing.Image)(resources.GetObject("ptbImage.Image")));
            this.ptbImage.Location = new System.Drawing.Point(705, 240);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(243, 206);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 114;
            this.ptbImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(572, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 112;
            this.label2.Text = "Số lượng";
            // 
            // nmQuantity
            // 
            this.nmQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmQuantity.Location = new System.Drawing.Point(675, 167);
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(135, 26);
            this.nmQuantity.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(572, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "Sản phẩm";
            // 
            // cbbProduct
            // 
            this.cbbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(675, 135);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(273, 28);
            this.cbbProduct.TabIndex = 109;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.label11.Location = new System.Drawing.Point(572, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 108;
            this.label11.Text = "Danh mục";
            // 
            // btnOutput
            // 
            this.btnOutput.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutput.BorderRadius = 0;
            this.btnOutput.ButtonText = "Xuất hóa đơn";
            this.btnOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutput.DisabledColor = System.Drawing.Color.Gray;
            this.btnOutput.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOutput.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOutput.Iconimage")));
            this.btnOutput.Iconimage_right = null;
            this.btnOutput.Iconimage_right_Selected = null;
            this.btnOutput.Iconimage_Selected = null;
            this.btnOutput.IconMarginLeft = 0;
            this.btnOutput.IconMarginRight = 0;
            this.btnOutput.IconRightVisible = true;
            this.btnOutput.IconRightZoom = 0D;
            this.btnOutput.IconVisible = true;
            this.btnOutput.IconZoom = 90D;
            this.btnOutput.IsTab = false;
            this.btnOutput.Location = new System.Drawing.Point(869, 591);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnOutput.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOutput.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOutput.selected = false;
            this.btnOutput.Size = new System.Drawing.Size(175, 40);
            this.btnOutput.TabIndex = 107;
            this.btnOutput.Text = "Xuất hóa đơn";
            this.btnOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutput.Textcolor = System.Drawing.Color.White;
            this.btnOutput.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnViewListBill
            // 
            this.btnViewListBill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnViewListBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnViewListBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewListBill.BorderRadius = 0;
            this.btnViewListBill.ButtonText = "Danh sách hóa đơn";
            this.btnViewListBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewListBill.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewListBill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewListBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnViewListBill.Iconimage")));
            this.btnViewListBill.Iconimage_right = null;
            this.btnViewListBill.Iconimage_right_Selected = null;
            this.btnViewListBill.Iconimage_Selected = null;
            this.btnViewListBill.IconMarginLeft = 0;
            this.btnViewListBill.IconMarginRight = 0;
            this.btnViewListBill.IconRightVisible = true;
            this.btnViewListBill.IconRightZoom = 0D;
            this.btnViewListBill.IconVisible = true;
            this.btnViewListBill.IconZoom = 90D;
            this.btnViewListBill.IsTab = false;
            this.btnViewListBill.Location = new System.Drawing.Point(605, 591);
            this.btnViewListBill.Name = "btnViewListBill";
            this.btnViewListBill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnViewListBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnViewListBill.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewListBill.selected = false;
            this.btnViewListBill.Size = new System.Drawing.Size(231, 40);
            this.btnViewListBill.TabIndex = 106;
            this.btnViewListBill.Text = "Danh sách hóa đơn";
            this.btnViewListBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewListBill.Textcolor = System.Drawing.Color.White;
            this.btnViewListBill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewListBill.Click += new System.EventHandler(this.btnViewListBill_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(963, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 90);
            this.btnAdd.TabIndex = 113;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelBillDetail
            // 
            this.panelBillDetail.Controls.Add(this.dtgvBillDetail);
            this.panelBillDetail.Location = new System.Drawing.Point(12, 101);
            this.panelBillDetail.Name = "panelBillDetail";
            this.panelBillDetail.Size = new System.Drawing.Size(546, 553);
            this.panelBillDetail.TabIndex = 105;
            // 
            // dtgvBillDetail
            // 
            this.dtgvBillDetail.AllowUserToAddRows = false;
            this.dtgvBillDetail.AllowUserToDeleteRows = false;
            this.dtgvBillDetail.AllowUserToResizeColumns = false;
            this.dtgvBillDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dtgvBillDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dtgvBillDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvBillDetail.BackgroundColor = System.Drawing.Color.White;
            this.dtgvBillDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBillDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBillDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBillDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBillDetail.DoubleBuffered = true;
            this.dtgvBillDetail.EnableHeadersVisualStyles = false;
            this.dtgvBillDetail.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvBillDetail.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.dtgvBillDetail.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvBillDetail.Location = new System.Drawing.Point(0, 0);
            this.dtgvBillDetail.Name = "dtgvBillDetail";
            this.dtgvBillDetail.ReadOnly = true;
            this.dtgvBillDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBillDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvBillDetail.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dtgvBillDetail.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvBillDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvBillDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBillDetail.Size = new System.Drawing.Size(546, 553);
            this.dtgvBillDetail.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductCode";
            this.dataGridViewTextBoxColumn1.FillWeight = 1F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.FillWeight = 1F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "Số lượng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 1F;
            this.Column2.HeaderText = "Thành tiền";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cbbProductCategory
            // 
            this.cbbProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProductCategory.FormattingEnabled = true;
            this.cbbProductCategory.Location = new System.Drawing.Point(675, 103);
            this.cbbProductCategory.Name = "cbbProductCategory";
            this.cbbProductCategory.Size = new System.Drawing.Size(273, 28);
            this.cbbProductCategory.TabIndex = 104;
            this.cbbProductCategory.SelectedIndexChanged += new System.EventHandler(this.cbbProductCategory_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 73);
            this.panel1.TabIndex = 103;
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
            this.txtSearch.TabIndex = 1;
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
            // 
            // childFrmProductElipse
            // 
            this.childFrmProductElipse.ElipseRadius = 0;
            this.childFrmProductElipse.TargetControl = this;
            // 
            // childFrmBillElipse
            // 
            this.childFrmBillElipse.ElipseRadius = 0;
            this.childFrmBillElipse.TargetControl = this;
            // 
            // ChildFrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 665);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildFrmBill";
            this.Text = "childFrmBill";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.panelBillDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbProduct;
        private System.Windows.Forms.Label label11;
        private BunifuFlatButton btnOutput;
        private BunifuFlatButton btnViewListBill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelBillDetail;
        private BunifuCustomDataGrid dtgvBillDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox cbbProductCategory;
        private System.Windows.Forms.Panel panel1;
        private BunifuMetroTextbox txtSearch;
        private BunifuImageButton btnRefresh;
        private BunifuImageButton btnDeleteProduct;
        private BunifuImageButton btnSearch;
        private BunifuImageButton btnAddProduct;
        private BunifuElipse childFrmProductElipse;
        private System.Windows.Forms.ToolTip toolTipFrmProduct;
        private BunifuElipse childFrmBillElipse;

    }
}