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
    public partial class FrmNhanVien : Form
    {
        NhanVienDALBLL NhanVienDALBLL = new NhanVienDALBLL();
        LoaiNV_DAL_BLL LoaiNV_DAL_BLL = new LoaiNV_DAL_BLL();
        PhanQuyen_DAL_BLL pq = new PhanQuyen_DAL_BLL();
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        public void loadDT()
        {
            dataGridView1.DataSource = NhanVienDALBLL.getNV();
            
        }
        private void loadDT1()
        {
            dataGridView2.DataSource = LoaiNV_DAL_BLL.getLoaiNV();
            cboChucVu.DataSource = LoaiNV_DAL_BLL.getLoaiNV();
            cboChucVu.DisplayMember = "tenloainv";
            cboChucVu.ValueMember = "id";
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            txtSdt.Enabled = txtMaNV.Enabled = txtPassWord.Enabled = txtTen.Enabled = txtUserName.Enabled = cboChucVu.Enabled = btnLuu.Enabled= btnXoa.Enabled = btnSua.Enabled  = false;
            txtMaLoaiNV.Enabled = txtTenLoaiNV.Enabled = btnSua1.Enabled = btnXoa1.Enabled = btnLuu1.Enabled = false;
            loadDT();
            loadDT1();
            cboChucVu.DataSource = LoaiNV_DAL_BLL.getLoaiNV();
            cboChucVu.DisplayMember = "tenloainv";
            cboChucVu.ValueMember = "id";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtTen.Text) || String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassWord.Text) || String.IsNullOrEmpty(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!NhanVienDALBLL.ktraTenDN(txtUserName.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (NhanVienDALBLL.addNV(txtTen.Text, txtUserName.Text, txtPassWord.Text, txtSdt.Text,int.Parse(cboChucVu.SelectedValue.ToString())))
                {
                    loadDT();
                    txtMaNV.Text = txtTen.Text = txtUserName.Text = txtPassWord.Text = txtSdt.Text = "";
                    btnLuu.Enabled = txtSdt.Enabled = txtMaNV.Enabled = txtPassWord.Enabled = txtTen.Enabled = txtUserName.Enabled = cboChucVu.Enabled = false;
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLuu.Enabled = false;
                }
                
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTen.Text) || String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassWord.Text) || String.IsNullOrEmpty(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (NhanVienDALBLL.updateNV(int.Parse(txtMaNV.Text),txtTen.Text, txtUserName.Text, txtPassWord.Text, txtSdt.Text, int.Parse(cboChucVu.SelectedValue.ToString())))
                {
                    loadDT();
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSdt.Enabled = txtMaNV.Enabled = txtPassWord.Enabled = txtTen.Enabled = txtUserName.Enabled = cboChucVu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int id = (int)dataGridView1.Rows[i].Cells[0].Value;
            NhanVien NV = NhanVienDALBLL.getNVbyID(id);

            txtMaNV.Text = NV.Id.ToString();
            txtTen.Text = NV.TenNV.ToString();
            txtUserName.Text = NV.TenDN.ToString();
            txtPassWord.Text = NV.MatKhau.ToString();
            cboChucVu.Text = NV.IdLoaiNV.ToString();
            txtSdt.Text = NV.SDTNV.ToString();
            txtSdt.Enabled = txtMaNV.Enabled = txtPassWord.Enabled = txtTen.Enabled = txtUserName.Enabled = cboChucVu.Enabled = btnSua.Enabled = btnXoa.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (NhanVienDALBLL.deleteNV(int.Parse(txtMaNV.Text)))
                {
                    loadDT();
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSdt.Enabled = txtMaNV.Enabled = txtPassWord.Enabled = txtTen.Enabled = txtUserName.Enabled = cboChucVu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSdt.Enabled = txtMaNV.Enabled = txtPassWord.Enabled = txtTen.Enabled = txtUserName.Enabled = cboChucVu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtSdt.Enabled = txtMaNV.Enabled = txtPassWord.Enabled = txtTen.Enabled = txtUserName.Enabled = cboChucVu.Enabled = btnLuu.Enabled = true;
            txtTen.Focus();
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            txtMaLoaiNV.Enabled = txtTenLoaiNV.Enabled =  btnLuu1.Enabled = true;
            txtTenLoaiNV.Focus();
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenLoaiNV.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin loại nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if (!LoaiNV_DAL_BLL.ktraTenLoaiNV(int.Parse(txtTenLoaiNV.Text)))
            //{
            //    MessageBox.Show("Loại nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {

                if (LoaiNV_DAL_BLL.addLoaiNV(txtTenLoaiNV.Text))
                {
                    loadDT1();
                    string id = LoaiNV_DAL_BLL.getID(txtTenLoaiNV.Text);
                    pq.addPQbyLoaiNV(int.Parse(id));
                    btnLuu1.Enabled = txtTenLoaiNV.Enabled = false;
                    txtMaLoaiNV.Text = txtTenLoaiNV.Text = "";
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLuu1.Enabled = txtTenLoaiNV.Enabled = false;
                    txtMaLoaiNV.Text = txtTenLoaiNV.Text = "";
                }

            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaLoaiNV.Text))
            {
                MessageBox.Show("Vui lòng chọn loại nhân viên ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (LoaiNV_DAL_BLL.ktraTenLoaiNV(int.Parse(txtMaLoaiNV.Text)))
            {
                MessageBox.Show("Loại nhân viên không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(NhanVienDALBLL.deleteNVbyLoaiNV(int.Parse(txtMaLoaiNV.Text))&&pq.deletePQbyLoaiNV(int.Parse(txtMaLoaiNV.Text)))
            {
                if (LoaiNV_DAL_BLL.deleteLoaiNV(int.Parse(txtMaLoaiNV.Text)))
                {
                    loadDT1();
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaLoaiNV.Enabled = txtTenLoaiNV.Enabled = btnSua1.Enabled = btnXoa1.Enabled = false;
                    txtMaLoaiNV.Text = txtTenLoaiNV.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaLoaiNV.Enabled = txtTenLoaiNV.Enabled = btnSua1.Enabled = btnXoa1.Enabled = false;
                    txtMaLoaiNV.Text = txtTenLoaiNV.Text = "";
                }
            }
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtTenLoaiNV.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin loại nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (LoaiNV_DAL_BLL.updateLoaiNV(int.Parse(txtMaLoaiNV.Text), txtTenLoaiNV.Text))
                {
                    loadDT1();
                    btnLuu1.Enabled = txtTenLoaiNV.Enabled = false;
                    txtMaLoaiNV.Text = txtTenLoaiNV.Text = "";
                    MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLuu1.Enabled = txtTenLoaiNV.Enabled = false;
                    txtMaLoaiNV.Text = txtTenLoaiNV.Text = "";
                }

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaLoaiNV.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtTenLoaiNV.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txtMaLoaiNV.Enabled = txtTenLoaiNV.Enabled = btnSua1.Enabled = btnXoa1.Enabled= true;
            txtTenLoaiNV.Focus();

        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTK.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin  nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<NhanVien> kq = NhanVienDALBLL.searchML(txtTK.Text);
                if (kq.Count == 0)
                {
                    MessageBox.Show("Không có kết quả cần tìm !!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    dataGridView1.DataSource = kq;
                }
            }
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textEdit1.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin  nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<LoaiNV> kq = LoaiNV_DAL_BLL.searchML(textEdit1.Text);
                if (kq.Count == 0)
                {
                    MessageBox.Show("Không có kết quả cần tìm !!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    dataGridView2.DataSource = kq;
                }
            }
        }
    }
}
