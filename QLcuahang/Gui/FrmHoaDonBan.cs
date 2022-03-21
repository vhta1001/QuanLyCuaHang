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
using BLL;

namespace Gui
{
    public partial class FrmHoaDonBan : Form
    {
        NhanVienDALBLL nv = new NhanVienDALBLL();
        KhachHang_DAL_BLL kh = new KhachHang_DAL_BLL();
        HoaDonBan_DAL_BLL hd = new HoaDonBan_DAL_BLL();
        MayLanh_DAL_BLL ml = new MayLanh_DAL_BLL();
        ExcelExport_HDB exrp = new ExcelExport_HDB();

        private int idhd;
        private int sum;
        public FrmHoaDonBan()
        {
            InitializeComponent();
        }
        private void load()
        {
            ngaygiao.MaxDate = DateTime.Now.AddDays(15);
            ngaygiao.MinDate = DateTime.Now.Date;
            ngaygiao.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";

            ngaylap.Value = DateTime.Now;
            ngaylap.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";

            cboNV.DataSource = nv.getTenNVbyTDN(Program.FormMain.TenDN);
            cboNV.DisplayMember = "TenNV";
            cboNV.ValueMember = "Id";
            

            cboKH.DataSource = kh.getKH();
            cboKH.DisplayMember = "TenKH";
            cboKH.ValueMember = "Id";

            cboML.DataSource = ml.getML();
            cboML.DisplayMember = "TenML";
            cboML.ValueMember = "Id";


            txtMaCTHC.Enabled = MaHD.Enabled = soluong.Enabled = cboML.Enabled = txtDonGia.Enabled = txtThanhTien.Enabled = false;
            btnThem1.Enabled = btnLuu1.Enabled = btnSua1.Enabled = btnXoa1.Enabled = false;

            txtMaHD.Enabled = txtTT.Enabled = cboNV.Enabled = cboKH.Enabled = ngaygiao.Enabled = ngaylap.Enabled = false;
            btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled =false;
        }
        private void loadHD()
        {
            dataHD.DataSource = hd.getHD();
        }
        
