using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_BunifuUI.Common
{
    public partial class ProductCustom : Form
    {
        public ProductCustom()
        {
           // InitializeComponent();

        }

        private Image _img;

        public Image Img
        {
            get { return _img; }
            set { _img = value; }
        }
        public string ProductCode { set; get; }
        public string ProductFullName { set; get; }
        public double? Price { set; get; }
        public int? Quantity { set; get; }
    }
}
