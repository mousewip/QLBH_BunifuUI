using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DTO.DAO;
using DTO.Model;

namespace QLBH_BunifuUI.form
{
    public partial class ChildFrmProduct : Form
    {
        public ChildFrmProduct()
        {
            InitializeComponent();
            toolTipFrmProduct.SetToolTip(btnAddProduct, "Thêm mới Sản Phẩm");
            toolTipFrmProduct.SetToolTip(btnDeleteProduct, "Xóa Sản Phẩm");
            toolTipFrmProduct.SetToolTip(btnRefresh, "Làm mới danh sách");
           // toolTipFrmProduct.SetToolTip(btnEditProduct, "Chỉnh sửa thông tin Sản Phẩm");

            dtgvProduct.ReadOnly = true;
            dtgvProduct.AutoGenerateColumns = false;
            GetListProduct();

        }
        Image ConvertBinary2Image(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        public void GetListProduct()
        {
            List<Product> lProduct = ProductDao.Instance.View();

            dtgvProduct.DataSource = lProduct;
            if (lProduct.Count != 0)
            {
                SetProductInfo(lProduct[0]);
            }

        }

        private void btnAddProduct_Click(object sender, System.EventArgs e)
        {
            var f = Application.OpenForms["cfpFrmCreateProduct"];
            if (f != null)
            {
                f.Focus();
                f.Show();
            }
            else
            {
                var cfpCp = new cfpFrmCreateProduct();
                cfpCp.Show();
            }
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            List<Product> lProduct = ProductDao.Instance.FindProduct(txtSearch.Text.Trim());
            dtgvProduct.DataSource = lProduct;
            if(lProduct.Count != 0)
                SetProductInfo(lProduct[0]);
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            GetListProduct();
        }

        private void btnDeleteProduct_Click(object sender, System.EventArgs e)
        {

            if (dtgvProduct.CurrentRow != null)
            {
                var rowIndex = dtgvProduct.CurrentRow.Index;
                var row = dtgvProduct.Rows[rowIndex];
                string strVal = row.Cells[1].Value.ToString();
                var result = MessageBox.Show("Bạn có chắc muốn xóa " + strVal + " ra khỏi hệ thống?", "Xóa nhân viên",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ProductDao.Instance.Delete(row.Cells[0].Value.ToString());
                    GetListProduct();
                }
            }

        }


        private void SetProductInfo(Product pd)
        {
            txtCategory.Text = ProductCategoryDAO.Instance.SelectSingleProductCategory(pd.PCCode).PCName;
            txtProductCode.Text = pd.ProductCode;
            txtProductName.Text = pd.ProductName;
            txtPrice.Text = pd.Price.ToString();
            txtDiscount.Text = pd.Discount.ToString();
            txtQuantity.Text = pd.Quantity.ToString();
            txtTrademark.Text = pd.Trademark;
            if(pd.Image != null)
                ptbImage.Image = ConvertBinary2Image(pd.Image);
            else
            {
                ptbImage.Image = base.BackgroundImage;
            }
        }

        private void dtgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
                return;
            else
            {
                int index = e.RowIndex;
                var productCode = dtgvProduct.Rows[index].Cells[0].Value.ToString();
                var pd = ProductDao.Instance.SelectSingleProduct(productCode);
                if (pd != null)
                {
                    SetProductInfo(pd);
                }
            }
        }

        

        private void ChangeReadonlyInput(bool val)
        {
           // txtProductCode.ReadOnly = val;
            txtDiscount.ReadOnly = val;
            txtTrademark.ReadOnly = val;
            txtQuantity.ReadOnly = val;
            txtPrice.ReadOnly = val;
            txtProductName.ReadOnly = val;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            ChangeReadonlyInput(false);
            btnUpdate.Visible = true;
            btnCancel.Visible = false;
            btnAccept.Visible = false;
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {

            Product pd = new Product()
            {
                ProductCode = txtProductCode.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                Price =
                    (string.IsNullOrEmpty(txtPrice.Text.Trim())) ? (double?) null : double.Parse(txtPrice.Text.Trim()),
                Discount =
                    (string.IsNullOrEmpty(txtDiscount.Text.Trim()))
                        ? (double?) null
                        : double.Parse(txtDiscount.Text.Trim())

            };
        }

        private void ptbImage_DoubleClick(object sender, System.EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            ChangeReadonlyInput(true);
            btnCancel.Visible = true;
            btnAccept.Visible = true;
            btnUpdate.Visible = false;
        }
    }

}
