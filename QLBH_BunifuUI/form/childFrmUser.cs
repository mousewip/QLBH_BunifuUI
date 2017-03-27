using System;
using System.Windows.Forms;
using DTO.DAO;

namespace QLBH_BunifuUI.form
{
    public partial class ChildFrmUser : Form
    {
        public ChildFrmUser()
        {
            InitializeComponent();

            toolTipFrmUser.SetToolTip(btnAddUser, "Thêm mới Nhân Viên");
            toolTipFrmUser.SetToolTip(btnDeleteUser, "Xóa nhân viên");
            toolTipFrmUser.SetToolTip(btnRefresh, "Làm mới danh sách");
            toolTipFrmUser.SetToolTip(btnEditUser, "Chỉnh sửa thông tin nhân viên");

            dtgvUser2.ReadOnly = true;
            dtgvUser2.AutoGenerateColumns = false;
            GetListUser();
        }

        public void GetListUser()
        {
            dtgvUser2.DataSource = UserDao.Instance.View();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms["cfuFrmCreateUser"];
            if (f != null)
            {
                f.Focus();
                f.Show();
            }
            else
            {
                var cfuCu = new CfuFrmCreateUser();
                cfuCu.Show();
            }     
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetListUser();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dtgvUser2.CurrentRow != null)
            {
                var rowIndex = dtgvUser2.CurrentRow.Index;
                var row = dtgvUser2.Rows[rowIndex];
                const string strVal = "abc"; //row.Cells[2].Value.ToString();
                var result = MessageBox.Show("Bạn có chắc muốn xóa " + strVal + " ra khỏi hệ thống?", "Xóa nhân viên",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UserDao.Instance.Delete(Int32.Parse(row.Cells[0].Value.ToString()));
                    //UserBus.Instance.Delete(Int32.Parse(row.Cells[0].Value.ToString()));
                    GetListUser();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var strFind = txtSearch.Text;
            dtgvUser2.DataSource =  UserDao.Instance.FindUserByID(strFind);
        }
    }
}
