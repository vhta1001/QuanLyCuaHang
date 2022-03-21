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
    public partial class FrmTuVan : Form
    {
        MayLanh_DAL_BLL ml = new MayLanh_DAL_BLL();
        KNN knn = new KNN();
        
        public FrmTuVan()
        {
            InitializeComponent();
           
        }

        private void FrmTuVan_Load(object sender, EventArgs e)
        {
            dtgv_TV.DataSource = ml.getML1();
            knn.LoadData(@"C:\Users\vhta1\Desktop\QLcuahang\Gui\bin\Debug\train.dat", KNN.DataType.TRAININGDATA);
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            float dtphong = float.Parse(txtDienTich.Text) / 40;
            float giatien = float.Parse(txtGiaTien.Text)/ (float)ml.maxGiaBan();
            float loai;
            if (cboLoaiDieuHoa.Text == "Điều hòa 1 chiều")
            {
                loai = (float)0;
            }
            else if (cboLoaiDieuHoa.Text == "Điều hòa 2 chiều")
            {
                loai = (float)1;
            }
            else
            {
                loai = 0;
            }
            float congnghe;
            if (cboLoaiDieuHoa.Text == "Không Inverter")
            {
                congnghe = (float)0;
            }
            else if (cboLoaiDieuHoa.Text == "Có Inverter")
            {
                congnghe = (float)1;
            }
            else
            {
                congnghe = 0;
            }
            string test = giatien.ToString() + "," + dtphong.ToString() + "," + loai.ToString() + "," + congnghe.ToString() + ", ";
           
            knn.LoadDatastring(test, KNN.DataType.TESTDATA);
            List<string> kq = new List<string>();
            kq = knn.Classify1(int.Parse(sl.Value.ToString()));
            dtgv_TV.DataSource =  ml.getMLTV(kq);

        }
    }
}
