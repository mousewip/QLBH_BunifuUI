using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO.DAO;
using DTO.Model;
using DTO;
using QLBH_BunifuUI.Common;

namespace QLBH_BunifuUI.form
{
    public partial class ChildFrmUser : Form
    {
        private static int roleID = (int)Session.Instance.Get("RoleID");
        public ChildFrmUser()
        {
            InitializeComponent();

            toolTipFrmUser.SetToolTip(btnAddUser, "Thêm mới Nhân Viên");
            toolTipFrmUser.SetToolTip(btnDeleteUser, "Xóa nhân viên");
            toolTipFrmUser.SetToolTip(btnRefresh, "Làm mới danh sách");
            dtgvUser2.ReadOnly = true;
            dtgvUser2.AutoGenerateColumns = false;
            GetListUser();

        }

        public void GetListUser()
        {
            List<User> lUser = UserDao.Instance.View();
            dtgvUser2.DataSource = lUser;
            if (lUser.Count != 0)
                SetInfo(lUser[0]);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (roleID == 1)
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
            else
            {
                MessageBox.Show("Bạn không có quyền");
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetListUser();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(roleID == 1)
            {
                if (dtgvUser2.CurrentRow != null)
                {
                    var rowIndex = dtgvUser2.CurrentRow.Index;
                    var row = dtgvUser2.Rows[rowIndex];
                    string strVal = row.Cells[2].Value.ToString();
                    var result = MessageBox.Show("Bạn có chắc muốn xóa " + strVal + " ra khỏi hệ thống?", "Xóa nhân viên",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (UserDao.Instance.Delete(Int32.Parse(row.Cells[0].Value.ToString())) == true)
                        {
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                            MessageBox.Show("Xóa thất bại");
                        GetListUser();

                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền");
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var strFind = txtSearch.Text;
            List<User> lUser = UserDao.Instance.FindUser(strFind);
            dtgvUser2.DataSource = lUser;
            if (lUser.Count != 0)
            {
                SetInfo(lUser[0]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int userID = (int)Session.Instance.Get("ID");
            
            if (userID == int.Parse(txtUserID.Text.Trim()))
            {
                btnUpdate.Visible = false;
                btnCancel.Visible = true;
                btnAccept.Visible = true;
                btnChangePassword.Visible = true;
                ChangeReadonlyInput(false);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnCancel.Visible = false;
            btnAccept.Visible = false;
            btnChangePassword.Visible = false;
            lblPass.Visible = false;
            lblNewPass.Visible = false;
            txtNewPassword.Visible = false;
            txtCurrentPassword.Visible = false;
            ChangeReadonlyInput(true);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            btnChangePassword.Visible = false;
            lblPass.Visible = true;
            lblNewPass.Visible = true;
            txtNewPassword.Visible = true;
            txtCurrentPassword.Visible = true;
        }

        private void ChangeReadonlyInput(bool val)
        {
            txtAddress.ReadOnly = val;
            txtEmail.ReadOnly = val;
            txtFullName.ReadOnly = val;
            txtPhone.ReadOnly = val;
        }

        private void dtgvUser2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                int index = e.RowIndex;
                User user = UserDao.Instance.SelectSingleUserById((int)dtgvUser2.Rows[index].Cells[0].Value);
                SetInfo(user);
            }
        }

        private void SetInfo(User user)
        {
            txtUserID.Text = user.UserID.ToString();
            txtFullName.Text = user.FullName;
            txtAddress.Text = user.Address;
            radioBtnNam.Checked = user.Gender == true ? true : false;
            radioBtnNu.Checked = user.Gender == false ? true : false;
            txtEmail.Text = user.Email;
            txtPhone.Text = user.Phone;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.UserID = int.Parse(txtUserID.Text.Trim());
            user.FullName = txtFullName.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.Gender = radioBtnNam.Checked;
            user.Address = txtAddress.Text.Trim();
            user.Phone = txtPhone.Text.Trim();

            if (!string.IsNullOrEmpty(txtCurrentPassword.Text) && !string.IsNullOrEmpty(txtNewPassword.Text))
            {
                user.Password = Helper.Md5Encrypt(txtNewPassword.Text.Trim());
            }
        }
    }
}

