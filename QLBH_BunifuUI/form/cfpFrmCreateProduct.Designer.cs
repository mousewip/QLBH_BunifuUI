namespace QLBH_BunifuUI.form
{
    partial class cfpFrmCreateProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cfpFrmCreateProduct));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.imageLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblFormName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductDescripton = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductTrademark = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductQuantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductSize = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductColor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnChooseImage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbImageProduct = new System.Windows.Forms.PictureBox();
            this.ofdChooseImage = new System.Windows.Forms.OpenFileDialog();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SeaGreen;
            this.panelTop.Controls.Add(this.bunifuImageButton1);
            this.panelTop.Controls.Add(this.imageLogo);
            this.panelTop.Controls.Add(this.lblFormName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(798, 41);
            this.panelTop.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(763, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // imageLogo
            // 
            this.imageLogo.BackColor = System.Drawing.Color.SeaGreen;
            this.imageLogo.Image = ((System.Drawing.Image)(resources.GetObject("imageLogo.Image")));
            this.imageLogo.ImageActive = null;
            this.imageLogo.Location = new System.Drawing.Point(3, 3);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(41, 35);
            this.imageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageLogo.TabIndex = 1;
            this.imageLogo.TabStop = false;
            this.imageLogo.Zoom = 10;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.Location = new System.Drawing.Point(50, 9);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(152, 20);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Thêm mới sản phẩm";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.btnOK);
            this.panelContent.Controls.Add(this.btnReset);
            this.panelContent.Controls.Add(this.btnCancel);
            this.panelContent.Controls.Add(this.cbbCategory);
            this.panelContent.Controls.Add(this.txtProductDescripton);
            this.panelContent.Controls.Add(this.txtProductTrademark);
            this.panelContent.Controls.Add(this.txtProductPrice);
            this.panelContent.Controls.Add(this.txtProductQuantity);
            this.panelContent.Controls.Add(this.txtProductSize);
            this.panelContent.Controls.Add(this.txtProductColor);
            this.panelContent.Controls.Add(this.txtProductName);
            this.panelContent.Controls.Add(this.txtProductCode);
            this.panelContent.Controls.Add(this.btnChooseImage);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.ptbImageProduct);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 41);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(798, 466);
            this.panelContent.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.BorderRadius = 0;
            this.btnOK.ButtonText = "   OK";
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
            this.btnOK.IconZoom = 80D;
            this.btnOK.IsTab = false;
            this.btnOK.Location = new System.Drawing.Point(577, 406);
            this.btnOK.Name = "btnOK";
            this.btnOK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOK.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOK.selected = false;
            this.btnOK.Size = new System.Drawing.Size(130, 40);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "   OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Textcolor = System.Drawing.Color.White;
            this.btnOK.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "   Clear";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReset.Iconimage")));
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 80D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(322, 406);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(130, 40);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "   Clear";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "   Cancel";
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
            this.btnCancel.IconZoom = 80D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(54, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "   Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbCategory
            // 
            this.cbbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(217, 122);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(235, 28);
            this.cbbCategory.TabIndex = 22;
            // 
            // txtProductDescripton
            // 
            this.txtProductDescripton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductDescripton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProductDescripton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductDescripton.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductDescripton.HintText = "Nhập mô tả";
            this.txtProductDescripton.isPassword = false;
            this.txtProductDescripton.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductDescripton.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProductDescripton.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductDescripton.LineThickness = 3;
            this.txtProductDescripton.Location = new System.Drawing.Point(520, 263);
            this.txtProductDescripton.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductDescripton.Name = "txtProductDescripton";
            this.txtProductDescripton.Size = new System.Drawing.Size(235, 35);
            this.txtProductDescripton.TabIndex = 21;
            this.txtProductDescripton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductTrademark
            // 
            this.txtProductTrademark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductTrademark.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProductTrademark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductTrademark.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductTrademark.HintText = "Nhập thương hiệu";
            this.txtProductTrademark.isPassword = false;
            this.txtProductTrademark.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductTrademark.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProductTrademark.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductTrademark.LineThickness = 3;
            this.txtProductTrademark.Location = new System.Drawing.Point(520, 188);
            this.txtProductTrademark.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductTrademark.Name = "txtProductTrademark";
            this.txtProductTrademark.Size = new System.Drawing.Size(235, 35);
            this.txtProductTrademark.TabIndex = 20;
            this.txtProductTrademark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductPrice.HintText = "Nhập đơn giá";
            this.txtProductPrice.isPassword = false;
            this.txtProductPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProductPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductPrice.LineThickness = 3;
            this.txtProductPrice.Location = new System.Drawing.Point(520, 115);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(235, 35);
            this.txtProductPrice.TabIndex = 19;
            this.txtProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProductQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductQuantity.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductQuantity.HintText = "Nhập số lượng";
            this.txtProductQuantity.isPassword = false;
            this.txtProductQuantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductQuantity.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProductQuantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductQuantity.LineThickness = 3;
            this.txtProductQuantity.Location = new System.Drawing.Point(520, 36);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(235, 35);
            this.txtProductQuantity.TabIndex = 18;
            this.txtProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductSize
            // 
            this.txtProductSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductSize.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProductSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductSize.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductSize.HintText = "Nhập kích cỡ";
            this.txtProductSize.isPassword = false;
            this.txtProductSize.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductSize.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProductSize.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductSize.LineThickness = 3;
            this.txtProductSize.Location = new System.Drawing.Point(217, 332);
            this.txtProductSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductSize.Name = "txtProductSize";
            this.txtProductSize.Size = new System.Drawing.Size(235, 35);
            this.txtProductSize.TabIndex = 17;
            this.txtProductSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductColor
            // 
            this.txtProductColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductColor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProductColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductColor.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductColor.HintText = "Nhập màu sắc";
            this.txtProductColor.isPassword = false;
            this.txtProductColor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductColor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProductColor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductColor.LineThickness = 3;
            this.txtProductColor.Location = new System.Drawing.Point(217, 263);
            this.txtProductColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductColor.Name = "txtProductColor";
            this.txtProductColor.Size = new System.Drawing.Size(235, 35);
            this.txtProductColor.TabIndex = 16;
            this.txtProductColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductName
            // 
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductName.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductName.HintText = "Nhập tên sản phẩm";
            this.txtProductName.isPassword = false;
            this.txtProductName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProductName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductName.LineThickness = 3;
            this.txtProductName.Location = new System.Drawing.Point(217, 188);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(235, 35);
            this.txtProductName.TabIndex = 15;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProductCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductCode.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductCode.HintText = "Nhập mã sản phẩm";
            this.txtProductCode.isPassword = false;
            this.txtProductCode.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductCode.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProductCode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductCode.LineThickness = 3;
            this.txtProductCode.Location = new System.Drawing.Point(217, 36);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(235, 35);
            this.txtProductCode.TabIndex = 14;
            this.txtProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChooseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChooseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseImage.BorderRadius = 0;
            this.btnChooseImage.ButtonText = "Chọn ảnh";
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.DisabledColor = System.Drawing.Color.Gray;
            this.btnChooseImage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChooseImage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChooseImage.Iconimage")));
            this.btnChooseImage.Iconimage_right = null;
            this.btnChooseImage.Iconimage_right_Selected = null;
            this.btnChooseImage.Iconimage_Selected = null;
            this.btnChooseImage.IconMarginLeft = 0;
            this.btnChooseImage.IconMarginRight = 0;
            this.btnChooseImage.IconRightVisible = true;
            this.btnChooseImage.IconRightZoom = 0D;
            this.btnChooseImage.IconVisible = true;
            this.btnChooseImage.IconZoom = 80D;
            this.btnChooseImage.IsTab = false;
            this.btnChooseImage.Location = new System.Drawing.Point(12, 214);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChooseImage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnChooseImage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChooseImage.selected = false;
            this.btnChooseImage.Size = new System.Drawing.Size(154, 48);
            this.btnChooseImage.TabIndex = 13;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseImage.Textcolor = System.Drawing.Color.White;
            this.btnChooseImage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(494, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Hiệu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(494, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Danh mục sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mô tả chi tiết";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Màu sắc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ảnh mô tả";
            // 
            // ptbImageProduct
            // 
            this.ptbImageProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImageProduct.Location = new System.Drawing.Point(12, 38);
            this.ptbImageProduct.Name = "ptbImageProduct";
            this.ptbImageProduct.Size = new System.Drawing.Size(154, 170);
            this.ptbImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImageProduct.TabIndex = 0;
            this.ptbImageProduct.TabStop = false;
            // 
            // ofdChooseImage
            // 
            this.ofdChooseImage.InitialDirectory = "C:\\Users\\Public\\Pictures";
            // 
            // cfpFrmCreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 507);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cfpFrmCreateProduct";
            this.Text = "cfpFrmCreateProduct";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelTop;
        private Bunifu.Framework.UI.BunifuImageButton imageLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFormName;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbImageProduct;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ComboBox cbbCategory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductDescripton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductTrademark;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductQuantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductSize;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductColor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductCode;
        private Bunifu.Framework.UI.BunifuFlatButton btnChooseImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofdChooseImage;
        private Bunifu.Framework.UI.BunifuFlatButton btnOK;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
    }
}