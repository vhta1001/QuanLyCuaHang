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
    public partial class FrmNCC : Form
    {
        NCC_DAL_BLL ncc = new NCC_DAL_BLL();
        public FrmNCC()
        {
            InitializeComponent();
        }
        private void loadDT()
        {
            dataGridView1.DataSource = ncc.getNCC();
        }
        private void FrmNCC_Load(object sender, EventArgs e)
        {
            loadDT();
            btnLuu.Enabled = btnXoa.Enabled = btnSua.Enabled = txtSDTNCC.Enabled = txtTenNCC.Enabled = txtDCNCC.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenNCC.Text) || String.IsNullOrEmpty(txtDCNCC.Text) || String.IsNullOrEmpty(txtSDTNCC.Text) )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin nhà cung cấp !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ncc.checkNCC(txtTenNCC.Text))
            {
                MessageBox.Show("Tên nhà cung cấp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (ncc.addNCC(txtTenNCC.Text, txtDCNCC.Text, txtSDTNCC.Text))
                {
                    loadDT();
                    txtMaNCC.Text = txtSDTNCC.Text = txtTenNCC.Text = txtDCNCC.Text = "";
                    btnLuu.Enabled = txtSDTNCC.Enabled = txtTenNCC.Enabled = txtDCNCC.Enabled = false;
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtMaNCC.Text = txtSDTNCC.Text = txtTenNCC.Text = txtDCNCC.Text = "";
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtTenNCC.Text) || String.IsNullOrEmpty(txtDCNCC.Text) || String.IsNullOrEmpty(txtSDTNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin nhà cung cấp !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {

                if (ncc.updateNCC(int.Parse(txtMaNCC.Text),txtTenNCC.Text, txtDCNCC.Text, txtSDTNCC.Text))
                {
                    loadDT();
                    txtMaNCC.Text = txtSDTNCC.Text = txtTenNCC.Text = txtDCNCC.Text = "";
                    btnXoa.Enabled = btnSua.Enabled = txtSDTNCC.Enabled = txtTenNCC.Enabled = txtDCNCC.Enabled = false;
                    MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtMaNCC.Text = txtSDTNCC.Text = txtTenNCC.Text = txtDCNCC.Text = "";
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaNCC.Text) )
            {
                MessageBox.Show("Vui lòng nhập thông tin nhà cung cấp !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNCC.Focus();
            }
            else
            {

                if (ncc.deleteNCC(int.Parse(txtMaNCC.Text)))
                {
                    loadDT();
                    txtMaNCC.Text = txtSDTNCC.Text = txtTenNCC.Text = txtDCNCC.Text = "";
                    btnXoa.Enabled = btnSua.Enabled = txtSDTNCC.Enabled = txtTenNCC.Enabled = txtDCNCC.Enabled = false;
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtMaNCC.Text = txtSDTNCC.Text = txtTenNCC.Text = txtDCNCC.Text = "";
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaNCC.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtSDTNCC.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDCNCC.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
             btnXoa.Enabled = btnSua.Enabled = txtSDTNCC.Enabled = txtTenNCC.Enabled = txtDCNCC.Enabled = true;

        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled =  txtSDTNCC.Enabled = txtTenNCC.Enabled = txtDCNCC.Enabled = true;

        }

        private void txtSDTNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
