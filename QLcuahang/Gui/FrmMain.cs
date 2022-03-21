using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
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
using DevExpress.XtraBars.Helpers;

namespace Gui
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        PhanQuyen_DAL_BLL PhanQuyen_DAL_BLL = new PhanQuyen_DAL_BLL();
        NhanVienDALBLL NhanVienDALBLL = new NhanVienDALBLL();

        string tenDN;

        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }
       
        

        public FrmMain()
        {
            InitializeComponent();
        }
        private Form isActive(Type type)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == type)
                    return form;
            }
            return null;
        }
        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FrmNhanVien));
            if (form == null)
            {
                FrmNhanVien frmNhanVien = new FrmNhanVien();
                frmNhanVien.MdiParent = this;
                frmNhanVien.Show();
            }
            else
                form.Activate();
                
        }

        public void FindMenuPhanQuyen(RibbonPageCollection mnuItems, string pScreenName, bool? pEnable)
        {
            if (pEnable == null)
            {
                return;
            }
            
            foreach (RibbonPage items in mnuItems)
            {
                if (items.Groups.Count > 0)
                {
                    foreach (RibbonPageGroup group in items.Groups)
                    {

                        if (group.ItemLinks.Count > 0)
                        {
                            foreach (BarButtonItemLink btn in group.ItemLinks)
                            {
                                if (string.Equals(pScreenName, btn.Caption))
                                { btn.Visible = (bool)pEnable; }
                                
                            }
                        }
                        else if (string.Equals(pScreenName, group.Name))
                        {
                            group.Visible = false;
                        }
                    }
                }
                else if (string.Equals(pScreenName, items.Name))
                {
                    items.Visible = (bool)pEnable;
                }
            }
        }

       
        private void FrmMain_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Pumpkin");
            int id = NhanVienDALBLL.getIDLoaiNV(TenDN);

            List<PhanQuyen> a = PhanQuyen_DAL_BLL.getPQbyNV(id);
            foreach (PhanQuyen items in a)
            {
                FindMenuPhanQuyen(this.Ribbon.Pages, items.IdManHinh, items.CoQuyen);
            }



        }

        private void barButtonPasswordChange_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FrmPasswordChange));
            if (form == null)
            {
                FrmPasswordChange frmPasswordChange = new FrmPasswordChange();
                frmPasswordChange.MdiParent = this;
                frmPasswordChange.Show();
            }
            else
                form.Activate();
        }

        private void barButtonLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.FormLogin.Active++;
            if (Program.FormLogin.Active > 1)
            {
                this.Close();
                Program.FormLogin.ShowDialog();
            }
            

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.FormLogin.Active == 1)
            {
                Application.Exit();
            }
            
            //if (MessageBox.Show("Bạn có chắc chắn muốn thoát ???", "???", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            //{
            //    Application.Exit();
            //}
        }

        private void barButtonExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnML_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FrmMayLanh));
            if (form == null)
            {
                FrmMayLanh frmMayLanh = new FrmMayLanh();
                frmMayLanh.MdiParent = this;
                frmMayLanh.Show();
            }
            else
                form.Activate();
        }

        private void btnNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FrmNCC));
            if (form == null)
            {
                FrmNCC frmNCC = new FrmNCC();
                frmNCC.MdiParent = this;
                frmNCC.Show();
            }
            else
                form.Activate();
        }

        private void btnKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FrmKhachHang));
            if (form == null)
            {
                FrmKhachHang frmKH = new FrmKhachHang();
                frmKH.MdiParent = this;
                frmKH.Show();
            }
            else
                form.Activate();
        }

        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FrmPhanQuyen));
            if (form == null)
            {
                FrmPhanQuyen frmPQ = new FrmPhanQuyen();
                frmPQ.MdiParent = this;
                frmPQ.Show();
            }
            else
                form.Activate();
        }

        private void btnNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FrmHoaDonNhap));
            if (form == null)
            {
                FrmHoaDonNhap frmHDN = new FrmHoaDonNhap();
                frmHDN.MdiParent = this;
                frmHDN.Show();
            }
            else
                form.Activate();
        }

        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FrmHoaDonBan));
            if (form == null)
            {
                FrmHoaDonBan frmHDB = new FrmHoaDonBan();
                frmHDB.MdiParent = this;
                frmHDB.Show();
            }
            else
                form.Activate();
        }

        private void btnTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FrmThongKe));
            if (form == null)
            {
                FrmThongKe frmTK = new FrmThongKe();
                frmTK.MdiParent = this;
                frmTK.Show();
            }
            else
                form.Activate();
        }
    }
}