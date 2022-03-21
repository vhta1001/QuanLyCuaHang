
namespace Gui
{
    partial class FrmThongKe
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 99.94F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5.06F)});
            this.tablePanel1.Controls.Add(this.groupBox1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 496.3991F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1024, 535);
            this.tablePanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tablePanel1.SetColumn(this.groupBox1, 1);
            this.groupBox1.Controls.Add(this.tablePanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(50, 29);
            this.groupBox1.Name = "groupBox1";
            this.tablePanel1.SetRow(this.groupBox1, 1);
            this.groupBox1.Size = new System.Drawing.Size(924, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu";
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 39.14F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 39.22F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.64F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.dataGridView1);
            this.tablePanel2.Controls.Add(this.btnXuatExcel);
            this.tablePanel2.Controls.Add(this.btnThongKe);
            this.tablePanel2.Controls.Add(this.comboBox1);
            this.tablePanel2.Controls.Add(this.radioButton2);
            this.tablePanel2.Controls.Add(this.radioButton1);
            this.tablePanel2.Controls.Add(this.label2);
            this.tablePanel2.Controls.Add(this.label1);
            this.tablePanel2.Controls.Add(this.dateTimePicker2);
            this.tablePanel2.Controls.Add(this.dateTimePicker1);
            this.tablePanel2.Controls.Add(this.radioButton3);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(3, 24);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 41.99998F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40.39999F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 52.39998F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(918, 463);
            this.tablePanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePanel2.SetColumn(this.dataGridView1, 0);
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.tablePanel2.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.tablePanel2.SetRow(this.dataGridView1, 3);
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(912, 323);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnXuatExcel
            // 
            this.tablePanel2.SetColumn(this.btnXuatExcel, 2);
            this.btnXuatExcel.Location = new System.Drawing.Point(453, 93);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.tablePanel2.SetRow(this.btnXuatExcel, 2);
            this.btnXuatExcel.Size = new System.Drawing.Size(176, 29);
            this.btnXuatExcel.TabIndex = 8;
            this.btnXuatExcel.Text = "simpleButton2";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnThongKe
            // 
            this.tablePanel2.SetColumn(this.btnThongKe, 3);
            this.btnThongKe.Location = new System.Drawing.Point(634, 93);
            this.btnThongKe.Name = "btnThongKe";
            this.tablePanel2.SetRow(this.btnThongKe, 2);
            this.btnThongKe.Size = new System.Drawing.Size(281, 29);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "simpleButton1";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // comboBox1
            // 
            this.tablePanel2.SetColumn(this.comboBox1, 3);
            this.tablePanel2.SetColumnSpan(this.comboBox1, 4);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(634, 49);
            this.comboBox1.Name = "comboBox1";
            this.tablePanel2.SetRow(this.comboBox1, 1);
            this.comboBox1.Size = new System.Drawing.Size(281, 29);
            this.comboBox1.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.tablePanel2.SetColumn(this.radioButton2, 2);
            this.radioButton2.Location = new System.Drawing.Point(453, 49);
            this.radioButton2.Name = "radioButton2";
            this.tablePanel2.SetRow(this.radioButton2, 1);
            this.radioButton2.Size = new System.Drawing.Size(100, 25);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mặt hàng";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.tablePanel2.SetColumn(this.radioButton1, 1);
            this.radioButton1.Location = new System.Drawing.Point(228, 49);
            this.radioButton1.Name = "radioButton1";
            this.tablePanel2.SetRow(this.radioButton1, 1);
            this.radioButton1.Size = new System.Drawing.Size(104, 25);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nhân viên";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel2.SetColumn(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(453, 10);
            this.label2.Name = "label2";
            this.tablePanel2.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel2.SetColumn(this.label1, 0);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.tablePanel2.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // dateTimePicker2
            // 
            this.tablePanel2.SetColumn(this.dateTimePicker2, 3);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(634, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.tablePanel2.SetRow(this.dateTimePicker2, 0);
            this.dateTimePicker2.Size = new System.Drawing.Size(281, 28);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.tablePanel2.SetColumn(this.dateTimePicker1, 1);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.tablePanel2.SetRow(this.dateTimePicker1, 0);
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 28);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.tablePanel2.SetColumn(this.radioButton3, 0);
            this.radioButton3.Location = new System.Drawing.Point(3, 49);
            this.radioButton3.Name = "radioButton3";
            this.tablePanel2.SetRow(this.radioButton3, 1);
            this.radioButton3.Size = new System.Drawing.Size(78, 25);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Tất cả";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenkh";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tennv";
            this.Column3.HeaderText = "Tên nhân viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngayban";
            this.Column4.HeaderText = "Ngày bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngaygiao";
            this.Column5.HeaderText = "Ngày giao";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tongtien";
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 535);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcel;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}