using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using BLL;

namespace Gui
{
    public partial class FrmLogin : Form
    {
        NhanVienDALBLL NhanVienDALBLL = new NhanVienDALBLL();
        private int active;

        public int Active
        {
            get { return active; }
            set { active = value; }
        }

        

        public FrmLogin()
        {
            InitializeComponent();
        }

        

        private void FrmLogin_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(151, 202, 219), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(151, 202, 219), Color.FromArgb(214, 232, 238), LinearGradientMode.ForwardDiagonal);
            graphics.FillRectangle(lgb, area);
            graphics.DrawRectangle(pen, area);
        }

        private void txtTenDN_Enter(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "Username")
            {
                txtTenDN.Text = "";
            }
        }

        private void txtTenDN_Leave(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "")
            {
                txtTenDN.Text = "Username";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDN.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống tên đăng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTenDN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPass.Focus();
                return;
            }

            if (!NhanVienDALBLL.checkLogin(txtTenDN.Text, txtPass.Text))
            {

                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                txtTenDN.Text = "Username";
                txtPass.Text = "Password";
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                if (Program.FormMain == null || Program.FormMain.IsDisposed)
                {
                    Program.FormMain = new FrmMain();
                }
                this.Visible = false;
                Program.FormLogin.Active = 1;
                Program.FormMain.TenDN = txtTenDN.Text;
                Program.FormMain.Show();
                txtTenDN.Text = "Username";
                txtPass.Text = "Password";
            }
        }
        
        
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ???", "???", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void CheckHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckHienMK.Checked)
            {
                txtPass.UseSystemPasswordChar = false;

            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
