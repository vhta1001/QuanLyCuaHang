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
    public partial class FrmKhachHang : Form
    {
        KhachHang_DAL_BLL kh = new KhachHang_DAL_BLL();
        HoaDonBan_DAL_BLL hdb = new HoaDonBan_DAL_BLL();
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        void loadKH()
        {
            dtgv_KhachHang.DataSource = kh.getKH();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = txtDienThoai.Text = txtMaKH.Text = txtTenKH.Text = "";
            txtDiaChi.Enabled = txtDienThoai.Enabled = txtMaKH.Enabled = txtTenKH.Enabled = true;
            btnLuu.Enabled =  true;
            txtTenKH.Focus();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            
            loadKH();
            
            txtDiaChi.Enabled = txtDienThoai.Enabled = txtMaKH.Enabled = txtTenKH.Enabled = false;
            btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void dtgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtDiaChi.Text = dtgv_KhachHang.Rows[i].Cells[2].Value.ToString();
                txtDienThoai.Text = dtgv_KhachHang.Rows[i].Cells[3].Value.ToString();
                txtMaKH.Text = dtgv_KhachHang.Rows[i].Cells[0].Value.ToString();
                txtTenKH.Text = dtgv_KhachHang.Rows[i].Cells[1].Value.ToString();
                txtDiaChi.Enabled = txtDienThoai.Enabled = txtMaKH.Enabled = txtTenKH.Enabled = true;
                btnSua.Enabled = btnXoa.Enabled = true;
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenKH.Text) ||  String.IsNullOrEmpty(txtDienThoai.Text) || String.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if (!kh.checkKH(int.Parse(txtMaKH.Text)))
            //{
            //    MessageBox.Show("Khách hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {

                if (kh.addKH( txtTenKH.Text, txtDienThoai.Text, txtDiaChi.Text))
                {
                    loadKH();
                    txtDiaChi.Text = txtDienThoai.Text = txtMaKH.Text = txtTenKH.Text = "";
                    txtDiaChi.Enabled = txtDienThoai.Enabled = txtMaKH.Enabled = txtTenKH.Enabled = false;
                    btnLuu.Enabled = false;
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenKH.Text) || String.IsNullOrEmpty(txtDienThoai.Text) || String.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (kh.updateKH(int.Parse(txtMaKH.Text),txtTenKH.Text, txtDienThoai.Text, txtDiaChi.Text))
                {
                    loadKH();
                    txtDiaChi.Text = txtDienThoai.Text = txtMaKH.Text = txtTenKH.Text = "";
                    txtDiaChi.Enabled = txtDienThoai.Enabled = txtMaKH.Enabled = txtTenKH.Enabled = false;
                    btnSua.Enabled = btnXoa.Enabled = false;
                    MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenKH.Text) )
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (kh.checkKH(int.Parse(txtMaKH.Text)))
            {
                MessageBox.Show("Khách hàng không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(hdb.deleteHDBbyKH(int.Parse(txtMaKH.Text)))
            {

                if (kh.deleteKH(int.Parse(txtMaKH.Text)))
                {
                    loadKH();
                    txtDiaChi.Text = txtDienThoai.Text = txtMaKH.Text = txtTenKH.Text = "";
                    txtDiaChi.Enabled = txtDienThoai.Enabled = txtMaKH.Enabled = txtTenKH.Enabled = false;
                    btnSua.Enabled = btnXoa.Enabled= false;
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
