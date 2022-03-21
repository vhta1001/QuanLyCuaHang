using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Cells;
using BLL;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace Gui
{
    public partial class FrmHoaDonNhap : Form
    {
        NCC_DAL_BLL ncc = new NCC_DAL_BLL();
        NhanVienDALBLL nv = new NhanVienDALBLL();
        MayLanh_DAL_BLL ml = new MayLanh_DAL_BLL();
        HoaDonNhap_DAL_BLL hdn = new HoaDonNhap_DAL_BLL();
        ExcelExport exrp = new ExcelExport();
        Class1 inhd = new Class1();
        int idhd;
        int sl;
        double thanhtien;
        public FrmHoaDonNhap()
        {
            InitializeComponent();
        }
        private void loadHD()
        {
            dataHD.DataSource = hdn.getHD();
        }
        private void loadCT(int idhd)
        {
            dataCTHD.DataSource = hdn.getCTHDbyHD(idhd);
        }
        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {
            cboNCC.DataSource = ncc.getNCC();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "Id";


            cboNV.DataSource = nv.getTenNVbyTDN(Program.FormMain.TenDN);
            cboNV.DisplayMember = "TenNV";
            cboNV.ValueMember = "Id";

            ngaylap.Value = DateTime.Now;
            ngaylap.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";

            cboML.DataSource = ml.getML();
            cboML.DisplayMember = "TenML";
            cboML.ValueMember = "Id";

            loadHD();
            
           

            txtMaCTHC.Enabled = MaHD.Enabled = soluong.Enabled = cboML.Enabled = txtDonGia.Enabled = txtThanhTien.Enabled = false;
            btnThem1.Enabled = btnLuu1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = false;

            txtMaHD.Enabled = txtTT.Enabled = cboNV.Enabled = cboNCC.Enabled =  ngaylap.Enabled  = false;
            btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled =btnIn.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboNV.Enabled = cboNCC.Enabled = true;
            cboNV.Focus();
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime ngaybanhang = DateTime.Now.Date + DateTime.Now.TimeOfDay;

            if (String.IsNullOrEmpty(cboNV.Text) || String.IsNullOrEmpty(cboNCC.Text) || String.IsNullOrEmpty(ngaylap.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin hóa đơn !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idnv = int.Parse(cboNV.SelectedValue.ToString());
                int idncc = int.Parse(cboNCC.SelectedValue.ToString());
                float tongtien = 0;
                if (!hdn.checkHD(idnv, idncc))
                {
                    MessageBox.Show("Hóa đơn đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (hdn.addHDN(idncc, idnv, ngaybanhang, tongtien))
                    {
                        loadHD();
                        txtMaHD.Text = ""; txtThanhTien.Text = "0";

                        txtMaHD.Enabled = txtTT.Enabled = cboNV.Enabled = cboNCC.Enabled =ngaylap.Enabled =  false;
                        btnLuu.Enabled = false;
                        MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            btnLuu1.Enabled = true;
            cboML.Enabled = soluong.Enabled = txtDonGia.Enabled = true;
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            double tt = double.Parse(txtThanhTien.Text);
            double sum = double.Parse(txtTT.Text);
            sum += tt;
            txtTT.Text = sum.ToString();
            if (String.IsNullOrEmpty(cboML.Text) || soluong.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin hóa đơn !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int sl = int.Parse(soluong.Value.ToString());
                int idml = int.Parse(cboML.SelectedValue.ToString());
                double dongia = double.Parse(txtDonGia.Text);
                double thanhtien = double.Parse(txtThanhTien.Text);

                if (!hdn.checkCTHD(idhd, idml))
                {
                    MessageBox.Show("Hóa đơn đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (hdn.addCT_HDN(idhd, idml, sl, dongia, thanhtien))
                    {
                        if (hdn.updateTT(idhd, sum) && ml.updateSLT(idml, -sl) && ml.updateDGB(idml,dongia))
                        {
                            soluong.Maximum = ml.getSLT(int.Parse(cboML.SelectedValue.ToString()));
                            loadCT(idhd);
                            loadHD();
                            txtMaCTHC.Enabled = MaHD.Enabled = soluong.Enabled = cboML.Enabled = txtDonGia.Enabled = txtThanhTien.Enabled = false;
                            btnLuu1.Enabled = false;
                            txtMaCTHC.Text = MaHD.Text = txtDonGia.Text = txtThanhTien.Text = "";
                            soluong.Value = 0;
                            MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }
        private void soluong_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                double giaban = double.Parse(txtDonGia.Text);
                int sl = int.Parse(soluong.Value.ToString());
                double tt = sl * giaban;
                txtThanhTien.Text = tt.ToString();
            }
            catch
            {

            }
        }

        private void dataHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            idhd = int.Parse(dataHD.Rows[i].Cells[0].Value.ToString());
            MaHD.Text = idhd.ToString();
            txtTT.Text = dataHD.Rows[i].Cells[4].Value.ToString();
            txtMaHD.Text = idhd.ToString();
            cboNCC.Text = dataHD.Rows[i].Cells[2].Value.ToString();
            cboNV.Text = dataHD.Rows[i].Cells[1].Value.ToString();
            ngaylap.Text = dataHD.Rows[i].Cells[3].Value.ToString();
          
            loadCT(idhd);
            btnSua.Enabled = btnXoa.Enabled = btnThem1.Enabled = btnIn.Enabled = true;
            cboNV.Enabled = cboNCC.Enabled =  true;
            cboNV.Focus();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double giaban = double.Parse(txtDonGia.Text);
                int sl = int.Parse(soluong.Value.ToString());
                double tt = sl * giaban;
                txtThanhTien.Text = tt.ToString();
            }
            catch
            { 
            
            }
            
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            double tt = double.Parse(txtThanhTien.Text);
            double sum = double.Parse(txtTT.Text);
            sum -= tt;
            txtTT.Text = sum.ToString();
            int idml = int.Parse(cboML.SelectedValue.ToString());
            int sl = int.Parse(soluong.Value.ToString());
            if (String.IsNullOrEmpty(txtMaCTHC.Text))
            {
                MessageBox.Show("Vui lòng nhập mã chi tiết hóa đơn !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (hdn.deleteCT_HDN(int.Parse(txtMaCTHC.Text)))
                {
                    if (hdn.updateTT(idhd, sum) && ml.updateSLT(idml, sl))
                    {
                        loadCT(idhd);
                        loadHD();
                        txtMaCTHC.Enabled = MaHD.Enabled = soluong.Enabled = cboML.Enabled = txtDonGia.Enabled = txtThanhTien.Enabled = false;
                        btnSua1.Enabled = btnXoa1.Enabled = false;
                        txtMaCTHC.Text = MaHD.Text = txtDonGia.Text = txtThanhTien.Text = "";
                        soluong.Value = 0;
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void dataCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaCTHC.Text = dataCTHD.Rows[i].Cells[0].Value.ToString();
            cboML.SelectedItem = dataCTHD.Rows[i].Cells[2].Value.ToString();
            soluong.Value = int.Parse(dataCTHD.Rows[i].Cells[3].Value.ToString());
            txtDonGia.Text = dataCTHD.Rows[i].Cells[4].Value.ToString();
            txtThanhTien.Text = dataCTHD.Rows[i].Cells[5].Value.ToString();
            btnXoa1.Enabled = btnSua1.Enabled = true;
            sl = int.Parse(dataCTHD.Rows[i].Cells[3].Value.ToString());
            thanhtien = double.Parse(dataCTHD.Rows[i].Cells[5].Value.ToString());
            soluong.Enabled = true;
            btnSua1.Enabled = btnXoa1.Enabled = true;
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            double tt = double.Parse(txtThanhTien.Text);
            double sum = double.Parse(txtTT.Text);
            sum = sum - thanhtien + tt;
            txtTT.Text = sum.ToString();
            if (String.IsNullOrEmpty(cboML.Text) || soluong.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin hóa đơn !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(txtMaCTHC.Text);
                int idml = int.Parse(cboML.SelectedValue.ToString());
                int slmoi = int.Parse(soluong.Value.ToString());
                double dongia = double.Parse(txtDonGia.Text);
                 tt= double.Parse(txtThanhTien.Text);



                if (hdn.updateCT_HDN(id, idhd, idml, slmoi, dongia, tt))
                {
                    if (hdn.updateTT(idhd, sum) && ml.updateSLT(idml, sl - slmoi))
                    {
                        soluong.Maximum = ml.getSLT(int.Parse(cboML.SelectedValue.ToString()));
                        loadCT(idhd);
                        loadHD();
                        txtMaCTHC.Enabled = MaHD.Enabled = soluong.Enabled = cboML.Enabled = txtDonGia.Enabled = txtThanhTien.Enabled = false;
                        btnSua1.Enabled = btnXoa1.Enabled = false;
                        txtMaCTHC.Text = MaHD.Text = txtDonGia.Text = txtThanhTien.Text = "";
                        soluong.Value = 0;
                        MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime ngaybanhang = ngaylap.Value.Date + ngaylap.Value.TimeOfDay;

            if (String.IsNullOrEmpty(cboNV.Text) || String.IsNullOrEmpty(cboNCC.Text) || String.IsNullOrEmpty(ngaylap.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin hóa đơn !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idnv = int.Parse(cboNV.SelectedValue.ToString());
                int idncc = int.Parse(cboNCC.SelectedValue.ToString());
                float tongtien = float.Parse(txtTT.Text);
                

                    if (hdn.updateHD(idhd,idncc, idnv, ngaybanhang, tongtien))
                    {
                        loadHD();
                        txtMaHD.Text = ""; txtThanhTien.Text = "0";

                        txtMaHD.Enabled = txtTT.Enabled = cboNV.Enabled = cboNCC.Enabled = ngaylap.Enabled = false;
                        btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled= false;
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
            List<CT_HoaDonNhap> list = hdn.getCT_HDBbyIDHD(idhd);
            foreach (CT_HoaDonNhap a in list)
            {

                if (hdn.deleteCT_HDN(a.Id))
                {
                    if (ml.updateSLT(a.IdML, a.SoLuongNhap))
                    {
                        continue;
                    }
                }
                else
                { break; }


            }

            if (!hdn.checkCTHDbyHD(idhd))
            {
                MessageBox.Show("Chưa xóa hết chi tiết hóa đơn !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!hdn.deleteHD(idhd))
                {
                    MessageBox.Show("Xóa thất bại !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Xóa thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    loadHD();
                    cboNV.Enabled = cboNCC.Enabled = false;
                    btnSua.Enabled = btnXoa.Enabled  = btnIn.Enabled = false;
                }
            }
        }
        
        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                List<BLL.Class1> list = new List<BLL.Class1>();
                for (int i = 0; i < dataCTHD.Rows.Count; i++)
                {
                    BLL.Class1 a = new BLL.Class1();
                    a.Id = dataCTHD.Rows[i].Cells[0].Value.ToString();
                    a.IdHD = dataCTHD.Rows[i].Cells[1].Value.ToString();
                    a.TenML = dataCTHD.Rows[i].Cells[2].Value.ToString();
                    a.SoLuongNhap = dataCTHD.Rows[i].Cells[3].Value.ToString();
                    a.DonGiaNhap = dataCTHD.Rows[i].Cells[4].Value.ToString();
                    a.ThanhTien = dataCTHD.Rows[i].Cells[5].Value.ToString();
                    list.Add(a);
                    count += int.Parse(dataCTHD.Rows[i].Cells[3].Value.ToString());
                }
               
                DateTime currentDate = ngaylap.Value;
                string ngay = "Ngày " + currentDate.Day + " tháng " + currentDate.Month + " năm " + currentDate.Year;
                
                string file = Path.GetTempFileName() + Constants.FILE_EXT_XLS;
                exrp.ExportKhoa(list, ref file, true, count.ToString(), txtTT.Text, ngay, idhd.ToString(), cboNV.Text, cboNCC.Text);
                btnSua.Enabled = btnXoa.Enabled = btnThem1.Enabled = btnIn.Enabled = false;
                cboNV.Enabled = cboNCC.Enabled = false;

            }
            catch { }
           
            //// Instantiate the Workbook object with the Excel file
            //Workbook workbook = new Workbook("DanhMucKhoa.xls");

            //// Save the document in PDF format
            //workbook.Save("outputPDF.pdf", SaveFormat.Pdf);
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        void loadmlbyncc(int idncc)
        {
            try
            {
                cboML.DataSource = ml.getMLbyNCC(idncc);
            }
            catch { }
        }
        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cboNCC.SelectedValue.ToString());
                loadmlbyncc(id);
            }
            catch { }
            
        }
    }
}
