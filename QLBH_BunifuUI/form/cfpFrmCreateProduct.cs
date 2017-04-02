using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using DTO.DAO;
using DTO.Model;

namespace QLBH_BunifuUI.form
{
    public partial class cfpFrmCreateProduct : Form
    {
        public cfpFrmCreateProduct()
        {
            InitializeComponent();
            cbbCategory.DataSource = ProductCategoryDAO.Instance.View();
            cbbCategory.DisplayMember = "PCName";
            cbbCategory.ValueMember = "PCCode";

        }
        
        byte[] ConvertImage2Binary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (ofdChooseImage.ShowDialog() == DialogResult.OK)
            { 
                string fileName = ofdChooseImage.FileName;
                ptbImageProduct.Image = Image.FromFile(fileName);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                ProductCode = txtProductCode.Text.Trim(),
                PCCode = int.Parse(cbbCategory.SelectedValue.ToString().Trim()),
                ProductName = txtProductName.Text.Trim(),
                Price = float.Parse(txtProductPrice.Text.Trim()),
                Size = txtProductSize.Text.Trim(),
                Color = txtProductColor.Text.Trim(),
                Quantity = int.Parse(txtProductQuantity.Text.Trim()),
                Trademark = txtProductTrademark.Text.Trim(),
                
                Image = ptbImageProduct.Image == null ? null : ConvertImage2Binary(ptbImageProduct.Image)
            };
            var result = ProductDao.Instance.Add(product);
            if (result)
            {
                var resultMsg = MessageBox.Show("Thêm thành công");
                if (resultMsg == DialogResult.OK)
                {
                    ChildFrmProduct f = (ChildFrmProduct)Application.OpenForms["ChildFrmProduct"];
                    f.GetListProduct();
                    btnCancel_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
