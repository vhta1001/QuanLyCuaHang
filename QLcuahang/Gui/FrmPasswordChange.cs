using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Gui
{
    public partial class FrmPasswordChange : Form
    {
        NhanVienDALBLL NhanVienDALBLL = new NhanVienDALBLL();
        public FrmPasswordChange()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Nhập vào mật khẩu cũ ")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Nhập vào mật khẩu cũ ";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                txtNewPass.Text = "Nhập mật khẩu mới";
                txtNewPass.UseSystemPasswordChar = false;
            }
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "Nhập mật khẩu mới")
            {
                txtNewPass.Text = "";
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void txtrepeatPass_Leave(object sender, EventArgs e)
        {
            if (txtrepeatPass.Text == "")
            {
                txtrepeatPass.Text = "Nhập lại mật khẩu mới";
                txtrepeatPass.UseSystemPasswordChar = false;
            }
        }

        private void txtrepeatPass_Enter(object sender, EventArgs e)
        {
            if (txtrepeatPass.Text == "Nhập lại mật khẩu mới")
            {
                txtrepeatPass.Text = "";
                txtrepeatPass.UseSystemPasswordChar = true;
            }
        }
        private void load()
        {
            txtPass.UseSystemPasswordChar = txtNewPass.UseSystemPasswordChar = txtrepeatPass.UseSystemPasswordChar = false;
            txtPass.Text = "Nhập vào mật khẩu cũ ";
            txtNewPass.Text = "Nhập mật khẩu mới";
            txtrepeatPass.Text = "Nhập lại mật khẩu mới";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int id = NhanVienDALBLL.getIDLoaiNV(Program.FormMain.TenDN);
            if (string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtNewPass.Text) || string.IsNullOrEmpty(txtrepeatPass.Text))
            {
                MessageBox.Show("Vui lòng không bỏ trống mật khẩu !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text.Equals(txtNewPass.Text))
            {
                MessageBox.Show("Mật khẩu không được trùng với mật khẩu cũ !!!");
                load();

            }
            else if (!txtNewPass.Text.Equals(txtrepeatPass.Text))
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                load();
            }
            else
            {
                if (NhanVienDALBLL.passwordChange(id, txtNewPass.Text))
                {
                   
                    MessageBox.Show("Đổi mật khẩu thành công !!!");
                    load();
                }
            }
        }

        private void FrmPasswordChange_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
