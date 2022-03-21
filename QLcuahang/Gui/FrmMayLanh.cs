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
    public partial class FrmMayLanh : Form
    {
        NCC_DAL_BLL ncc = new NCC_DAL_BLL();
        MayLanh_DAL_BLL ml = new MayLanh_DAL_BLL();
        
        public FrmMayLanh()
        {
            InitializeComponent();
        }
        private void loadCBO()
        {
            cboNCC.DataSource = ncc.getNCC();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "Id";
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.MaxDate = DateTime.Now;
            
            txtTenML.Enabled = txtCongSuat.Enabled = txtGiaBan.Enabled = txtGiaNhap.Enabled = txtSLT.Enabled = txtTinhNang.Enabled = txtCongNghe.Enabled = cboNCC.Enabled = dateTimePicker1.Enabled = false;
            btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;

        }
        private void loadDT()
        {
            dataGridView1.DataSource = ml.getML();
        }
        private void FrmMayLanh_Load(object sender, EventArgs e)
        {
            loadCBO();
            loadDT();
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {



            if (String.IsNullOrEmpty(txtTenML.Text) || String.IsNullOrEmpty(txtCongSuat.Text) || String.IsNullOrEmpty(txtCongNghe.Text) || String.IsNullOrEmpty(txtGiaBan.Text)|| String.IsNullOrEmpty(txtGiaNhap.Text) || String.IsNullOrEmpty(txtSLT.Text) || String.IsNullOrEmpty(txtTinhNang.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin máy lạnh !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ml.checkML(txtTenML.Text))
            {
                MessageBox.Show("Máy lạnh đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (ml.addML(int.Parse(cboNCC.SelectedValue.ToString()), txtTenML.Text, txtCongSuat.Text, dateTimePicker1.Value, txtTinhNang.Text, txtCongNghe.Text, int.Parse(txtSLT.Text), float.Parse(txtGiaNhap.Text), float.Parse(txtGiaBan.Text)))
                {
                    loadDT();
                    txtMaML.Text = txtTenML.Text = txtCongSuat.Text = txtGiaBan.Text = txtGiaNhap.Text = txtSLT.Text = txtTinhNang.Text = txtCongNghe.Text = cboNCC.Text = dateTimePicker1.Text = "";
                    txtTenML.Enabled = txtCongSuat.Enabled = txtGiaBan.Enabled = txtGiaNhap.Enabled = txtSLT.Enabled = txtTinhNang.Enabled = txtCongNghe.Enabled = cboNCC.Enabled = dateTimePicker1.Enabled = false;
                    btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
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

            if (String.IsNullOrEmpty(txtTenML.Text) || String.IsNullOrEmpty(txtCongSuat.Text) || String.IsNullOrEmpty(txtCongNghe.Text) || String.IsNullOrEmpty(txtGiaBan.Text) || String.IsNullOrEmpty(txtGiaNhap.Text) || String.IsNullOrEmpty(txtSLT.Text) || String.IsNullOrEmpty(txtTinhNang.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin máy lạnh !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (ml.updateML(int.Parse(txtMaML.Text),int.Parse(cboNCC.SelectedValue.ToString()), txtTenML.Text, txtCongSuat.Text, dateTimePicker1.Value, txtTinhNang.Text, txtCongNghe.Text, int.Parse(txtSLT.Text), float.Parse(txtGiaNhap.Text), float.Parse(txtGiaBan.Text)))
                {
                    loadDT();
                    txtMaML.Text = txtTenML.Text = txtCongSuat.Text = txtGiaBan.Text = txtGiaNhap.Text = txtSLT.Text = txtTinhNang.Text = txtCongNghe.Text = cboNCC.Text = dateTimePicker1.Text = "";
                    txtTenML.Enabled = txtCongSuat.Enabled = txtGiaBan.Enabled = txtGiaNhap.Enabled = txtSLT.Enabled = txtTinhNang.Enabled = txtCongNghe.Enabled = cboNCC.Enabled = dateTimePicker1.Enabled = false;
                    btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaML.Text = txtTenML.Text = txtCongSuat.Text = txtGiaBan.Text = txtGiaNhap.Text = txtSLT.Text = txtTinhNang.Text = txtCongNghe.Text = cboNCC.Text = dateTimePicker1.Text = "";
            txtTenML.Enabled = txtCongSuat.Enabled = txtGiaBan.Enabled = txtGiaNhap.Enabled = txtSLT.Enabled = txtTinhNang.Enabled = txtCongNghe.Enabled = cboNCC.Enabled = dateTimePicker1.Enabled = true;
            btnLuu.Enabled = true;
            txtTenML.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaML.Text))
            {
                MessageBox.Show("Vui lòng nhập mã máy lạnh !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (ml.deleteML(int.Parse(txtMaML.Text)))
                {
                    loadDT();
                    txtMaML.Text = txtTenML.Text = txtCongSuat.Text = txtGiaBan.Text = txtGiaNhap.Text = txtSLT.Text = txtTinhNang.Text = txtCongNghe.Text = cboNCC.Text = dateTimePicker1.Text = "";
                    txtTenML.Enabled = txtCongSuat.Enabled = txtGiaBan.Enabled = txtGiaNhap.Enabled = txtSLT.Enabled = txtTinhNang.Enabled = txtCongNghe.Enabled = cboNCC.Enabled = dateTimePicker1.Enabled = false;
                    btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtMaML.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtTenML.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtCongSuat.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txtTinhNang.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txtCongNghe.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                cboNCC.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();

                dateTimePicker1.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                txtSLT.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txtGiaNhap.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                txtGiaBan.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                txtTenML.Enabled = txtCongSuat.Enabled = txtGiaBan.Enabled = txtGiaNhap.Enabled = txtSLT.Enabled = txtTinhNang.Enabled = txtCongNghe.Enabled = cboNCC.Enabled = dateTimePicker1.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = true;
            }
            catch { }
        }

        private void txtSLT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var kq = ml.searchML(txtTK.Text);
            if (kq == null)
            {
                MessageBox.Show("Không có kết quả cần tìm !!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = ml.searchML(txtTK.Text);
        }
    }
}
