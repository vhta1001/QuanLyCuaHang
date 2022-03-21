
namespace Gui
{
    partial class FrmNCC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNCC));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtDCNCC = new System.Windows.Forms.TextBox();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.16F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 41.18F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 65.9F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43.76F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 92.75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 7.25F)});
            this.tablePanel1.Controls.Add(this.txtDCNCC);
            this.tablePanel1.Controls.Add(this.txtSDTNCC);
            this.tablePanel1.Controls.Add(this.txtTenNCC);
            this.tablePanel1.Controls.Add(this.txtMaNCC);
            this.tablePanel1.Controls.Add(this.dataGridView1);
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Controls.Add(this.label4);
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.92F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 42.28F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55.59998F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 71.59999F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 150.0002F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1095, 510);
            this.tablePanel1.TabIndex = 0;
            this.tablePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel1_Paint);
            // 
            // txtDCNCC
            // 
            this.tablePanel1.SetColumn(this.txtDCNCC, 4);
            this.txtDCNCC.Location = new System.Drawing.Point(677, 121);
            this.txtDCNCC.Name = "txtDCNCC";
            this.tablePanel1.SetRow(this.txtDCNCC, 2);
            this.txtDCNCC.Size = new System.Drawing.Size(385, 28);
            this.txtDCNCC.TabIndex = 22;
            // 
            // txtSDTNCC
            // 
            this.tablePanel1.SetColumn(this.txtSDTNCC, 4);
            this.txtSDTNCC.Location = new System.Drawing.Point(677, 54);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.tablePanel1.SetRow(this.txtSDTNCC, 1);
            this.txtSDTNCC.Size = new System.Drawing.Size(385, 28);
            this.txtSDTNCC.TabIndex = 21;
            this.txtSDTNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTNCC_KeyPress);
            // 
            // txtTenNCC
            // 
            this.tablePanel1.SetColumn(this.txtTenNCC, 2);
            this.txtTenNCC.Location = new System.Drawing.Point(215, 121);
            this.txtTenNCC.Name = "txtTenNCC";
            this.tablePanel1.SetRow(this.txtTenNCC, 2);
            this.txtTenNCC.Size = new System.Drawing.Size(272, 28);
            this.txtTenNCC.TabIndex = 20;
            // 
            // txtMaNCC
            // 
            this.tablePanel1.SetColumn(this.txtMaNCC, 2);
            this.txtMaNCC.Location = new System.Drawing.Point(215, 54);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.tablePanel1.SetRow(this.txtMaNCC, 1);
            this.txtMaNCC.Size = new System.Drawing.Size(272, 28);
            this.txtMaNCC.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.dataGridView1, 1);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tablePanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Location = new System.Drawing.Point(43, 275);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.tablePanel1.SetRow(this.dataGridView1, 4);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 196);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Mã nhà cung cấp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNCC";
            this.Column2.HeaderText = "Tên nhà cung cấp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDTNCC";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // panel1
            // 
            this.tablePanel1.SetColumn(this.panel1, 1);
            this.tablePanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Location = new System.Drawing.Point(45, 185);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panel1.Name = "panel1";
            this.tablePanel1.SetRow(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(1014, 73);
            this.panel1.TabIndex = 17;
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
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(236, 7);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(151, 56);
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
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(22, 7);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 56);
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
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(712, 9);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(157, 56);
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
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(492, 7);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(151, 56);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tablePanel1.SetColumn(this.label4, 3);
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.tablePanel1.SetRow(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tablePanel1.SetColumn(this.label3, 1);
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.tablePanel1.SetRow(this.label3, 2);
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhà cung cấp :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel1.SetColumn(this.label2, 3);
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 1);
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel1.SetColumn(this.label1, 1);
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 1);
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp :";
            // 
            // FrmNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 510);
            this.Controls.Add(this.tablePanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNCC";
            this.Text = "FrmNCC";
            this.Load += new System.EventHandler(this.FrmNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDCNCC;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}