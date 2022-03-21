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
    public partial class FrmThongKe : Form
    {
        NhanVienDALBLL nv = new NhanVienDALBLL();
        MayLanh_DAL_BLL ml = new MayLanh_DAL_BLL();
        HoaDonBan_DAL_BLL hd = new HoaDonBan_DAL_BLL();
        ExcelExport_TK tk = new ExcelExport_TK();
        
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;
            dateTimePicker2.MinDate = dateTimePicker1.Value.Date;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                comboBox1.Enabled = false;

            }
            else if (radioButton2.Checked)
            {
                comboBox1.Enabled = true;
                comboBox1.DataSource = ml.getML();
                comboBox1.DisplayMember = "TenML";
                comboBox1.ValueMember = "Id";
            }
            else
            {
                comboBox1.Enabled = true;
                comboBox1.DataSource = nv.getNV();
                comboBox1.DisplayMember = "TenNV";
                comboBox1.ValueMember = "Id";
            }


        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            if (radioButton1.Checked)
            {
                int idnv = int.Parse(comboBox1.SelectedValue.ToString());
                dataGridView1.DataSource = hd.getHDbyNV(idnv, start, end);
               

            }
            else if (radioButton2.Checked)
            {
                int idml = int.Parse(comboBox1.SelectedValue.ToString());
                dataGridView1.DataSource = hd.getHDbyML(idml, start, end);
            }
            else
            {
                dataGridView1.DataSource = hd.getHD(start, end);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value.Date;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                double t = 0;
                List<TK> ds = new List<TK>();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    TK a = new TK();
                    a.Id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    a.TenKH = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    a.TenNV = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    a.NgayLap = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    a.NgayGiao = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    a.TongTien = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    ds.Add(a);
                    t += double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                }
                string count = dataGridView1.Rows.Count.ToString();
                string tong = t.ToString();
                string file = Path.GetTempFileName() + Constants.FILE_EXT_XLS;
                string tenNV = nv.getTenNV(Program.FormMain.TenDN);
                tk.ExportKhoa(ds, ref file, true, count, tong,tenNV);
                //tk.OpenFile();
            }
            catch { }

        }
    }
}
