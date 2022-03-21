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
    public partial class FrmPhanQuyen : Form
    {
        ManHinh_DAL_BLL manHinh = new ManHinh_DAL_BLL();
        PhanQuyen_DAL_BLL phanQuyen = new PhanQuyen_DAL_BLL();
        LoaiNV_DAL_BLL loaiNV = new LoaiNV_DAL_BLL();
        public FrmPhanQuyen()
        {
            InitializeComponent();
            
            
        }

        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            
            cboLoaiNV.DataSource = loaiNV.getLoaiNV();
            cboLoaiNV.DisplayMember = "tenloainv";
            cboLoaiNV.ValueMember = "id";
            cboLoaiNV.SelectedIndex = -1;

            



        }
        void load()
        {
            try
            {
                if (cboLoaiNV.SelectedValue != null)
                {
                    dataPhanQuyen.DataSource = phanQuyen.getPQbyLoaiNV((int)cboLoaiNV.SelectedValue);
                    
                }
            }
            catch
            {

            }
        }
        private void cboLoaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {

            load();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //List<PhanQuyen> list = ((List<PhanQuyen>)dataPhanQuyen.DataSource).Cast<object>().ToList();
        }

        private void dataPhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int id = int.Parse(dataPhanQuyen.Rows[i].Cells[0].Value.ToString());
            DataGridViewCheckBoxCell a = new DataGridViewCheckBoxCell();
            
            a = (DataGridViewCheckBoxCell)dataPhanQuyen.Rows[i].Cells[3];
            a.TrueValue = true;
            a.FalseValue = false;


            if (a.Value == null || a.Value == a.FalseValue || a.Value.ToString() == "False")
            {
                if (phanQuyen.PQ(id, true))
                {
                    load();
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            else if (a.Value == a.TrueValue || a.Value.ToString() == "True")
            {
                if (phanQuyen.PQ(id, false))
                {
                    load();
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            dataPhanQuyen.EndEdit();
            

        }
    }
}
