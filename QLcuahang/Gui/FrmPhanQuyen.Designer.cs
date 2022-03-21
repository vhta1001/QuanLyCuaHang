namespace Gui
{
    partial class FrmPhanQuyen
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
            this.dataPhanQuyen = new System.Windows.Forms.DataGridView();
            this.cboLoaiNV = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2.55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 109.3F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5.73F)});
            this.tablePanel1.Controls.Add(this.dataPhanQuyen);
            this.tablePanel1.Controls.Add(this.cboLoaiNV);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 17F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 57.4F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 570.7973F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1188, 749);
            this.tablePanel1.TabIndex = 0;
            // 
            // dataPhanQuyen
            // 
            this.dataPhanQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePanel1.SetColumn(this.dataPhanQuyen, 1);
            this.dataPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPhanQuyen.Location = new System.Drawing.Point(29, 86);
            this.dataPhanQuyen.Name = "dataPhanQuyen";
            this.tablePanel1.SetRow(this.dataPhanQuyen, 2);
            this.dataPhanQuyen.RowHeadersWidth = 51;
            this.dataPhanQuyen.RowTemplate.Height = 24;
            this.dataPhanQuyen.Size = new System.Drawing.Size(1098, 631);
            this.dataPhanQuyen.TabIndex = 2;
            this.dataPhanQuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPhanQuyen_CellContentClick);
            // 
            // cboLoaiNV
            // 
            this.tablePanel1.SetColumn(this.cboLoaiNV, 1);
            this.cboLoaiNV.FormattingEnabled = true;
            this.cboLoaiNV.Location = new System.Drawing.Point(29, 39);
            this.cboLoaiNV.Name = "cboLoaiNV";
            this.tablePanel1.SetRow(this.cboLoaiNV, 1);
            this.cboLoaiNV.Size = new System.Drawing.Size(1098, 24);
            this.cboLoaiNV.TabIndex = 0;
            this.cboLoaiNV.SelectedIndexChanged += new System.EventHandler(this.cboLoaiNV_SelectedIndexChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IdLoaiNV";
            this.Column2.HeaderText = "Mã loại nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IdManHinh";
            this.Column3.HeaderText = "Màn hình";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CoQuyen";
            this.Column4.FalseValue = "false";
            this.Column4.HeaderText = "Có quyền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.TrueValue = "true";
            // 
            // FrmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 749);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmPhanQuyen";
            this.Text = "FrmPhanQuyen";
            this.Load += new System.EventHandler(this.FrmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhanQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.DataGridView dataPhanQuyen;
        private System.Windows.Forms.ComboBox cboLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
    }
}