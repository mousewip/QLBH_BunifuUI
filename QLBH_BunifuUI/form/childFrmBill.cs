using DTO.DAO;
using DTO.Model;
using System.Windows.Forms;

namespace QLBH_BunifuUI.form
{
    public partial class ChildFrmBill : Form
    {
        public ChildFrmBill()
        {
            InitializeComponent();
            cbbProductCategory.DataSource = ProductCategoryDAO.Instance.View();
            cbbProductCategory.DisplayMember = "PCName";
            cbbProductCategory.ValueMember = "PCCode";
        }

      

        private void btnOutput_Click(object sender, System.EventArgs e)
        {

        }

        private void btnViewListBill_Click(object sender, System.EventArgs e)
        {
            var f = Application.OpenForms["childFrmListBill"];
            
            if (f != null)
            {
                panelControl.Controls.Clear();
                panelControl.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();
            }
            else
            {
                childFrmListBill cflb = new childFrmListBill();
                this.Controls.Clear();
                //panelControl.Controls.Clear();
                cflb.TopLevel = false;
                this.Controls.Add(cflb);
                cflb.Dock = DockStyle.Fill;
                cflb.Show();
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {

        }

        private void cbbProductCategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            ProductCategory selected = cb.SelectedItem as ProductCategory;
            id = selected.PCCode;
            LoadProductByCategoryID(id);
        }

        public void LoadProductByCategoryID(int id)
        {
            cbbProduct.DataSource = ProductDao.Instance.ListProductByCategory(id);
            cbbProduct.DisplayMember = "ProductName";
            cbbProduct.ValueMember = "ProductID";
        }
    }
}
