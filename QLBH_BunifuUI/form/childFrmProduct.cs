using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DTO.DAO;

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
            toolTipFrmProduct.SetToolTip(btnEditProduct, "Chỉnh sửa thông tin Sản Phẩm");

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
            dtgvProduct.DataSource = ProductDao.Instance.View();
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
            dtgvProduct.DataSource = ProductDao.Instance.FindProduct(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            GetListProduct();
        }

        private void btnDeleteProduct_Click(object sender, System.EventArgs e)
        {

        }
    }
}
