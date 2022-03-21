
namespace Gui
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnML = new DevExpress.XtraBars.BarButtonItem();
            this.btnNCC = new DevExpress.XtraBars.BarButtonItem();
            this.btnKH = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonExit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPasswordChange = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnTK = new DevExpress.XtraBars.BarButtonItem();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbHeThong1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbdanhmuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbDanhmuc1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDanhMuc2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnNhanVien,
            this.btnPhanQuyen,
            this.btnML,
            this.btnNCC,
            this.btnKH,
            this.barButtonExit,
            this.barButtonLogout,
            this.barButtonPasswordChange,
            this.btnNhapHang,
            this.btnBanHang,
            this.skinDropDownButtonItem1,
            this.barEditItem1,
            this.barEditItem2,
            this.btnTK});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHeThong,
            this.rbdanhmuc,
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.ribbon.Size = new System.Drawing.Size(1137, 210);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 1;
            this.btnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.Image")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Phân quyền";
            this.btnPhanQuyen.Id = 2;
            this.btnPhanQuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyen.ImageOptions.Image")));
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhanQuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanQuyen_ItemClick);
            // 
            // btnML
            // 
            this.btnML.Caption = "Máy lạnh";
            this.btnML.Id = 3;
            this.btnML.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnML.ImageOptions.Image")));
            this.btnML.Name = "btnML";
            this.btnML.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnML.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnML_ItemClick);
            // 
            // btnNCC
            // 
            this.btnNCC.Caption = "Nhà cung cấp";
            this.btnNCC.Id = 4;
            this.btnNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNCC.ImageOptions.Image")));
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNCC_ItemClick);
            // 
            // btnKH
            // 
            this.btnKH.Caption = "Khách hàng";
            this.btnKH.Id = 5;
            this.btnKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKH.ImageOptions.Image")));
            this.btnKH.Name = "btnKH";
            this.btnKH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKH_ItemClick);
            // 
            // barButtonExit
            // 
            this.barButtonExit.Caption = "Thoát";
            this.barButtonExit.Id = 6;
            this.barButtonExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonExit.ImageOptions.Image")));
            this.barButtonExit.Name = "barButtonExit";
            this.barButtonExit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonExit_ItemClick);
            // 
            // barButtonLogout
            // 
            this.barButtonLogout.Caption = "Đăng xuất";
            this.barButtonLogout.Id = 7;
            this.barButtonLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonLogout.ImageOptions.Image")));
            this.barButtonLogout.Name = "barButtonLogout";
            this.barButtonLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLogout_ItemClick);
            // 
            // barButtonPasswordChange
            // 
            this.barButtonPasswordChange.Caption = "Đổi mật khẩu";
            this.barButtonPasswordChange.Id = 8;
            this.barButtonPasswordChange.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonPasswordChange.ImageOptions.Image")));
            this.barButtonPasswordChange.Name = "barButtonPasswordChange";
            this.barButtonPasswordChange.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonPasswordChange.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPasswordChange_ItemClick);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Caption = "Nhập hàng";
            this.btnNhapHang.Id = 9;
            this.btnNhapHang.ImageOptions.Image = global::Gui.Properties.Resources.buy_button;
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhapHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapHang_ItemClick);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Caption = "Bán hàng";
            this.btnBanHang.Id = 10;
            this.btnBanHang.ImageOptions.Image = global::Gui.Properties.Resources.selling;
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanHang_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 11;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 12;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Edit = this.repositoryItemTextEdit2;
            this.barEditItem2.Id = 13;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // btnTK
            // 
            this.btnTK.Caption = "Thống kê";
            this.btnTK.Id = 14;
            this.btnTK.ImageOptions.Image = global::Gui.Properties.Resources.statistics;
            this.btnTK.Name = "btnTK";
            this.btnTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTK_ItemClick);
            // 
            // rbHeThong
            // 
            this.rbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbHeThong1});
            this.rbHeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbHeThong.ImageOptions.Image")));
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ thống";
            // 
            // rbHeThong1
            // 
            this.rbHeThong1.ItemLinks.Add(this.barButtonExit);
            this.rbHeThong1.ItemLinks.Add(this.barButtonLogout);
            this.rbHeThong1.ItemLinks.Add(this.barButtonPasswordChange);
            this.rbHeThong1.Name = "rbHeThong1";
            // 
            // rbdanhmuc
            // 
            this.rbdanhmuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbDanhmuc1,
            this.rbDanhMuc2});
            this.rbdanhmuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbdanhmuc.ImageOptions.Image")));
            this.rbdanhmuc.Name = "rbdanhmuc";
            this.rbdanhmuc.Text = "Danh mục";
            // 
            // rbDanhmuc1
            // 
            this.rbDanhmuc1.ItemLinks.Add(this.btnNhanVien);
            this.rbDanhmuc1.ItemLinks.Add(this.btnML);
            this.rbDanhmuc1.ItemLinks.Add(this.btnNCC);
            this.rbDanhmuc1.ItemLinks.Add(this.btnKH);
            this.rbDanhmuc1.Name = "rbDanhmuc1";
            // 
            // rbDanhMuc2
            // 
            this.rbDanhMuc2.ItemLinks.Add(this.btnPhanQuyen);
            this.rbDanhMuc2.Name = "rbDanhMuc2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = global::Gui.Properties.Resources.buy__1_;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBanHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTK);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 599);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1137, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 630);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbHeThong1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbdanhmuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDanhmuc1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDanhMuc2;
        private DevExpress.XtraBars.BarButtonItem btnML;
        private DevExpress.XtraBars.BarButtonItem btnNCC;
        private DevExpress.XtraBars.BarButtonItem btnKH;
        private DevExpress.XtraBars.BarButtonItem barButtonExit;
        private DevExpress.XtraBars.BarButtonItem barButtonLogout;
        private DevExpress.XtraBars.BarButtonItem barButtonPasswordChange;
        private DevExpress.XtraBars.BarButtonItem btnNhapHang;
        private DevExpress.XtraBars.BarButtonItem btnBanHang;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarButtonItem btnTK;
    }
}