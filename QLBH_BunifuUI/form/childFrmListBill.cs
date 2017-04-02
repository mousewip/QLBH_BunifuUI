using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_BunifuUI.form
{
    public partial class childFrmListBill : Form
    {
        public childFrmListBill()
        {
            InitializeComponent();
        }

        private void dtgvBillDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms["childFrmBill"];

            if (f != null)
            {
                this.Controls.Clear();
                var cfb = new ChildFrmBill();
                cfb.TopLevel = false;
                this.Controls.Add(cfb);
                f.Dock = DockStyle.Fill;
                f.Show();
            }
            else
            {
                childFrmListBill cflb = new childFrmListBill();
                this.Controls.Clear();
                cflb.TopLevel = false;
                this.Controls.Add(cflb);
                cflb.Dock = DockStyle.Fill;
                cflb.Show();
            }
        }
    }
}
