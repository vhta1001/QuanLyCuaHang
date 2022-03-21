
namespace Gui
{
    partial class FrmTuVan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTuVan));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgv_TV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.btnTV = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.Gpb_ThongTin = new System.Windows.Forms.GroupBox();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.cboTinhNang = new System.Windows.Forms.ComboBox();
            this.cboLoaiDieuHoa = new System.Windows.Forms.ComboBox();
            this.sl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            this.Gpb_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sl)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2.92F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 105.08F),
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
            this.tablePanel1.Size = new System.Drawing.Size(1339, 721);
            this.tablePanel1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.label6, 1);
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(40, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.tablePanel1.SetRow(this.label6, 0);
            this.label6.Size = new System.Drawing.Size(1271, 61);
            this.label6.TabIndex = 24;
            this.label6.Text = "TƯ VẤN MUA HÀNG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.tablePanel1.SetColumn(this.groupBox4, 1);
            this.groupBox4.Controls.Add(this.dtgv_TV);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(39, 312);
            this.groupBox4.Name = "groupBox4";
            this.tablePanel1.SetRow(this.groupBox4, 3);
            this.groupBox4.Size = new System.Drawing.Size(1273, 376);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách khách hàng";
            // 
            // dtgv_TV
            // 
            this.dtgv_TV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_TV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_TV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dtgv_TV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_TV.Location = new System.Drawing.Point(3, 24);
            this.dtgv_TV.Name = "dtgv_TV";
            this.dtgv_TV.RowHeadersWidth = 51;
            this.dtgv_TV.RowTemplate.Height = 24;
            this.dtgv_TV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_TV.Size = new System.Drawing.Size(1267, 349);
            this.dtgv_TV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tablePanel1.SetColumn(this.groupBox1, 1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(40, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.tablePanel1.SetRow(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(1271, 90);
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
            this.panel1.Size = new System.Drawing.Size(1263, 61);
            this.panel1.TabIndex = 18;
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.97F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 57.82F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 42.44F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 47.57F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 44.06F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 54.32F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 51.62F)});
            this.tablePanel3.Controls.Add(this.btnTV);
            this.tablePanel3.Controls.Add(this.btnClear);
            this.tablePanel3.Controls.Add(this.btnSua);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(0, 0);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(1263, 61);
            this.tablePanel3.TabIndex = 11;
            // 
            // btnTV
            // 
            this.btnTV.Appearance.BackColor = System.Drawing.Color.White;
            this.btnTV.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTV.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnTV.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTV.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTV.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnTV.Appearance.Options.UseBackColor = true;
            this.btnTV.Appearance.Options.UseBorderColor = true;
            this.btnTV.Appearance.Options.UseFont = true;
            this.btnTV.Appearance.Options.UseForeColor = true;
            this.tablePanel3.SetColumn(this.btnTV, 1);
            this.btnTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTV.ImageOptions.Image")));
            this.btnTV.Location = new System.Drawing.Point(117, 8);
            this.btnTV.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnTV.Name = "btnTV";
            this.tablePanel3.SetRow(this.btnTV, 0);
            this.btnTV.Size = new System.Drawing.Size(213, 45);
            this.btnTV.TabIndex = 8;
            this.btnTV.Text = "Tư vấn khách hàng";
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = System.Drawing.Color.White;
            this.btnClear.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseBorderColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Appearance.Options.UseForeColor = true;
            this.tablePanel3.SetColumn(this.btnClear, 3);
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(504, 8);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnClear.Name = "btnClear";
            this.tablePanel3.SetRow(this.btnClear, 0);
            this.btnClear.Size = new System.Drawing.Size(174, 45);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.tablePanel3.SetColumn(this.btnSua, 5);
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(859, 8);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnSua.Name = "btnSua";
            this.tablePanel3.SetRow(this.btnSua, 0);
            this.btnSua.Size = new System.Drawing.Size(200, 45);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            // 
            // Gpb_ThongTin
            // 
            this.tablePanel1.SetColumn(this.Gpb_ThongTin, 1);
            this.Gpb_ThongTin.Controls.Add(this.tablePanel2);
            this.Gpb_ThongTin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_ThongTin.ForeColor = System.Drawing.Color.Black;
            this.Gpb_ThongTin.Location = new System.Drawing.Point(39, 64);
            this.Gpb_ThongTin.Name = "Gpb_ThongTin";
            this.tablePanel1.SetRow(this.Gpb_ThongTin, 1);
            this.Gpb_ThongTin.Size = new System.Drawing.Size(1273, 144);
            this.Gpb_ThongTin.TabIndex = 23;
            this.Gpb_ThongTin.TabStop = false;
            this.Gpb_ThongTin.Text = "Thông tin tư vấn";
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33.98F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 39.54F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 41.42F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.06F)});
            this.tablePanel2.Controls.Add(this.cboTinhNang);
            this.tablePanel2.Controls.Add(this.cboLoaiDieuHoa);
            this.tablePanel2.Controls.Add(this.sl);
            this.tablePanel2.Controls.Add(this.label2);
            this.tablePanel2.Controls.Add(this.label11);
            this.tablePanel2.Controls.Add(this.label4);
            this.tablePanel2.Controls.Add(this.txtDienTich);
            this.tablePanel2.Controls.Add(this.txtGiaTien);
            this.tablePanel2.Controls.Add(this.label1);
            this.tablePanel2.Controls.Add(this.label7);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(3, 24);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40.2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(1267, 117);
            this.tablePanel2.TabIndex = 28;
            // 
            // cboTinhNang
            // 
            this.tablePanel2.SetColumn(this.cboTinhNang, 3);
            this.cboTinhNang.FormattingEnabled = true;
            this.cboTinhNang.Items.AddRange(new object[] {
            "Có Inverter",
            "Không Inverter"});
            this.cboTinhNang.Location = new System.Drawing.Point(913, 54);
            this.cboTinhNang.Name = "cboTinhNang";
            this.tablePanel2.SetRow(this.cboTinhNang, 1);
            this.cboTinhNang.Size = new System.Drawing.Size(351, 29);
            this.cboTinhNang.TabIndex = 11;
            // 
            // cboLoaiDieuHoa
            // 
            this.tablePanel2.SetColumn(this.cboLoaiDieuHoa, 3);
            this.cboLoaiDieuHoa.FormattingEnabled = true;
            this.cboLoaiDieuHoa.Items.AddRange(new object[] {
            "Điều hòa 1 chiều",
            "Điều hòa 2 chiều"});
            this.cboLoaiDieuHoa.Location = new System.Drawing.Point(913, 9);
            this.cboLoaiDieuHoa.Name = "cboLoaiDieuHoa";
            this.tablePanel2.SetRow(this.cboLoaiDieuHoa, 0);
            this.cboLoaiDieuHoa.Size = new System.Drawing.Size(351, 29);
            this.cboLoaiDieuHoa.TabIndex = 10;
            // 
            // sl
            // 
            this.tablePanel2.SetColumn(this.sl, 3);
            this.sl.Location = new System.Drawing.Point(913, 94);
            this.sl.Name = "sl";
            this.tablePanel2.SetRow(this.sl, 2);
            this.sl.Size = new System.Drawing.Size(351, 28);
            this.sl.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel2.SetColumn(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(585, 93);
            this.label2.Name = "label2";
            this.tablePanel2.SetRow(this.label2, 2);
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel2.SetColumn(this.label11, 0);
            this.label11.Location = new System.Drawing.Point(3, 7);
            this.label11.Name = "label11";
            this.tablePanel2.SetRow(this.label11, 0);
            this.label11.Size = new System.Drawing.Size(263, 33);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nhập giá tiền";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel2.SetColumn(this.label4, 2);
            this.label4.Location = new System.Drawing.Point(585, 52);
            this.label4.Name = "label4";
            this.tablePanel2.SetRow(this.label4, 1);
            this.label4.Size = new System.Drawing.Size(322, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập tính năng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDienTich
            // 
            this.tablePanel2.SetColumn(this.txtDienTich, 1);
            this.txtDienTich.Location = new System.Drawing.Point(272, 55);
            this.txtDienTich.Name = "txtDienTich";
            this.tablePanel2.SetRow(this.txtDienTich, 1);
            this.txtDienTich.Size = new System.Drawing.Size(307, 28);
            this.txtDienTich.TabIndex = 1;
            // 
            // txtGiaTien
            // 
            this.tablePanel2.SetColumn(this.txtGiaTien, 1);
            this.txtGiaTien.Location = new System.Drawing.Point(272, 9);
            this.txtGiaTien.Name = "txtGiaTien";
            this.tablePanel2.SetRow(this.txtGiaTien, 0);
            this.txtGiaTien.Size = new System.Drawing.Size(307, 28);
            this.txtGiaTien.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel2.SetColumn(this.label1, 0);
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.tablePanel2.SetRow(this.label1, 1);
            this.label1.Size = new System.Drawing.Size(263, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập diện tích phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel2.SetColumn(this.label7, 2);
            this.label7.Location = new System.Drawing.Point(585, 7);
            this.label7.Name = "label7";
            this.tablePanel2.SetRow(this.label7, 0);
            this.label7.Size = new System.Drawing.Size(322, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhập loại điều hòa";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Mã máy lạnh";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IDNCC";
            this.Column2.HeaderText = "Nhà cung cấp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenML";
            this.Column5.HeaderText = "Tên máy lạnh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "congsuat";
            this.Column6.HeaderText = "Công suất";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tinhnang";
            this.Column3.HeaderText = "Loại máy";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "congnghe";
            this.Column4.HeaderText = "Công nghệ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "dongiaban";
            this.Column7.HeaderText = "Giá tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "namsx";
            this.Column8.HeaderText = "Năm SX";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "dongianhap";
            this.Column9.HeaderText = "Giá nhập";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "soluongton";
            this.Column10.HeaderText = "Số lượng tồn";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // FrmTuVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 721);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmTuVan";
            this.Text = "FrmTuVan";
            this.Load += new System.EventHandler(this.FrmTuVan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.Gpb_ThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgv_TV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.SimpleButton btnTV;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.GroupBox Gpb_ThongTin;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown sl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTinhNang;
        private System.Windows.Forms.ComboBox cboLoaiDieuHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}