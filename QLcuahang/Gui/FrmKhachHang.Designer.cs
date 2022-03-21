
namespace Gui
{
    partial class FrmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Gpb_ThongTin = new System.Windows.Forms.GroupBox();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.dtgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            this.Gpb_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KhachHang)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.tablePanel1.SetColumn(this.groupBox1, 1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(63, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.tablePanel1.SetRow(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(1206, 90);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablePanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 61);
            this.panel1.TabIndex = 18;
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43.27F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43.52F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 42.44F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 47.57F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 44.06F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 54.32F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 51.62F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel3.Controls.Add(this.btnXoa);
            this.tablePanel3.Controls.Add(this.btnThem);
            this.tablePanel3.Controls.Add(this.btnLuu);
            this.tablePanel3.Controls.Add(this.btnSua);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(0, 0);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(1198, 61);
            this.tablePanel3.TabIndex = 11;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.White;
            this.btnLuu.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLuu.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Appearance.Options.UseBorderColor = true;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.tablePanel3.SetColumn(this.btnLuu, 2);
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(281, 8);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnLuu.Name = "btnLuu";
            this.tablePanel3.SetRow(this.btnLuu, 0);
            this.btnLuu.Size = new System.Drawing.Size(125, 45);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = System.Drawing.Color.White;
            this.btnThem.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseBorderColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.tablePanel3.SetColumn(this.btnThem, 0);
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(5, 8);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnThem.Name = "btnThem";
            this.tablePanel3.SetRow(this.btnThem, 0);
            this.btnThem.Size = new System.Drawing.Size(128, 45);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.BackColor = System.Drawing.Color.White;
            this.btnXoa.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.tablePanel3.SetColumn(this.btnXoa, 6);
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(880, 8);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnXoa.Name = "btnXoa";
            this.tablePanel3.SetRow(this.btnXoa, 0);
            this.btnXoa.Size = new System.Drawing.Size(154, 45);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.tablePanel3.SetColumn(this.btnSua, 4);
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(567, 8);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnSua.Name = "btnSua";
            this.tablePanel3.SetRow(this.btnSua, 0);
            this.btnSua.Size = new System.Drawing.Size(130, 45);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.label6, 1);
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(63, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.tablePanel1.SetRow(this.label6, 0);
            this.label6.Size = new System.Drawing.Size(1206, 61);
            this.label6.TabIndex = 24;
            this.label6.Text = "DANH SÁCH KHÁCH HÀNG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gpb_ThongTin
            // 
            this.tablePanel1.SetColumn(this.Gpb_ThongTin, 1);
            this.Gpb_ThongTin.Controls.Add(this.tablePanel2);
            this.Gpb_ThongTin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_ThongTin.ForeColor = System.Drawing.Color.Black;
            this.Gpb_ThongTin.Location = new System.Drawing.Point(62, 64);
            this.Gpb_ThongTin.Name = "Gpb_ThongTin";
            this.tablePanel1.SetRow(this.Gpb_ThongTin, 1);
            this.Gpb_ThongTin.Size = new System.Drawing.Size(1208, 144);
            this.Gpb_ThongTin.TabIndex = 23;
            this.Gpb_ThongTin.TabStop = false;
            this.Gpb_ThongTin.Text = "Thông tin khách hàng";
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33.98F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 39.54F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 41.42F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.06F)});
            this.tablePanel2.Controls.Add(this.txtDiaChi);
            this.tablePanel2.Controls.Add(this.label11);
            this.tablePanel2.Controls.Add(this.label4);
            this.tablePanel2.Controls.Add(this.txtTenKH);
            this.tablePanel2.Controls.Add(this.txtMaKH);
            this.tablePanel2.Controls.Add(this.label1);
            this.tablePanel2.Controls.Add(this.label7);
            this.tablePanel2.Controls.Add(this.txtDienThoai);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(3, 24);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40.2F)});
            this.tablePanel2.Size = new System.Drawing.Size(1202, 117);
            this.tablePanel2.TabIndex = 28;
            // 
            // txtDiaChi
            // 
            this.tablePanel2.SetColumn(this.txtDiaChi, 3);
            this.txtDiaChi.Location = new System.Drawing.Point(866, 16);
            this.txtDiaChi.Name = "txtDiaChi";
            this.tablePanel2.SetRow(this.txtDiaChi, 0);
            this.txtDiaChi.Size = new System.Drawing.Size(333, 28);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtMaKH
            // 
            this.tablePanel2.SetColumn(this.txtMaKH, 1);
            this.txtMaKH.Location = new System.Drawing.Point(258, 16);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.tablePanel2.SetRow(this.txtMaKH, 0);
            this.txtMaKH.Size = new System.Drawing.Size(291, 28);
            this.txtMaKH.TabIndex = 6;
            // 
            // txtTenKH
            // 
            this.tablePanel2.SetColumn(this.txtTenKH, 1);
            this.txtTenKH.Location = new System.Drawing.Point(258, 74);
            this.txtTenKH.Name = "txtTenKH";
            this.tablePanel2.SetRow(this.txtTenKH, 1);
            this.txtTenKH.Size = new System.Drawing.Size(291, 28);
            this.txtTenKH.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel2.SetColumn(this.label7, 2);
            this.label7.Location = new System.Drawing.Point(555, 13);
            this.label7.Name = "label7";
            this.tablePanel2.SetRow(this.label7, 0);
            this.label7.Size = new System.Drawing.Size(305, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel2.SetColumn(this.label4, 2);
            this.label4.Location = new System.Drawing.Point(555, 72);
            this.label4.Name = "label4";
            this.tablePanel2.SetRow(this.label4, 1);
            this.label4.Size = new System.Drawing.Size(305, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện thoại:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel2.SetColumn(this.label1, 0);
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.tablePanel2.SetRow(this.label1, 1);
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel2.SetColumn(this.label11, 0);
            this.label11.Location = new System.Drawing.Point(3, 13);
            this.label11.Name = "label11";
            this.tablePanel2.SetRow(this.label11, 0);
            this.label11.Size = new System.Drawing.Size(249, 33);
            this.label11.TabIndex = 6;
            this.label11.Text = "Mã khách hàng:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDienThoai
            // 
            this.tablePanel2.SetColumn(this.txtDienThoai, 3);
            this.txtDienThoai.Location = new System.Drawing.Point(866, 74);
            this.txtDienThoai.Name = "txtDienThoai";
            this.tablePanel2.SetRow(this.txtDienThoai, 1);
            this.txtDienThoai.Size = new System.Drawing.Size(333, 28);
            this.txtDienThoai.TabIndex = 7;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // dtgv_KhachHang
            // 
            this.dtgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6});
            this.dtgv_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_KhachHang.Location = new System.Drawing.Point(3, 24);
            this.dtgv_KhachHang.Name = "dtgv_KhachHang";
            this.dtgv_KhachHang.RowHeadersWidth = 51;
            this.dtgv_KhachHang.RowTemplate.Height = 24;
            this.dtgv_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_KhachHang.Size = new System.Drawing.Size(1202, 349);
            this.dtgv_KhachHang.TabIndex = 0;
            this.dtgv_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_KhachHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENKH";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "Điện thoại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DIACHIKH";
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // groupBox4
            // 
            this.tablePanel1.SetColumn(this.groupBox4, 1);
            this.groupBox4.Controls.Add(this.dtgv_KhachHang);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(62, 312);
            this.groupBox4.Name = "groupBox4";
            this.tablePanel1.SetRow(this.groupBox4, 3);
            this.groupBox4.Size = new System.Drawing.Size(1208, 376);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách khách hàng";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 103F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F)});
            this.tablePanel1.Controls.Add(this.label6);
            this.tablePanel1.Controls.Add(this.groupBox4);
            this.tablePanel1.Controls.Add(this.groupBox1);
            this.tablePanel1.Controls.Add(this.Gpb_ThongTin);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 61.2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 149.9997F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 98.00027F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 381.9991F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1297, 713);
            this.tablePanel1.TabIndex = 27;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 713);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.Gpb_ThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KhachHang)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Gpb_ThongTin;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_KhachHang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDienThoai;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}