        private void FrmHoaDonBan_Load(object sender, EventArgs e)
        {

            load();
            loadHD();
            
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int year, month, day, h, m, s;
        //    string a = ngaygiao.Value.Date.ToShortDateString();
        //    string[] list1 = a.Split('/');
        //    string b = giogiao.EditValue.ToString();
        //    string[] list = b.Split(':');
        //    day = int.Parse(list1[1]);
        //    month = int.Parse(list1[0]);
        //    year = int.Parse(list1[2]);
        //    h = int.Parse(list[0]);
        //    m = int.Parse(list[1]);
        //    s = int.Parse(list[2]);
        //    DateTime ngaygiaohang = new DateTime(year, month, day, h, m, s);
        //    DateTime ngaybanhang = DateTime.Now.Date + DateTime.Now.TimeOfDay;
        //    int idnv = int.Parse(cboNV.SelectedValue.ToString());
        //    int idkh = int.Parse(cboKH.SelectedValue.ToString());
        //    float tongtien = 0;
        //    if (String.IsNullOrEmpty(cboNV.Text) || String.IsNullOrEmpty(cboNV.Text) || String.IsNullOrEmpty(ngaylap.Text) || String.IsNullOrEmpty(ngaygiao.Text) || String.IsNullOrEmpty(giogiao.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập đủ thông tin hóa đơn !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else if (!hd.checkHD(idnv,idkh))
        //    {
        //        MessageBox.Show("Hóa đơn đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {

        //        if (hd.addHDB(idkh,idnv,ngaygiaohang,ngaybanhang,tongtien))
        //        {
        //            loadHD();
        //            txtMaHD.Text = txtTT.Text = "";
        //            txtMaHD.Enabled = txtTT.Enabled = cboNV.Enabled = cboKH.Enabled = ngaygiao.Enabled = ngaylap.Enabled = false;
        //            btnLuu.Enabled= false;
        //            MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }

        //    }
        //}

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime ngaygiaohang = ngaygiao.Value.Date + ngaygiao.Value.TimeOfDay;
            DateTime ngaybanhang = DateTime.Now.Date + DateTime.Now.TimeOfDay;
           
            if (String.IsNullOrEmpty(cboNV.Text) || String.IsNullOrEmpty(cboKH.Text) || String.IsNullOrEmpty(ngaylap.Text) || String.IsNullOrEmpty(ngaygiao.Text) )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin hóa đơn !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idnv = int.Parse(cboNV.SelectedValue.ToString());
                int idkh = int.Parse(cboKH.SelectedValue.ToString());
                float tongtien = 0;
                if (!hd.checkHD(idnv, idkh))
                {
                    MessageBox.Show("Hóa đơn đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (hd.addHDB(idkh, idnv, ngaygiaohang, ngaybanhang, tongtien))
                    {
                        loadHD();
                        txtMaHD.Text =  ""; txtThanhTien.Text = "0";

                         txtMaHD.Enabled = txtTT.Enabled = cboNV.Enabled = cboKH.Enabled = ngaygiao.Enabled = ngaylap.Enabled = false;
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
        private void btnThem_Click(object sender, EventArgs e)
        {
             cboKH.Enabled = ngaygiao.Enabled  = true;
            cboNV.Focus();
            btnLuu.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<CT_HoaDonBan> list = hd.getCT_HDBbyIDHD(idhd);
            foreach (CT_HoaDonBan a in list)
            {

                if (hd.deleteCT_HDB(a.Id))
                {
                    if (ml.updateSLT(a.IdML, -a.SoLuongBan))
                    {
                        continue;
                    }
                }
                else
                { break; }


            }
            
            if (!hd.checkCTHDbyHD(idhd))
            {
                MessageBox.Show("Chưa xóa hết chi tiết hóa đơn !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!hd.deleteHD(idhd))
                {
                    MessageBox.Show("Xóa thất bại !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Xóa thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    loadHD();
                     cboKH.Enabled = ngaygiao.Enabled = false;
                    btnSua.Enabled = btnXoa.Enabled = false;
                }
            }
        }
        public void deleteCTHTbyIDHD(int id)
        {
            
        }
        void loadCTHD(int idhd)
        {
            dataCTHD.DataSource = hd.getCTHDbyHD(idhd);
        }
        private void dataHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            idhd = int.Parse(dataHD.Rows[i].Cells[0].Value.ToString());
            MaHD.Text = idhd.ToString();
            txtTT.Text = dataHD.Rows[i].Cells[5].Value.ToString();
            txtMaHD.Text = idhd.ToString();
            cboKH.Text = dataHD.Rows[i].Cells[1].Value.ToString();
            cboNV.Text = dataHD.Rows[i].Cells[2].Value.ToString();
            ngaylap.Text = dataHD.Rows[i].Cells[3].Value.ToString();
            ngaygiao.Text = dataHD.Rows[i].Cells[4].Value.ToString();
            loadCTHD(idhd);
            btnSua.Enabled = btnXoa.Enabled = btnThem1.Enabled = btnIn.Enabled= true;
            cboNV.Enabled = cboKH.Enabled = ngaygiao.Enabled = true;
            cboNV.Focus();

        }
        private void loadML()
        {
            try
            {
                if (cboML.SelectedValue != null)
                {

                    double giaban = ml.getDonGiaBan(int.Parse(cboML.SelectedValue.ToString()));
                    txtDonGia.Text = giaban.ToString();
                    int sl = int.Parse(soluong.Value.ToString());
                    double tt = sl * giaban;
                    txtThanhTien.Text = tt.ToString();
                    soluong.Maximum = ml.getSLT(int.Parse(cboML.SelectedValue.ToString()));
                }
                
            }
            catch
            { }
        }
        private void cboML_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadML();
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

        private void btnThem1_Click(object sender, EventArgs e)
        {
            btnLuu1.Enabled = true;
            cboML.Enabled = soluong.Enabled = true;
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
                
                if (!hd.checkCTHD(idhd, idml))
                {
                    MessageBox.Show("Hóa đơn đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (hd.addCT_HDB(idhd, idml, sl,dongia, thanhtien))
                    {
                        if (hd.updateTT(idhd, sum) && ml.updateSLT(idml,sl))
                        {
                            soluong.Maximum = ml.getSLT(int.Parse(cboML.SelectedValue.ToString()));
                            loadCTHD(idhd);
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

        private void btnSua1_Click(object sender, EventArgs e)
        {
            double tt = double.Parse(txtThanhTien.Text);
            double sum = double.Parse(txtTT.Text);
            sum = sum - thanhtien + tt;
            txtTT.Text= sum.ToString();
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
              
                

                    if (hd.updateCT_HDB(id,idhd, idml, slmoi, dongia, tt))
                    {
                        if (hd.updateTT(idhd, sum) && ml.updateSLT(idml, slmoi-sl))
                        {
                            soluong.Maximum = ml.getSLT(int.Parse(cboML.SelectedValue.ToString()));
                            loadCTHD(idhd);
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
                if (hd.deleteCT_HDB(int.Parse(txtMaCTHC.Text)))
                {
                    if (hd.updateTT(idhd, sum) && ml.updateSLT(idml,-sl))
                    {
                        loadCTHD(idhd);
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
        int sl;
        double thanhtien;
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
            thanhtien =double.Parse( dataCTHD.Rows[i].Cells[5].Value.ToString());
            soluong.Enabled = true;
            btnSua1.Enabled = btnXoa1.Enabled= true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime ngaygiaohang = ngaygiao.Value.Date + ngaygiao.Value.TimeOfDay;
            DateTime ngaybanhang = ngaylap.Value.Date + ngaylap.Value.TimeOfDay;

            if (String.IsNullOrEmpty(cboNV.Text) || String.IsNullOrEmpty(cboKH.Text) || String.IsNullOrEmpty(ngaylap.Text) || String.IsNullOrEmpty(ngaygiao.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin hóa đơn !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idnv = int.Parse(cboNV.SelectedValue.ToString());
                int idkh = int.Parse(cboKH.SelectedValue.ToString());
                float tongtien = float.Parse(txtTT.Text);
               
                

                    if (hd.updateHD(idhd,idkh, idnv, ngaygiaohang, ngaybanhang, tongtien))
                    {
                        loadHD();
                        txtMaHD.Text = ""; txtThanhTien.Text = "0";

                        txtMaHD.Enabled = txtTT.Enabled = cboNV.Enabled = cboKH.Enabled = ngaygiao.Enabled = ngaylap.Enabled = false;
                        btnLuu.Enabled = false;
                        MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                exrp.ExportKhoa(list, ref file, true, count.ToString(), txtTT.Text, ngay, idhd.ToString(), cboNV.Text, cboKH.Text,ngaygiao.Value);
                btnSua.Enabled = btnXoa.Enabled = btnThem1.Enabled = btnIn.Enabled = false;
                cboNV.Enabled = cboKH.Enabled = false;

            }
            catch { }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
