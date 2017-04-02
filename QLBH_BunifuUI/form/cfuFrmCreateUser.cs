using System;
using System.Windows.Forms;
using DTO;
using DTO.DAO;
using DTO.Model;

namespace QLBH_BunifuUI.form
{
    public partial class CfuFrmCreateUser : Form
    {
        public CfuFrmCreateUser()
        {
            InitializeComponent();
            cbbRoles.DataSource = RoleDao.Instance.View();
            cbbRoles.DisplayMember = "RoleName";
            cbbRoles.ValueMember = "RoleID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetButton();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            var nv = new User()
            {
                FullName = txtName.Text.Trim(),
                UserName = txtUsername.Text.Trim(),
                Password = Helper.Md5Encrypt(txtPassword.Text.Trim()),
                Email = txtEmail.Text.Trim(),
                Gender = radioBtnNam.Checked ? true : false,
                Address = txtAddress.Text.Trim(),
                DayOfBirth = datePick.Value,
                RoleID = (int)cbbRoles.SelectedValue,
                Phone = txtPhone.Text.Trim()
                
            };

            var result = UserDao.Instance.Add(nv);
            if (result)
            {
                var resultMsg = MessageBox.Show("Thêm thành công");
                if (resultMsg == DialogResult.OK)
                {
                    ChildFrmUser f = (ChildFrmUser)Application.OpenForms["ChildFrmUser"];
                    f.GetListUser();
                    btnCancel_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            
        }


        private void ResetButton()
        {
            txtUsername.Text = "";
            txtPassword.Text = @" ";
            txtConfirmPassword.Text = @" ";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            radioBtnNam.Checked = false;
            radioBtnNu.Checked = false;
            datePick.Value = DateTime.Now;
        }

        private void CfuFrmCreateUser_VisibleChanged(object sender, EventArgs e)
        {
            ResetButton();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
        }
    }
}