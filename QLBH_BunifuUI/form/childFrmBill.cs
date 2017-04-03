using DTO.DAO;
using DTO.Model;
using QLBH_BunifuUI.Common;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLBH_BunifuUI.form
{
    public partial class ChildFrmBill : Form
    {
        private List<BillDetail> listBillDetail;
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
            int productID = (cbbProduct.SelectedItem as Product).ProductID;
            int quantity = (int)nmQuantity.Value;
            int billID = 0;
            BillDetail billDetail = new BillDetail();

            if (listBillDetail == null)
            {
                listBillDetail = new List<BillDetail>();

                billDetail.BillID = BillDAO.Instance.GetLastBillID();
                MessageBox.Show(billID.ToString());
                billDetail.Quantity = quantity;
                billDetail.ProductID = productID;
                billDetail.Total = quantity * ProductDao.Instance.GetPrice(productID);
                BillDetailDAO.Instance.Add(billDetail);
                listBillDetail.Add(billDetail);

            }
            else
            {
                billDetail.BillID = billID;
                billDetail.Quantity = quantity;
                billDetail.ProductID = productID;
                billDetail.Total = quantity * ProductDao.Instance.GetPrice(productID);
                BillDetailDAO.Instance.Add(billDetail);
                listBillDetail.Add(billDetail);
            }

            dtgvBillDetail.DataSource = listBillDetail;
	
            

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

        private void btnAddNewBill_Click(object sender, System.EventArgs e)
        {
            int billID = 0;
            int userID = (int)Session.Instance.Get("ID");
            billID = BillDAO.Instance.Add(userID);
            if (billID > 0)
            {
                MessageBox.Show("Bạn vừa tạo mới hóa đơn");
                listBillDetail = null;
            }
        }

        
    }
}
